namespace OrduAtama
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TakimKategori")]
    public partial class TakimKategori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TakimKategori()
        {
            MacBilgisis = new HashSet<MacBilgisi>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Ad { get; set; }

        [Required]
        [StringLength(300)]
        public string Kodu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MacBilgisi> MacBilgisis { get; set; }
    }
}
