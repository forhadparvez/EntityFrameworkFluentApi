using System.Collections.Generic;

namespace EnittyFrameworkFluentApiApp.Core.Models
{
    public class Course
    {
        public Course()
        {
           Students = new List<Student>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Location { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}