using NukeNetCMS.Model.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(2)]
        [Column(TypeName = "varchar")]
        public string Language { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Department { get; set; }

        [MaxLength(100)]
        public string Skype { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar")]
        public string Mobile { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(250)]
        public string Facebook { get; set; }

        public bool IsActive { get; set; }
    }
}