using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DEPTHCHK.Models;

namespace DEPTHCHK.Data
{
    public class depthchkDBContext : DbContext
    {
        public depthchkDBContext() : base("name=DepthChkDb")
        {
            // We’re using an existing DB. Don’t let EF try to create/modify it.
            Database.SetInitializer<depthchkDBContext>(null);
        }

        public depthchkDBContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<depthchkDBContext>(null);
        }

        public virtual DbSet<TblMobilTangki> MobilTangkis { get; set; }
        public virtual DbSet<TblDetailMT> DetailMTs { get; set; }
        public virtual DbSet<TblTujuan> Tujuans { get; set; }
        public virtual DbSet<TblUser> Users { get; set; }
        public virtual DbSet<TblPengiriman> Pengirimans { get; set; }
        public virtual DbSet<TblDetailPengiriman> DetailPengirimans { get; set; }
        public DbSet<TblTimeSettings> TimeSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<TblTimeSettings>()
                .ToTable("TblTimeSettings")
                .HasKey(t => t.Id);

            // TblMobilTangki
            modelBuilder.Entity<TblMobilTangki>()
                .Property(p => p.Capacity).HasPrecision(10, 2);

            modelBuilder.Entity<TblMobilTangki>()
                .HasMany(m => m.DetailMTs)
                .WithRequired(d => d.MobilTangki)
                .HasForeignKey(d => d.NoPlat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TblMobilTangki>()
                .HasMany(m => m.Pengiriman)
                .WithOptional(p => p.MobilTangki)
                .HasForeignKey(p => p.NoPlat)
                .WillCascadeOnDelete(false);

            // TblDetailMT
            modelBuilder.Entity<TblDetailMT>()
                .Property(p => p.Kalibrasi).HasPrecision(10, 2);

            // TblDetailPengiriman (composite key + precisions + FKs)
            modelBuilder.Entity<TblDetailPengiriman>()
                .HasKey(k => new { k.IDPengiriman, k.PartID });

            modelBuilder.Entity<TblDetailPengiriman>()
                .Property(p => p.DataBacaan).HasPrecision(10, 2);

            modelBuilder.Entity<TblDetailPengiriman>()
                .Property(p => p.DataKalibrasi).HasPrecision(10, 2);

            modelBuilder.Entity<TblDetailPengiriman>()
                .HasRequired(d => d.Pengiriman)
                .WithMany(p => p.DetailPengiriman)
                .HasForeignKey(d => d.IDPengiriman)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<TblDetailPengiriman>()
                .HasRequired(d => d.DetailMT)
                .WithMany(mt => mt.DetailPengiriman)
                .HasForeignKey(d => d.PartID)
                .WillCascadeOnDelete(false);


            base.OnModelCreating(modelBuilder);
        }
    }
}
