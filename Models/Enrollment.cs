using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeFirstStudentsEnrollments.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId {  get; set; }
        
        [Required]
        public int StudentID { get; set; }
        
        [Required]
        public string CourseName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate {  get; set; }

        // setting the navigation Property
        [ForeignKey("StudentID")]
        public Student? Student { get; set; }
    }
}
