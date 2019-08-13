namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoleConfig")]
    public partial class RoleConfigEntity 
    {
        public int ID { get; set; }

        public int TopSecretLN { get; set; }

        public int MidSecretLN { get; set; }

        public int LowSecretLN { get; set; }

        public int InternalLN { get; set; }

        public int PublicLN { get; set; }

        public int TopSecretLD { get; set; }

        public int MidSecretLD { get; set; }

        public int LowSecretLD { get; set; }

        public int InternalLD { get; set; }

        public int PublicLD { get; set; }

        public int TopSecretLCD { get; set; }

        public int MidSecretLCD { get; set; }

        public int LowSecretLCD { get; set; }

        public int InternalLCD { get; set; }

        public int PublicLCD { get; set; }

        public int TopSecretLCT { get; set; }

        public int MidSecretLCT { get; set; }

        public int LowSecretLCT { get; set; }

        public int InternalLCT { get; set; }

        public int PublicLCT { get; set; }

        public int TotalLN { get; set; }
    }
}
