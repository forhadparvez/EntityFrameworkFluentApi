using System.Data.Entity.ModelConfiguration;
using EnittyFrameworkFluentApiApp.Core.Models;

namespace EnittyFrameworkFluentApiApp.EntityConfigurations
{
    public class StudentAddressConfiguration:EntityTypeConfiguration<StudentAddress>
    {
        public StudentAddressConfiguration()
        {
            HasKey(ad => ad.StudentAddressId);

            HasRequired(s => s.Student);
        }
    }
}