using System.Data.Entity.ModelConfiguration;
using EnittyFrameworkFluentApiApp.Core.Models;

namespace EnittyFrameworkFluentApiApp.EntityConfigurations
{
    public class TeacherConfiguration:EntityTypeConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            HasKey(t => t.TeacherId);

            // one to many
            HasRequired(t => t.Standard)
                .WithMany(s => s.Teachers)
                .HasForeignKey(t => t.StandardId)
                .WillCascadeOnDelete(false);

            HasMany(t => t.Courses);
        }
    }
}