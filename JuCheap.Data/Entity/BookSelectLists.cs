namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookSelectLists 
    {
        [Key]
        [StringLength(20)]
        public string BookSelectListID { get; set; }

        [Required]
        [StringLength(20)]
        public string CourseCoding { get; set; }

        [Required]
        [StringLength(200)]
        public string CourseName { get; set; }

        [StringLength(200)]
        public string SpecialityName { get; set; }

        [Required]
        [StringLength(20)]
        public string CatalogueCoding { get; set; }

        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        public bool? BookProperty { get; set; }

        [StringLength(200)]
        public string Author { get; set; }

        [StringLength(30)]
        public string ISBN { get; set; }

        [StringLength(30)]
        public string BookPN { get; set; }

        [StringLength(30)]
        public string Edition { get; set; }

        [StringLength(200)]
        public string Publisher { get; set; }

        public DateTime? PublishDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Semester { get; set; }

        [Required]
        [StringLength(20)]
        public string SelectUserID { get; set; }

        public DateTime SelectTime { get; set; }
    }
}
