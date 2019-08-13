namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecialityCoursesRelation")]
    public partial class SpecialityCoursesRelation
    {   [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(20)]
        public string SpecialityCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string CourseCoding { get; set; }

        public DateTime OperationTime { get; set; }

        [Required]
        [StringLength(20)]
        public string Operator { get; set; }
    }
}
