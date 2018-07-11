using NukeNetCMS.Model.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("Areas")]
    public class Area : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int CountryID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("CountryID")]
        public virtual Country Country { get; set; }

        public virtual IEnumerable<Shipping> Shippings { get; set; }
    }
}