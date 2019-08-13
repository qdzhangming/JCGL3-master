namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Speciality")]
    public partial class Speciality 
    {
        [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(20)]
        public string SpecialityCoding { get; set; }

        [Required]
        [StringLength(200)]
        public string SpecialityName { get; set; }

        public int EducationType { get; set; }

        public int SpecialityType { get; set; }

        [Required]
        [StringLength(200)]
        public string SpecialityOfDepartment { get; set; }

        [Required]
        [StringLength(200)]
        public string SpecialityOfCollege { get; set; }

        public int SpecialityStatus { get; set; }
    }
}
