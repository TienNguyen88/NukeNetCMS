using NukeNetCMS.Model.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    public class PostComment : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(128)]
        public string UserID { get; set; }

        public int PostID { get; set; }

        [Required]
        public string Comment { get; set; }

        public int? Star { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
    }
}