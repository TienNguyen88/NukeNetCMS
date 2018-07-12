using NukeNetCMS.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(2)]
        [Column(TypeName = "varchar")]
        public string Language { get; set; }

        public int? CategoryID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        [Column(TypeName = "varchar")]
        public string Slug { get; set; }

        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        public int? UnitInStock { get; set; }

        [MaxLength(250)]
        public string Manufacturer { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }

        public decimal? PriceOriginal { get; set; }

        public decimal Price { get; set; }

        public decimal? Promotion { get; set; }

        public int? Warranty { get; set; }

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
        [Column(TypeName = "varchar")]
        public string Visibility { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string PasswordProtected { get; set; }

        public bool? IsTrash { get; set; }

        public bool IsHot { get; set; }

        public bool IsHome { get; set; }

        public int ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }

        public virtual IEnumerable<ProductImage> ProductImages { get; set; }

        public virtual IEnumerable<ProductTag> ProductTags { get; set; }

        public virtual IEnumerable<ProductComment> ProductComments { get; set; }
    }
}