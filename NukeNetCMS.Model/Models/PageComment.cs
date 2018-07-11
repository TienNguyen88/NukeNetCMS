using NukeNetCMS.Model.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("PageComments")]
    public class PageComment : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(128)]
        public string UserID { get; set; }

        public int PageID { get; set; }

        [Required]
        public string Comment { get; set; }

        public int? Star { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("PageID")]
        public virtual Page Page { get; set; }
    }
}