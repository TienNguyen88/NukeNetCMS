using NukeNetCMS.Model.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("Shippings")]
    public class Shipping : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int ShippingMethodID { get; set; }

        public int AreaID { get; set; }

        public decimal Fee { get; set; }

        public int? Percent { get; set; }

        [ForeignKey("ShippingMethodID")]
        public virtual ShippingMethod ShippingMethods { get; set; }

        [ForeignKey("AreaID")]
        public virtual Area Area { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}