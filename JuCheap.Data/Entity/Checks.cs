namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Checks 
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string PlanCoding { get; set; }

        [Required]
        [StringLength(20)]
        public string CheckCoding { get; set; }

        public int CheckStepNo { get; set; }

        [StringLength(20)]
        public string CheckRoleID { get; set; }

        [StringLength(20)]
        public string CheckuserID { get; set; }

        public DateTime? Checktime { get; set; }

        public int? CheckDeadline { get; set; }

        [MaxLength(512)]
        public byte[] CheckDigitalsignature { get; set; }

        [StringLength(20)]
        public string CheckUserCoding { get; set; }

        public bool? IsAgree { get; set; }

        [StringLength(512)]
        public string Approvalopinions { get; set; }

        [StringLength(20)]
        public string NextStepCoding { get; set; }

        [Column(TypeName = "text")]
        public string Demo { get; set; }
    }
}
