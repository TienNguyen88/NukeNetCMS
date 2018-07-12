using NukeNetCMS.Model.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(2)]
        [Column(TypeName = "varchar")]
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

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Taxonomy { get; set; }

        [ForeignKey("ParentID")]
        public virtual PostCategory ParentPostCategory { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}