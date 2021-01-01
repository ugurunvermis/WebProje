using Microsoft.EntityFrameworkCore;
using WebProje.Entity;

namespace WebProje.Context
{
    public class BarinakDbContext : DbContext
    {
        public BarinakDbContext(DbContextOptions<BarinakDbContext> options)
            : base(options)
        { }

        public DbSet<AsiTakvimi> AsiTakvimi { get; set; }
        public DbSet<BarinakBilgileri> BarinakBilgileri { get; set; }
        public DbSet<BeslenmeProgrami> BeslenmeProgrami { get; set; }
        public DbSet<CalismaSaatleri> CalismaSaatleri { get; set; }
        public DbSet<Cinsiyet> Cinsiyet { get; set; }
        public DbSet<HayvanCinsleri> HayvanCinsleri { get; set; }
        public DbSet<HayvanFotograflari> HayvanFotograflari { get; set; }
        public DbSet<HayvanTurleri> HayvanTurleri { get; set; }
        public DbSet<KayitliHayvanlar> KayitliHayvanlar { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<KullaniciRolu> KullaniciRolu { get; set; }
        public DbSet<SaglikDurumu> SaglikDurumu { get; set; }
        public DbSet<SahiplenebilirlikDurumu> SahiplenebilirlikDurumu { get; set; }
        public DbSet<SahiplenmeBasvuruDurumlari> SahiplenmeBasvuruDurumlari { get; set; }
        public DbSet<SahiplenmeTalepleri> SahiplenmeTalepleri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AsiTakvimi>().HasOne(a => a.hayvan).WithOne(h => h.asi_takvimi).HasForeignKey<KayitliHayvanlar>(h=>h.id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
