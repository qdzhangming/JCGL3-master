namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderSignIn")]
    public partial class OrderSignIn 
    {
        [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(20)]
        public string SignInCoding { get; set; }

        public int SignInSource { get; set; }

        [Required]
        [StringLength(20)]
        public string SignInSourceCoding { get; set; }

        public int? SignInTotalCount { get; set; }

        public DateTime SignInStartTime { get; set; }

        public DateTime? SignInEndTime { get; set; }

        [StringLength(20)]
        public string OrderAgent { get; set; }

        [Required]
        [StringLength(20)]
        public string Operator { get; set; }

        public int SignInStatus { get; set; }

        [Column(TypeName = "text")]
        public string Demo { get; set; }
    }
}
