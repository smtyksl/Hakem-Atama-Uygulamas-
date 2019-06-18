namespace OrduAtama
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gozlemci")]
    public partial class Gozlemci
    {
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
        public string VizeDurumu { get; set; }

        [StringLength(150)]
        public string KlasmanAdi { get; set; }

        public virtual GozlemciKlasman GozlemciKlasman { get; set; }

        public virtual VizeDurumu VizeDurumu1 { get; set; }
    }
}
