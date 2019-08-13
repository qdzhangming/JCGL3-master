namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Classification")]
    public partial class Classification 
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string CategoriesCoding { get; set; }

        [Required]
        [StringLength(100)]
        public string CLS_Name { get; set; }

        [Required]
        [StringLength(20)]
        public string CLS_Coding { get; set; }

        [Required]
        [StringLength(20)]
        public string ClassCode { get; set; }

        [Required]
        [StringLength(100)]
        public string ClassName { get; set; }

        public int ClassSequenceNumber { get; set; }
    }
}
