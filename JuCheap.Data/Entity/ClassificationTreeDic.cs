namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClassificationTreeDic")]
    public partial class ClassificationTreeDic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string CLS_Name { get; set; }

        [Required]
        [StringLength(20)]
        public string CLS_Coding { get; set; }

        [Required]
        [StringLength(200)]
        public string CLS_Expression { get; set; }

        public bool? CLS_IsAheadMatch { get; set; }

        public bool? CLS_Isdefault { get; set; }
    }
}
