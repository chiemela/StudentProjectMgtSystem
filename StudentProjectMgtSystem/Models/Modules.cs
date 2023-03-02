using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace StudentProjectMgtSystem.Models
{
    public class Modules
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [DisplayName("Duration In Months")]
        public int DurationInWeeks { get; set; }
        [Required]
        public string? Code { get; set; }
        public string? Lecturer { get; set; }
        [Required]
        [DisplayName("Date Created")]
        [DataType(DataType.Date)]
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;

    }
}