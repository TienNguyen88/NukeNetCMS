using NukeNetCMS.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [MaxLength(128)]
        public string UserID { get; set; }

        public int? ShippingID { get; set; }

        public int? CouponID { get; set; }

        public int? PaymentMethodID { get; set; }

        public int? PaymentTransactionID { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerEmail { get; set; }

        [Required]
        [MaxLength(20)]
        public string CustomerMobile { get; set; }

        [MaxLength(500)]
        public string CustomerMessage { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }

        [ForeignKey("ShippingID")]
        public virtual Shipping Shipping { get; set; }

        [ForeignKey("CouponID")]
        public virtual Coupon Coupon { get; set; }

        [ForeignKey("PaymentMethodID")]
        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }

        public virtual IEnumerable<PaymentTransaction> PaymentTransactions { get; set; }
    }
}