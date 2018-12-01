using System.Data.Entity;
using EnittyFrameworkFluentApiApp.Core.Models;
using EnittyFrameworkFluentApiApp.EntityConfigurations;

namespace EnittyFrameworkFluentApiApp.Persistences
{
    public class EntityFrameworkFluentApiDbContext:DbContext
    {
        public EntityFrameworkFluentApiDbContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // for default configuration
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CourseConfiguration());
            modelBuilder.Configurations.Add(new StandardConfiguration());
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new StudentAddressConfiguration());
            modelBuilder.Configurations.Add(new TeacherConfiguration());
        }


    }
}