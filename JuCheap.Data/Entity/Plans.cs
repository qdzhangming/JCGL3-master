namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Plans 
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string PlanCoding { get; set; }

        [Required]
        [StringLength(100)]
        public string PlanName { get; set; }

        [Required]
        [StringLength(30)]
        public string CheckSource { get; set; }

        [Required]
        [StringLength(20)]
        public string SourceCoding { get; set; }

        public int PlanType { get; set; }

        public bool NeedCheck { get; set; }

        public int? CheckStatus { get; set; }

        public int PlanStatus { get; set; }

        [StringLength(512)]
        public string PlanContent { get; set; }

        public DateTime CreatTime { get; set; }

        [Required]
        [StringLength(20)]
        public string Operator { get; set; }
    }
}
