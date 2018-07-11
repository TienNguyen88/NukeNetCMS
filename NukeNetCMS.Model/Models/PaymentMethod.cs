using NukeNetCMS.Model.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("PaymentMethods")]
    public class PaymentMethod : Auditable
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

        public bool IsActive { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}