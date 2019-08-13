namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiveAndReturnList")]
    public partial class ReceiveAndReturnList 
    {
        [Key]
        [StringLength(20)]
        public string R2RListCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string R2RCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string CatalogueCoding { get; set; }

        public int R2RCount { get; set; }

        public DateTime OperateTime { get; set; }

        public int OperateType { get; set; }

        [Required]
        [StringLength(20)]
        public string Operator { get; set; }
    }
}
