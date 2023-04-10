using System.ComponentModel.DataAnnotations;

namespace StudentProjectMgtSystem.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        [Display(Name = "Enrollment ID")]
        public int EnrollmentID { get; set; }
        [Display(Name = "Modules ID")]
        public int ModuleID { get; set; }
        [Display(Name = "Student ID")]
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public virtual Module? Module { get; set; }
        public virtual Student? Student { get; set; }
    }
}