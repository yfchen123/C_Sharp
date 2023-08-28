

using System.ComponentModel.DataAnnotations.Schema;

namespace Chapter12
{
    public class Employee
    {
        string FirstName;
        string LastName;

        public Employee(string FirstName, string LastName) {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public int? ReportTo { get; set; }
        long Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BirthDate { get; set; }
    }
}
