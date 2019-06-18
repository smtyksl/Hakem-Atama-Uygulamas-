namespace OrduAtama
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MacBilgisi")]
    public partial class MacBilgisi
    {
        public int Id { get; set; }

        public int EvSahibiTakimId { get; set; }

        public int DeplasmanTakimId { get; set; }

        public int OrtaHakemId { get; set; }

        public int? BirinciYardimciHakemId { get; set; }

        public int? IkinciYardimciHakemId { get; set; }

        public int KategoriId { get; set; }

        public int Hafta { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Tarih { get; set; }

        [StringLength(150)]
        public string OrtaHakemAd { get; set; }

        [StringLength(150)]
        public string BirinciYardimciHakemAd { get; set; }

        [StringLength(150)]
        public string IkinciYardimciHakemAd { get; set; }

        public int? DorduncuHakemId { get; set; }

        [StringLength(150)]
        public string DorduncuHakemAd { get; set; }

        public virtual Hakem Hakem { get; set; }

        public virtual Hakem Hakem1 { get; set; }

        public virtual Hakem Hakem2 { get; set; }

        public virtual Hakem Hakem3 { get; set; }

        public virtual MacBilgisi MacBilgisi1 { get; set; }

        public virtual MacBilgisi MacBilgisi2 { get; set; }

        public virtual TakimKategori TakimKategori { get; set; }

        public virtual Takimlar Takimlar { get; set; }

        public virtual Takimlar Takimlar1 { get; set; }
    }
}
