namespace OrduAtama
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HakemCeza")]
    public partial class HakemCeza
    {
        public int Id { get; set; }

        public int HakemId { get; set; }

        public DateTime? CezaBaslangicTarihi { get; set; }

        public DateTime? CezaBitisTarihi { get; set; }

        public int? CezaBaslangicHafta { get; set; }

        public int? CezaBitisHafta { get; set; }

        [StringLength(150)]
        public string HakemAd { get; set; }

        [StringLength(150)]
        public string HakemSoyAd { get; set; }

        public virtual Hakem Hakem { get; set; }
    }
}
