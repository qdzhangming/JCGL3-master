namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StockOutLists 
    {
        [Key]
        [StringLength(20)]
        public string StockOutListCoding { get; set; }

        public int Source { get; set; }

        [Required]
        [StringLength(20)]
        public string SourceCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string CatalogueCoding { get; set; }

        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        public int ReleaseCount { get; set; }

        public bool? IsIncludeFile { get; set; }

        [Column(TypeName = "text")]
        public string Demo { get; set; }
    }
}
