namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StockChangeHistorys 
    {
        [StringLength(20)]
        public string ID { get; set; }

        public int InOrOut { get; set; }

        public int StockChangeSource { get; set; }

        [Required]
        [StringLength(20)]
        public string StockChangeSourceCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string CatalogueCoding { get; set; }

        [StringLength(22)]
        public string BookCodebar { get; set; }

        public int BookStatus { get; set; }

        [Required]
        [StringLength(20)]
        public string BookCoding { get; set; }

        public int StockChangeCount { get; set; }

        [Required]
        [StringLength(20)]
        public string Operator { get; set; }

        public DateTime OperationTime { get; set; }
    }
}
