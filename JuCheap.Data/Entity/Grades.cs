namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Grades 
    {
        [Key]
        [StringLength(20)]
        public string ClassCoding { get; set; }

        [Required]
        [StringLength(200)]
        public string ClassName { get; set; }

        public int? TrainLevel { get; set; }

        [Required]
        [StringLength(200)]
        public string BelongBrigade { get; set; }

        [Required]
        [StringLength(200)]
        public string EducationTime { get; set; }

        [Required]
        [StringLength(200)]
        public string ProfessionalName { get; set; }

        [StringLength(20)]
        public string ClassManagerID { get; set; }

        public int ClassStudentCount { get; set; }

        [StringLength(50)]
        public string ClassTelephone { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int ClassStatus { get; set; }
    }
}
