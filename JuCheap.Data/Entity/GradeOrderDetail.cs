namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GradeOrderDetail")]
    public partial class GradeOrderDetail 
    {
        [Key]
        [StringLength(20)]
        public string GradeOrderID { get; set; }

        [Required]
        [StringLength(20)]
        public string GradeOrderDetailCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string CatalogueCoding { get; set; }

        public int GradeOrderCounter { get; set; }

        public int HadReceiveCount { get; set; }

        public int GradeOrderStatus { get; set; }
    }
}
