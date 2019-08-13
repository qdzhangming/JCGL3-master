namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GradeOrder")]
    public partial class GradeOrder
    {
        [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(20)]
        public string GradeOrderCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string ClassCoding { get; set; }

        [Required]
        [StringLength(200)]
        public string GradeOrderName { get; set; }

        [Required]
        [StringLength(200)]
        public string GradeOrderSource { get; set; }
    }
}
