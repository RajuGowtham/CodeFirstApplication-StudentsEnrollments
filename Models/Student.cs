using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace CodeFirstStudentsEnrollments.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        public string? FullName {  get; set; }

        public string? Email { get; set; }

        public IList<Enrollment> Enrollments { get; set; }
    }
}
