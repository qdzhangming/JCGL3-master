namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PrintLists 
    {
        [Key]
        [StringLength(20)]
        public string PrintListCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string PrintCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string CatalogueCoding { get; set; }

        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        public int? BookProperty { get; set; }

        [StringLength(200)]
        public string Author { get; set; }

        [StringLength(30)]
        public string ISBN { get; set; }

        [StringLength(30)]
        public string BookPN { get; set; }

        [StringLength(30)]
        public string Edition { get; set; }

        [StringLength(200)]
        public string Publisher { get; set; }

        public DateTime? PublishDate { get; set; }

        public int? PrintCount { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? PrintSumPrice { get; set; }

        public int SignInCount { get; set; }

        public bool? PrintStatus { get; set; }
    }
}
