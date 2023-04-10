using System.ComponentModel.DataAnnotations;

namespace StudentProjectMgtSystem.Models
{
    public class CourseLecturer
    {
        [Display(Name = "Course Lecturer ID")]
        public int CourseLecturerID { get; set; }
        [Display(Name = "Modules ID")]
        public int ModuleID { get; set; }
        [Display(Name = "Instructor ID")]
        public int InstructorID { get; set; }
        public virtual ICollection<Module>? Module { get; set; }
        public virtual ICollection<Instructor>? Instructor { get; set; }
    }
}