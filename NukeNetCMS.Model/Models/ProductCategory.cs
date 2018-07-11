using NukeNetCMS.Model.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(2)]
        public string Language { get; set; }

        public int? ParentID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Slug { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Icon { get; set; }

        public int DisplayOrder { get; set; }

        [MaxLength(250)]
        public string MetaKeywords { get; set; }

        [MaxLength(250)]
        public string MetaDescription { get; set; }

        public bool IsActive { get; set; }

        public bool IsHot { get; set; }

        public bool IsHome { get; set; }

        [ForeignKey("ParentID")]
        public virtual ProductCategory ParentProductCategory { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}