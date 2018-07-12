using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual IEnumerable<ProductTag> ProductTags { get; set; }

        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }
}