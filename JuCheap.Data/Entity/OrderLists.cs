namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderLists 
    {
        [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(20)]
        public string OrderListsCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string OrderCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string CataloguesCoding { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Author { get; set; }

        [StringLength(30)]
        public string ISBN { get; set; }

        [StringLength(30)]
        public string BookPN { get; set; }

        [StringLength(30)]
        public string Edition { get; set; }

        [Required]
        [StringLength(200)]
        public string Publisher { get; set; }

        public DateTime? PublishDate { get; set; }

        public int OrderCount { get; set; }

        public int? SignInCount { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? TotalPrice { get; set; }
    }
}
