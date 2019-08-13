namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClassificationTreeDicContent")]
    public partial class ClassificationTreeDicContent 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string CLS_Coding { get; set; }

        [Required]
        [StringLength(100)]
        public string ClassName { get; set; }

        [Required]
        [StringLength(100)]
        public string ClassCode { get; set; }

        public int ClassLevel { get; set; }

        [StringLength(20)]
        public string ClassParentID { get; set; }

        [Required]
        [StringLength(100)]
        public string ClassLevelCode { get; set; }

        public bool ClassChildFlag { get; set; }

        public int MaxClassSequenceNumber { get; set; }
    }
}
