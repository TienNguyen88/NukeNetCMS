using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("PaymentTransactions")]
    public class PaymentTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public Guid? OrderID { get; set; }

        [Required]
        [MaxLength(250)]
        public string TransactionCode { get; set; }

        [MaxLength(250)]
        public string Portal { get; set; }

        [Required]
        [MaxLength(20)]
        public string CardID { get; set; }

        [Required]
        [MaxLength(50)]
        public string CardName { get; set; }

        [Required]
        [MaxLength(2)]
        public string CardExpireMonth { get; set; }

        [Required]
        [MaxLength(2)]
        public string CardExpireYear { get; set; }

        [MaxLength(50)]
        public string CardCVV { get; set; }

        [MaxLength(100)]
        public string BankName { get; set; }

        [MaxLength(250)]
        public string Token { get; set; }

        public DateTime? TokenExpire { get; set; }

        public bool IsStatus { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? SuccessDate { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }
    }
}