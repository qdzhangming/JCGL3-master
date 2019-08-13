namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Releases 
    {
        [Key]
        [StringLength(20)]
        public string ReleaseCoding { get; set; }

        [Required]
        [StringLength(200)]
        public string ReleaseDepartment { get; set; }

        public int ReleaseType { get; set; }

        public int? TopSecret { get; set; }

        [Required]
        [StringLength(200)]
        public string ReleaseAgent { get; set; }

        public DateTime ExecuteTime { get; set; }
    }
}
