using System.Collections.Generic;

namespace EnittyFrameworkFluentApiApp.Core.Models
{
    public class Standard
    {
        public Standard()
        {
            Teachers = new List<Teacher>();
            Students=new List<Student>();
        }

        public int StandartId { get; set; }
        public string StandardName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Teacher> Teachers{ get; set; }
        public virtual ICollection<Student> Students{ get; set; }
        
    }
}