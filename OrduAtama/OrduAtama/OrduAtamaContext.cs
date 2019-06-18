namespace OrduAtama
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OrduAtamaContext : DbContext
    {
        public OrduAtamaContext()
            : base("name=OrduAtamaContext1")
        {
        }

        public virtual DbSet<Gozlemci> Gozlemcis { get; set; }
        public virtual DbSet<GozlemciKlasman> GozlemciKlasmen { get; set; }
        public virtual DbSet<Hakem> Hakems { get; set; }
        public virtual DbSet<HakemCeza> HakemCezas { get; set; }
        public virtual DbSet<Klasman> Klasmen { get; set; }
        public virtual DbSet<MacBilgisi> MacBilgisis { get; set; }
        public virtual DbSet<TakimKategori> TakimKategoris { get; set; }
        public virtual DbSet<Takimlar> Takimlars { get; set; }
        public virtual DbSet<VizeDurumu> VizeDurumus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GozlemciKlasman>()
                .HasMany(e => e.Gozlemcis)
                .WithRequired(e => e.GozlemciKlasman)
                .HasForeignKey(e => e.KlasmanId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hakem>()
                .HasMany(e => e.HakemCezas)
                .WithRequired(e => e.Hakem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hakem>()
                .HasMany(e => e.MacBilgisis)
                .WithRequired(e => e.Hakem)
                .HasForeignKey(e => e.OrtaHakemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hakem>()
                .HasMany(e => e.MacBilgisis1)
                .WithOptional(e => e.Hakem1)
                .HasForeignKey(e => e.BirinciYardimciHakemId);

            modelBuilder.Entity<Hakem>()
                .HasMany(e => e.MacBilgisis2)
                .WithOptional(e => e.Hakem2)
                .HasForeignKey(e => e.IkinciYardimciHakemId);

            modelBuilder.Entity<Hakem>()
                .HasMany(e => e.MacBilgisis3)
                .WithOptional(e => e.Hakem3)
                .HasForeignKey(e => e.DorduncuHakemId);

            modelBuilder.Entity<Klasman>()
                .HasMany(e => e.Hakems)
                .WithRequired(e => e.Klasman)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MacBilgisi>()
                .HasOptional(e => e.MacBilgisi1)
                .WithRequired(e => e.MacBilgisi2);

            modelBuilder.Entity<TakimKategori>()
                .HasMany(e => e.MacBilgisis)
                .WithRequired(e => e.TakimKategori)
                .HasForeignKey(e => e.KategoriId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Takimlar>()
                .HasMany(e => e.MacBilgisis)
                .WithRequired(e => e.Takimlar)
                .HasForeignKey(e => e.EvSahibiTakimId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Takimlar>()
                .HasMany(e => e.MacBilgisis1)
                .WithRequired(e => e.Takimlar1)
                .HasForeignKey(e => e.DeplasmanTakimId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VizeDurumu>()
                .HasMany(e => e.Gozlemcis)
                .WithRequired(e => e.VizeDurumu1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VizeDurumu>()
                .HasMany(e => e.Hakems)
                .WithRequired(e => e.VizeDurumu1)
                .WillCascadeOnDelete(false);
        }
    }
}
