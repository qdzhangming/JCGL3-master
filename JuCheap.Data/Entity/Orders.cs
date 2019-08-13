namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders 
    {
        [Key]
        [StringLength(20)]
        public string OrderCoding { get; set; }

        public int OrderType { get; set; }

        [Required]
        [StringLength(20)]
        public string OrderUnitCoding { get; set; }

        public decimal BudgetPrice { get; set; }

        public decimal? RealPrice { get; set; }

        [Required]
        [StringLength(20)]
        public string Agent { get; set; }

        public DateTime OrderTime { get; set; }

        public DateTime OrderDeadline { get; set; }
    }
}
