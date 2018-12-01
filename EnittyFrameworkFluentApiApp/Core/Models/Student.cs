using System.Collections.Generic;

namespace EnittyFrameworkFluentApiApp.Core.Models
{ 
    public class Student
    {
        public Student()
        {
            Courses=new List<Course>();
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int StandardId { get; set; }
        public Standard Standard { get; set; }
        
        public virtual StudentAddress StudentAddress { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}