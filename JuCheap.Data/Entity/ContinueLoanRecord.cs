namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContinueLoanRecord")]
    public partial class ContinueLoanRecord 
    {
        public int ID { get; set; }

        [Required]
        [StringLength(22)]
        public string BookCodebar { get; set; }

        [Required]
        [StringLength(20)]
        public string Userbar { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int Sum { get; set; }
    }
}
