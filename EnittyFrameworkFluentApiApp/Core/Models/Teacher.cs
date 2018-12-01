using System.Collections.Generic;

namespace EnittyFrameworkFluentApiApp.Core.Models
{
    public class Teacher
    {
        public Teacher()
        {
            Courses=new List<Course>();
        }

        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherType { get; set; }

        public int? StandardId { get; set; }
        public virtual Standard Standard { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}