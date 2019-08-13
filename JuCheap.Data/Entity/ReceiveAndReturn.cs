namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiveAndReturn")]
    public partial class ReceiveAndReturn 
    {
        [Key]
        [StringLength(20)]
        public string R2RCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string ClassOrderCoding { get; set; }

        public int R2RType { get; set; }

        [Required]
        [StringLength(20)]
        public string Operator { get; set; }

        public DateTime OperatorTime { get; set; }

        [Required]
        [StringLength(20)]
        public string AgentUserCoding { get; set; }
    }
}
