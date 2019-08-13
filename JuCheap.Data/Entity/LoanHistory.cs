namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanHistory")]
    public partial class LoanHistory 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string CatalogueCoding { get; set; }

        [Required]
        [StringLength(22)]
        public string BookCodebar { get; set; }

        [Required]
        [StringLength(20)]
        public string ReaderCoding { get; set; }

        public DateTime OperateTime { get; set; }

        public int OperateType { get; set; }

        [Required]
        [StringLength(20)]
        public string Operator { get; set; }
    }
}
