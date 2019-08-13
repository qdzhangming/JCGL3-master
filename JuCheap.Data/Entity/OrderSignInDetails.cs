namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderSignInDetails 
    {
        [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(20)]
        public string SignInCodingDetail { get; set; }

        [Required]
        [StringLength(20)]
        public string SignInCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string CatalogueCoding { get; set; }

        public int SignInCount { get; set; }

        public DateTime SignInTime { get; set; }

        [Required]
        [StringLength(20)]
        public string Operator { get; set; }
    }
}
