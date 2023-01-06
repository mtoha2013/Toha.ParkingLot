using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WinFormsApp.Common;

#nullable disable

namespace WinFormsApp.Models
{
    public partial class DbTohaNTTContext : DbContext
    {
        public DbTohaNTTContext()
        {
        }

        public DbTohaNTTContext(DbContextOptions<DbTohaNTTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ParkingLot> ParkingLots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Data Source=DESKTOP-K2Q2VHA\\SQL2012;Initial Catalog=DbTohaNTT;Persist Security Info=True;User Id=sa;Password=Adm1n2022;");
                optionsBuilder.UseSqlServer(CommonConstant.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ParkingLot>(entity =>
            {
                entity.HasKey(e => e.Slot);

                entity.ToTable("ParkingLot");

                entity.Property(e => e.Slot).ValueGeneratedNever();

                entity.Property(e => e.CheckInTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MotorType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlatNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationNoColour)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
