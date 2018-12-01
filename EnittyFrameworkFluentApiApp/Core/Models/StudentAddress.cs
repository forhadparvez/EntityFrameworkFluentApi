namespace EnittyFrameworkFluentApiApp.Core.Models
{
    public class StudentAddress
    {
        public int StudentAddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public virtual Student Student { get; set; }
    }
}