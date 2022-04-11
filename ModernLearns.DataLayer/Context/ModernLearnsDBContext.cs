using Microsoft.EntityFrameworkCore;
using ModernLearns.DataLayer.Entities.AboutUs;
using ModernLearns.DataLayer.Entities.ContactUs;
using ModernLearns.DataLayer.Entities.Course;
using ModernLearns.DataLayer.Entities.Order;
using ModernLearns.DataLayer.Entities.Permissions;
using ModernLearns.DataLayer.Entities.User;
using ModernLearns.DataLayer.Entities.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernLearns.DataLayer.Context
{
    public class ModernLearnsDBContext:DbContext
    {
        public ModernLearnsDBContext(DbContextOptions<ModernLearnsDBContext> options):base(options)
        {

        }

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserDiscountCode> UserDiscountCodes { get; set; }


        #endregion

        #region Wallet
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<WalletType> WalletTypes { get; set; }
        #endregion

        #region Permission
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        #endregion

        #region Order
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        #endregion

        #region Course
        public DbSet<CourseGroup> CourseGroups { get; set; }
        public DbSet<CourseStatus> CourseStatuses { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet<CourseEpisode> CourseEpisodes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
        public DbSet<CourseComment> CourseComments { get; set; }
        public DbSet<CourseVote> CourseVotes { get; set; }
        #endregion

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<ContactUsForm> ContactUsForms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDelete);
            modelBuilder.Entity<Role>()
                .HasQueryFilter(r => !r.IsDelete);
            modelBuilder.Entity<Course>()
                .HasQueryFilter(c => !c.IsDelete)
                .HasOne<CourseGroup>(g => g.Group).WithMany(g => g.SubGroup).HasForeignKey(g => g.SubGroup);
            modelBuilder.Entity<CourseGroup>()
                .HasQueryFilter(c => !c.IsDelete);
            modelBuilder.Entity<CourseComment>()
                .HasQueryFilter(c => !c.IsDelete);

            base.OnModelCreating(modelBuilder);
        }
    }
}
