using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RestoSMK.Models;

namespace RestoSMK.Data;

public partial class DataConnection : DbContext
{
    public DataConnection()
    {
    }

    public DataConnection(DbContextOptions<DataConnection> options)
        : base(options)
    {
    }

    public virtual DbSet<DetailTransaksi> DetailTransaksis { get; set; }

    public virtual DbSet<Meja> Mejas { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Pembayaran> Pembayarans { get; set; }

    public virtual DbSet<Transaksi> Transaksis { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=EsemkaResto;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DetailTransaksi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DetailTr__3213E83FEA5C085A");

            entity.ToTable("DetailTransaksi");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.Harga)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("harga");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.TransaksiId).HasColumnName("transaksi_id");

            entity.HasOne(d => d.Menu).WithMany(p => p.DetailTransaksis)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailTransaksi_Menu");

            entity.HasOne(d => d.Transaksi).WithMany(p => p.DetailTransaksis)
                .HasForeignKey(d => d.TransaksiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailTransaksi_Transaksi");
        });

        modelBuilder.Entity<Meja>(entity =>
        {
            entity.HasKey(e => e.MejaId).HasName("PK__Meja__1FECF34AF62FB29C");

            entity.ToTable("Meja");

            entity.HasIndex(e => e.NoMeja, "UQ__Meja__52053DE6D4715F71").IsUnique();

            entity.Property(e => e.MejaId).HasColumnName("meja_id");
            entity.Property(e => e.CreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.Kapasitas)
                .HasDefaultValue(2)
                .HasColumnName("kapasitas");
            entity.Property(e => e.NoMeja).HasColumnName("no_meja");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PK__Menu__4CA0FADC0CEEF72C");

            entity.ToTable("Menu");

            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.CreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.Foto).HasColumnName("foto");
            entity.Property(e => e.Harga)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("harga");
            entity.Property(e => e.NamaMenu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nama_menu");
            entity.Property(e => e.Stock)
                .HasDefaultValue(0)
                .HasColumnName("stock");
        });

        modelBuilder.Entity<Pembayaran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pembayar__3213E83FD9F71E96");

            entity.ToTable("Pembayaran");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.ExternalId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("external_id");
            entity.Property(e => e.JeniPembayaran)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("jeni_pembayaran");
            entity.Property(e => e.MetodeBayar)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("metode_bayar");
            entity.Property(e => e.Nominal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("nominal");
            entity.Property(e => e.StatusBayar)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status_bayar");
            entity.Property(e => e.TransaksiId).HasColumnName("transaksi_id");

            entity.HasOne(d => d.Transaksi).WithMany(p => p.Pembayarans)
                .HasForeignKey(d => d.TransaksiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pembayaran_Transaksi");
        });

        modelBuilder.Entity<Transaksi>(entity =>
        {
            entity.HasKey(e => e.TransaksiId).HasName("PK__Transaks__6E0C9486A42F3127");

            entity.ToTable("Transaksi");

            entity.HasIndex(e => e.KodeBooking, "UQ__Transaks__D4DD7E388BA6AC02").IsUnique();

            entity.Property(e => e.TransaksiId).HasColumnName("transaksi_id");
            entity.Property(e => e.CreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.KodeBooking)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kode_booking");
            entity.Property(e => e.MejaId).HasColumnName("meja_id");
            entity.Property(e => e.PelangganId).HasColumnName("pelanggan_id");
            entity.Property(e => e.StatusTransaksi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status_transaksi");
            entity.Property(e => e.TotalTagihan)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total_tagihan");

            entity.HasOne(d => d.Meja).WithMany(p => p.Transaksis)
                .HasForeignKey(d => d.MejaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaksi_Meja");

            entity.HasOne(d => d.Pelanggan).WithMany(p => p.Transaksis)
                .HasForeignKey(d => d.PelangganId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tranksasi_Users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__B9BE370F0372A72C");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Alamat)
                .HasColumnType("text")
                .HasColumnName("alamat");
            entity.Property(e => e.CreateAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("create_at");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nama");
            entity.Property(e => e.NoHp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("no_hp");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
