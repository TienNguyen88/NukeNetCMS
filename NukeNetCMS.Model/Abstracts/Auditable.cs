using System;
using System.ComponentModel.DataAnnotations;

namespace NukeNetCMS.Model.Abstracts
{
    public abstract class Auditable
    {
        public DateTime? CreatedDate { get; set; }

        [MaxLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(50)]
        public string UpdatedBy { get; set; }
    }
}