using NukeNetCMS.Model.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("ProductComments")]
    public class ProductComment : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(128)]
        public string UserID { get; set; }

        public int ProductID { get; set; }

        [Required]
        public string Comment { get; set; }

        public int? Star { get; set; }

        public bool IsActive { get; set; }

        public virtual Product Product { get; set; }
    }
}