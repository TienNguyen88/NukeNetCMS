using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key, Column(Order = 0)]
        public Guid OrderID { get; set; }

        [Key, Column(Order = 1)]
        public int ProductID { get; set; }

        public decimal? PriceOriginal { get; set; }

        public decimal Price { get; set; }

        public decimal? Promotion { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}