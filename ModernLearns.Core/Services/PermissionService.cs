using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModernLearns.Core.Services.Interfaces;
using ModernLearns.DataLayer.Context;
using ModernLearns.DataLayer.Entities.Permissions;
using ModernLearns.DataLayer.Entities.User;

namespace ModernLearns.Core.Services
{
    public class PermissionService: IPermissionService
    {
        private ModernLearnsDBContext _context;
        public PermissionService(ModernLearnsDBContext context)
        {
            _context = context;
        }

        public void AddPermissionsToRole(int roleId, List<int> permission)
        {
            foreach(var p in permission)
            {
                _context.RolePermissions.Add(new RolePermission()
                {
                    PermissionId = p,
                    RoleId = roleId
                });
            }
            _context.SaveChanges();
        }

        public int AddRole(Role role)
        {
             _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }

        public void AddRolesToUser(List<int> roleIds, int userId)
        {
            foreach(int roleId in roleIds)
            {
                _context.UserRoles.Add(new UserRole()
                {
                    RoleId=roleId,
                    UserId=userId
                });
                _context.SaveChanges();
            }
        }

        public bool CheckPermission(int permissionId, string userName)
        {
            int userId = _context.Users.Single(u => u.UserName == userName).UserId;

            List<int> UserRoles = _context.UserRoles
                .Where(r => r.UserId == userId).Select(r => r.RoleId).ToList();

            if (!UserRoles.Any())
                return false;

            List<int> RolePermission = _context.RolePermissions
                .Where(p => p.PermissionId == permissionId)
                .Select(p => p.RoleId).ToList();

            return RolePermission.Any(p => UserRoles.Contains(p));
        }

        public bool DeleteRole(int roleId)
        {
            var role = GetRoleById(roleId);
            role.IsDelete = true;
            UpdateRole(role);
            return true;
        }

        public void EditRolesUser(int userId, List<int> rolesId)
        {
            //DeleteAllRoles User
            _context.UserRoles.Where(r => r.UserId == userId).ToList().ForEach(r => _context.UserRoles.Remove(r));

            //AddNewRoles
            AddRolesToUser(rolesId, userId);
        }

        public List<Permission> GetAllPermission()
        {
            return _context.Permissions.ToList();
        }

        public Role GetRoleById(int roleId)
        {
            return _context.Roles.Find(roleId);
        }

        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }

        public List<int> PermissionsRole(int roleId)
        {
            return _context.RolePermissions
                .Where(r => r.RoleId == roleId)
                .Select(r => r.PermissionId).ToList();
        }

        public void UpdatePermissionsRole(int roleId, List<int> permission)
        {
            _context.RolePermissions.Where(p => p.RoleId == roleId)
                .ToList().ForEach(p => _context.RolePermissions.Remove(p));

            AddPermissionsToRole(roleId, permission);
        }

        public void UpdateRole(Role role)
        {
            _context.Update(role);
            _context.SaveChanges();
        }
    }
}
