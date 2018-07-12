using NukeNetCMS.Model.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("ShippingMethods")]
    public class ShippingMethod : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(2)]
        [Column(TypeName = "varchar")]
        public string Language { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        public virtual IEnumerable<Shipping> Shippings { get; set; }
    }
}