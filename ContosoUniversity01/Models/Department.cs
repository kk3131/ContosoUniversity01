using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity01.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        public Instructor? Administrator { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
