using System.Data.Entity.ModelConfiguration;
using EnittyFrameworkFluentApiApp.Core.Models;

namespace EnittyFrameworkFluentApiApp.EntityConfigurations
{
    public class CourseConfiguration:EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            HasKey(c => c.CourseId);

            // one to many
            HasRequired(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId)
                .WillCascadeOnDelete(false);

            // one to many
            HasMany(c => c.Students);


        }
    }
}