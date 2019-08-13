namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookSelectReports 
    {
        [Key]
        [StringLength(20)]
        public string BookSelectCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string Operator { get; set; }

        public DateTime OperationDate { get; set; }
    }
}
