using System.Data.Entity.ModelConfiguration;
using EnittyFrameworkFluentApiApp.Core.Models;

namespace EnittyFrameworkFluentApiApp.EntityConfigurations
{
    public class StandardConfiguration:EntityTypeConfiguration<Standard>
    {
        public StandardConfiguration()
        {
            HasKey(s => s.StandartId);

            HasMany(s => s.Teachers);
            HasMany(s => s.Students);
        }
    }
}