using System;
using System.Collections.Generic;
using System.Text;
using ModernLearns.DataLayer.Entities.Permissions;
using ModernLearns.DataLayer.Entities.User;

namespace ModernLearns.Core.Services.Interfaces
{
    public interface IPermissionService
    {
        #region Role
        List<Role> GetRoles();
        Role GetRoleById(int roleId);
        int AddRole(Role role);
        bool DeleteRole(int roleId);
        void UpdateRole(Role role);
        void AddRolesToUser(List<int> roleIds, int userId);
        void EditRolesUser(int userId, List<int> rolesId);
        #endregion

        #region Permission
        List<Permission> GetAllPermission();
        void AddPermissionsToRole(int roleId, List<int> permission);
        List<int> PermissionsRole(int roleId);
        void UpdatePermissionsRole(int roleId, List<int> permission);
        bool CheckPermission(int permissionId, string userName);
        #endregion
    }
}
