namespace OrduAtama
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hakem")]
    public partial class Hakem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hakem()
        {
            HakemCezas = new HashSet<HakemCeza>();
            MacBilgisis = new HashSet<MacBilgisi>();
            MacBilgisis1 = new HashSet<MacBilgisi>();
            MacBilgisis2 = new HashSet<MacBilgisi>();
            MacBilgisis3 = new HashSet<MacBilgisi>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        [Required]
        [StringLength(50)]
        public string SoyAd { get; set; }

        public int? LisansNo { get; set; }

        public int KlasmanId { get; set; }

        public int VizeDurumuId { get; set; }

        [StringLength(150)]
        public string KlasmanAdi { get; set; }

        [StringLength(150)]
        public string VizeDurumu { get; set; }

        [StringLength(300)]
        public string AdSoyAd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HakemCeza> HakemCezas { get; set; }

        public virtual Klasman Klasman { get; set; }

        public virtual VizeDurumu VizeDurumu1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MacBilgisi> MacBilgisis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MacBilgisi> MacBilgisis1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MacBilgisi> MacBilgisis2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MacBilgisi> MacBilgisis3 { get; set; }
    }
}
