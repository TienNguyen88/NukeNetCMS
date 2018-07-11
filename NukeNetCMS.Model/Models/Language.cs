using NukeNetCMS.Model.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("Languages")]
    public class Language : Auditable
    {
        [Key]
        [MaxLength(2)]
        public string Code { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        public bool IsActive { get; set; }

        public bool IsDefault { get; set; }
    }
}