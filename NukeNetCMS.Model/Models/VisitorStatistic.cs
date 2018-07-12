using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NukeNetCMS.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(128)]
        public string UserID { get; set; }

        public DateTime? VisitedDate { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar")]
        public string IPAddress { get; set; }

        [MaxLength(250)]
        public string Browser { get; set; }

        [MaxLength(100)]
        public string OperateSystem { get; set; }

        public DateTime? OutVisitedDate { get; set; }

        public int? VisitedTime { get; set; }
    }
}