namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Courses 
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string CourseCoding { get; set; }

        [Required]
        [StringLength(200)]
        public string CourseName { get; set; }

        public int CourseType { get; set; }

        public int CoursePeriod { get; set; }

        public int? CourseTestType { get; set; }

        [StringLength(200)]
        public string CourseTeacherOffice { get; set; }

        public DateTime CourseStartTime { get; set; }

        public int? CourseStatus { get; set; }
    }
}
