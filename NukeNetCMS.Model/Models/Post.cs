using NukeNetCMS.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(2)]
        public string Language { get; set; }

        public int? CategoryID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Slug { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }

        public DateTime? PublishedDate { get; set; }

        public DateTime? ExpireDate { get; set; }

        public bool? IsComment { get; set; }

        public int DisplayOrder { get; set; }

        [MaxLength(250)]
        public string MetaKeywords { get; set; }

        [MaxLength(250)]
        public string MetaDescription { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [MaxLength(50)]
        public string Visibility { get; set; }

        [MaxLength(50)]
        public string PasswordProtected { get; set; }

        public bool? IsTrash { get; set; }

        public bool IsHot { get; set; }

        public bool IsHome { get; set; }

        public int ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { get; set; }

        public virtual IEnumerable<PostTag> PostTags { get; set; }

        public virtual IEnumerable<PostComment> PostComments { get; set; }
    }
}