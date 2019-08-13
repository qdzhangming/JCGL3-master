namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookSelectChangeHistorys 
    {
        [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(20)]
        public string BookSelectListID { get; set; }

        public int ModifyType { get; set; }

        [Required]
        [StringLength(20)]
        public string CourseCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string CatalogueCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string Operator { get; set; }

        public DateTime ModifyTime { get; set; }
    }
}
