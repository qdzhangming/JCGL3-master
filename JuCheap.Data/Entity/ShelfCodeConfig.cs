namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShelfCodeConfig")]
    public partial class ShelfCodeConfig 
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string LocationCoding { get; set; }

        [Required]
        [StringLength(30)]
        public string ShelfCode { get; set; }

        [Required]
        [StringLength(30)]
        public string ShelfName { get; set; }
    }
}
