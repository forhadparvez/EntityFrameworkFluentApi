using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using EnittyFrameworkFluentApiApp.Core.Models;

namespace EnittyFrameworkFluentApiApp.EntityConfigurations
{
    public class StudentConfiguration: EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            // key
            HasKey(s => s.StudentId);

            // one to zero or one
            HasOptional(s => s.StudentAddress)
                .WithRequired(ad => ad.Student)
                .WillCascadeOnDelete(false);

            // one to many
            HasRequired(s => s.Standard)
                .WithMany(s => s.Students)
                .HasForeignKey(s=>s.StandardId)
                .WillCascadeOnDelete(false);

            // many to many
            HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .Map(cs =>
                {
                    cs.MapLeftKey("StudentRefId");
                    cs.MapRightKey("CourseRefId");
                    cs.ToTable("StudentCourse");
                });
        }
    }
}