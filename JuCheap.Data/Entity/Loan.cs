namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loan")]
    public partial class Loan 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string CatalogueCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string BookCodebar { get; set; }

        [Required]
        [StringLength(20)]
        public string ReaderCoding { get; set; }

        public DateTime LoanTime { get; set; }

        public DateTime DueTime { get; set; }

        public bool ContinueFlag { get; set; }

        public DateTime ReturnTime { get; set; }
    }
}
