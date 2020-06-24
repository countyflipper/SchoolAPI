using Entities.Configuration;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrganizationConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new CourseSectionConfiguration());
            modelBuilder.ApplyConfiguration(new SectionEnrollManageConfiguration());
            modelBuilder.ApplyConfiguration(new SectionAssignConfiguration());
            modelBuilder.ApplyConfiguration(new CourseManagementConfiguration());
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<CourseSection> CourseSection { get; set; }
        public DbSet<SectionEnrollManage>  SectionEnrollManages { get; set; }

        public DbSet<SectionAssign> SectionAssigns { get; set; }

        public DbSet<CourseManagement> CourseManagements { get; set; }
    }
}