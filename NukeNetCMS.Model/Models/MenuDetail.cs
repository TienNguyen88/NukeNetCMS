using NukeNetCMS.Model.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("MenuDetails")]
    public class MenuDetail : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int MenuID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string URL { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "varchar")]
        public string Target { get; set; }

        public bool IsActive { get; set; }

        public int DisplayOrder { get; set; }

        [ForeignKey("MenuID")]
        public virtual Menu Menu { get; set; }
    }
}