namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Books 
    {
        [Key]
        [StringLength(20)]
        public string BookCoding { get; set; }

        [Required]
        [StringLength(22)]
        public string BookCodebar { get; set; }

        [Required]
        [StringLength(20)]
        public string CatalogueCoding { get; set; }

        public int BookCount { get; set; }

        [StringLength(20)]
        public string LocationCoding { get; set; }

        public int StateFlag { get; set; }

        [StringLength(20)]
        public string ShelfCoding { get; set; }
    }
}
