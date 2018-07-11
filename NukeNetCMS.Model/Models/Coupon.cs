using NukeNetCMS.Model.Abstracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("Coupons")]
    public class Coupon : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int? Percent { get; set; }

        public DateTime? ExpireDate { get; set; }

        public bool IsActive { get; set; }
    }
}