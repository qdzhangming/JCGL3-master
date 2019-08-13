namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Location")]
    public partial class Location
    { 
        [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string LocationName { get; set; }

        [Required]
        [StringLength(50)]
        public string LocationCode { get; set; }

        [StringLength(350)]
        public string StockAdress { get; set; }

        public int? StockProperty { get; set; }
    }
}
