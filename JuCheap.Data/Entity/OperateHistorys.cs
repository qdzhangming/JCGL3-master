namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OperateHistorys 
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Operator { get; set; }

        public int Actions { get; set; }

        [StringLength(50)]
        public string IPAdrees { get; set; }

        public DateTime OPtime { get; set; }

        public bool Operated { get; set; }

        [Column(TypeName = "text")]
        public string OpContent { get; set; }

        [Column(TypeName = "text")]
        public string Demo { get; set; }
    }
}
