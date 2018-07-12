using NukeNetCMS.Model.Abstracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("Pages")]
    public class Page : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(2)]
        public string Language { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string Slug { get; set; }

        public string Content { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        [MaxLength(250)]
        public string MetaDescription { get; set; }

        [MaxLength(250)]
        public string MetaKeywords { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime? ExpireDate { get; set; }

        public DateTime? PublishedDate { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [MaxLength(50)]
        public string Visibility { get; set; }

        [MaxLength(50)]
        public string PasswordProtected { get; set; }

        public bool? IsTrash { get; set; }

        public bool IsDefault { get; set; }

        public int ViewCount { get; set; }

        public virtual IEquatable<PageComment> PageComments { get; set; }
    }
}