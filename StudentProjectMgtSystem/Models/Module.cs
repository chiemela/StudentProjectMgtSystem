using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace StudentProjectMgtSystem.Models
{
    public class Module
    {
        [Key]
        [DisplayName("Module ID")]
        public int ModuleID { get; set; }
        [Required]
        [DisplayName("Module Code")]
        public string? Code { get; set; }
        [Required]
        [DisplayName("Module Name")]
        public string? Name { get; set; }
        [DisplayName("Instructor ID")]
        public int InstructorID { get; set; }
        [Required]
        [DisplayName("Duration In Weeks")]
        public int DurationInWeeks { get; set; }
        [Required]
        [DisplayName("Date Created")]
        [DataType(DataType.Date)]
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;
        public virtual ICollection<Instructor>? Instructor { get; set; }

    }
}