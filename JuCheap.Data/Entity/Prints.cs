namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Prints 
    {
        [Key]
        [StringLength(20)]
        public string PrintCoding { get; set; }

        [Required]
        [StringLength(250)]
        public string PrintCompany { get; set; }

        public int PlanType { get; set; }

        public int? TopSecret { get; set; }

        [Required]
        [StringLength(100)]
        public string PrintAgent { get; set; }

        public DateTime? PrintTime { get; set; }

        public DateTime PrintFinishTime { get; set; }

        public bool? IsGivenFile { get; set; }

        public decimal? SumPrice { get; set; }
    }
}
