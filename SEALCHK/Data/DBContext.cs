using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SEALCHK.Model;
using System.Configuration;
using System.Data.SqlClient;

namespace SEALCHK.Data
{
    public class SealCheckContext : DbContext
    {

        public SealCheckContext() : base("name=SealCheckDb")
        {
            // We’re using an existing DB. Don’t let EF try to create/modify it.
            Database.SetInitializer<SealCheckContext>(null);
        }

        public SealCheckContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<SealCheckContext>(null);
        }



        public DbSet<TblMobilTangki> MobilTangki { get; set; }
        public DbSet<TblDetailMT> DetailMT { get; set; }
        public DbSet<TblUser> Users { get; set; }
        public DbSet<TblRegister> Registers { get; set; }
        public DbSet<TblDetailRegister> DetailRegisters { get; set; }
        public DbSet<TblTujuan> Tujuan { get; set; }
        public DbSet<TblTimeSettings> TimeSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Table and key mappings
            modelBuilder.Entity<TblMobilTangki>()
                .ToTable("TblMobilTangki")
                .HasKey(mt => mt.NoPlat);

            modelBuilder.Entity<TblDetailMT>()
                .ToTable("TblDetailMT")
                .HasKey(dm => dm.PartID);

            modelBuilder.Entity<TblUser>()
                .ToTable("TblUser")
                .HasKey(u => u.UserID);

            modelBuilder.Entity<TblRegister>()
                .ToTable("TblRegister")
                .HasKey(r => new { r.NoPlat, r.Tgl_Input });

            modelBuilder.Entity<TblDetailRegister>()
                .ToTable("TblDetailRegister")
                .HasKey(dr => new { dr.PartID, dr.NoPlat, dr.Tgl_Input });

            modelBuilder.Entity<TblTujuan>()
                .ToTable("TblTujuan")
                .HasKey(t => t.KodeTujuan);

            modelBuilder.Entity<TblTimeSettings>()
                .ToTable("TblTimeSettings")
                .HasKey(t => t.Id);

            // Relationships
            // MobilTangki 1–* Register (FK: NoPlat)
            modelBuilder.Entity<TblRegister>()
                .HasRequired(r => r.MobilTangki)
                .WithMany(mt => mt.Registers)
                .HasForeignKey(r => r.NoPlat)
                .WillCascadeOnDelete(false);

            // TblRegister 1–* TblDetailRegister (composite FK: NoPlat + Tgl_Input)
            modelBuilder.Entity<TblDetailRegister>()
                .HasRequired(dr => dr.Register)
                .WithMany(r => r.DetailRegisters)
                .HasForeignKey(dr => new { dr.NoPlat, dr.Tgl_Input })
                .WillCascadeOnDelete(false);

            // TblUser 1–* TblRegister (FK: UserINPUT)
            modelBuilder.Entity<TblRegister>()
                .HasRequired(r => r.User)
                .WithMany(u => u.Registers)
                .HasForeignKey(r => r.UserINPUT)
                .WillCascadeOnDelete(false);

            // TblDetailMT 1–* TblDetailRegister (FK: PartID)
            modelBuilder.Entity<TblDetailRegister>()
                .HasRequired(dr => dr.DetailMT)
                .WithMany(dm => dm.DetailRegisters)
                .HasForeignKey(dr => dr.PartID)
                .WillCascadeOnDelete(false);

            // Column specifics (e.g. decimal precision)
            modelBuilder.Entity<TblDetailMT>()
                .Property(d => d.Capacity)
                .HasPrecision(18, 0);

            // Composite Key Register
            modelBuilder.Entity<TblRegister>()
                .HasKey(r => new { r.NoPlat, r.Tgl_Input });

            modelBuilder.Entity<TblRegister>()
                .Property(r => r.UserOUT)
                .IsOptional()
                .HasMaxLength(50);  // adjust as needed


            base.OnModelCreating(modelBuilder);
        }
    }
}

