using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentProjectMgtSystem.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string? LastName { get; set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        public string? Role { get; set; }

        [DisplayName("Is Logged In")]
        public string? IsLoggedIn { get; set;}

        [Required]
        public DateTime? CreatedDateTime { get; set;} = DateTime.Now;

    }
}
