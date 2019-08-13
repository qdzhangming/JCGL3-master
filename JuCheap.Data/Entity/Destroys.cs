namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Destroys 
    {
        [Key]
        [StringLength(20)]
        public string DestroyCoding { get; set; }

        [Required]
        [StringLength(100)]
        public string DestroyUnit { get; set; }

        public int? DestroyType { get; set; }

        public int? TopSecret { get; set; }

        [Required]
        [StringLength(20)]
        public string DestroyAgent { get; set; }

        public DateTime ExecuteTime { get; set; }
    }
}
