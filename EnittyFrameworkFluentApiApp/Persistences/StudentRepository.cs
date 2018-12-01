using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnittyFrameworkFluentApiApp.Core.Models;

namespace EnittyFrameworkFluentApiApp.Persistences
{
    public class StudentRepository
    {
        private EntityFrameworkFluentApiDbContext _db=new EntityFrameworkFluentApiDbContext();

        public IEnumerable<Student> GetAll()
        {
           return _db.Students
               .Include(c=>c.Standard)
               .Include(c=>c.Courses)
               .ToList();
        }
    }
}
