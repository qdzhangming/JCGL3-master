namespace JuCheap.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Catalogues 
    {
        [Key]
        [StringLength(20)]
        public string CatalogueCoding { get; set; }

        public int DocumentType { get; set; }

        public int SecretCode { get; set; }

        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        [StringLength(300)]
        public string OtherTitle { get; set; }

        [StringLength(300)]
        public string Author { get; set; }

        [StringLength(300)]
        public string SubAuthor { get; set; }

        [StringLength(300)]
        public string SubModeOfResponsibility { get; set; }

        [StringLength(600)]
        public string Keywords { get; set; }

        [StringLength(800)]
        public string EngKeywords { get; set; }

        [Column(TypeName = "text")]
        public string Summary { get; set; }

        [Column(TypeName = "text")]
        public string EngSummary { get; set; }

        [StringLength(200)]
        public string Publisher { get; set; }

        public DateTime? PublishDate { get; set; }

        [StringLength(50)]
        public string PublishPlace { get; set; }

        public int? DocumentExpression { get; set; }

        public int? CarrieNum { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [StringLength(50)]
        public string Edition { get; set; }

        public int? Pages { get; set; }

        public decimal? BookPrice { get; set; }

        public int? CopyNumber { get; set; }

        public int? CodingNumber { get; set; }

        public int? Docattribute { get; set; }

        [StringLength(255)]
        public string CoverImageURL { get; set; }

        public int? Language { get; set; }

        [StringLength(100)]
        public string BookSize { get; set; }

        public DateTime? CatalogueTime { get; set; }

        [Required]
        [StringLength(20)]
        public string Operator { get; set; }

        public int? MaxCodingNumber { get; set; }

        [Column(TypeName = "xml")]
        public string AppendPropoty { get; set; }

        [Column(TypeName = "text")]
        public string Demo { get; set; }
    }
}
