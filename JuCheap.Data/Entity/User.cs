namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User 
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(20)]
        public string RoleID { get; set; }

        [StringLength(20)]
        public string UserBar { get; set; }

        [StringLength(1024)]
        public string OneCardPassID { get; set; }

        [StringLength(512)]
        public string Password { get; set; }

        [MaxLength(2048)]
        public byte[] Fingerprint1 { get; set; }

        [MaxLength(2048)]
        public byte[] Fingerprint2 { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public bool? UserSex { get; set; }

        [Required]
        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [Required]
        [StringLength(50)]
        public string CardType { get; set; }

        [Required]
        [StringLength(50)]
        public string CardNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string UserType { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsUseValidity { get; set; }

        [Required]
        [StringLength(50)]
        public string UserStatus { get; set; }

        public DateTime CardValidity { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        public int? LoanedCount { get; set; }

        public int? SumLoanedCount { get; set; }

        [Column(TypeName = "text")]
        public string Demo { get; set; }
    }
}
