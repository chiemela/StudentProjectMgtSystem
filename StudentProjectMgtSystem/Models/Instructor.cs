using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;
using System.Diagnostics;

namespace StudentProjectMgtSystem.Models
{
    public class Instructor
    {
        [Key]
        [Display(Name = "Instructor ID")]
        public int InstructorID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }
        [Display(Name = "Instructor Name")]
        public string? Role { get; set; }
        [DisplayName("Is Logged In")]
        public string? IsLoggedIn { get; set; }
        [Display(Name = "Registration Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
