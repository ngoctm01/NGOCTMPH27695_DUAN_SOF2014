using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1.DAL.DomainClass;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace _1.DAL.Context
{
    public partial class FpolyDBContext : DbContext
    {
        public FpolyDBContext()
        {
        }

        public FpolyDBContext(DbContextOptions<FpolyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietSp> ChiTietSp { get; set; }
        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<CuaHang> CuaHang { get; set; }
        public virtual DbSet<DongSp> DongSp { get; set; }
        public virtual DbSet<GioHang> GioHang { get; set; }
        public virtual DbSet<GioHangChiTiet> GioHangChiTiet { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<MauSac> MauSac { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<Nsx> Nsx { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-ON9R74U\\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041;Persist Security Info=True;User ID=ngoctmph27695;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietSp>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaNhap).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdDongSpNavigation)
                    .WithMany(p => p.ChiTietSp)
                    .HasForeignKey(d => d.IdDongSp)
                    .HasConstraintName("FK__ChiTietSP__IdDon__04E4BC85");

                entity.HasOne(d => d.IdMauSacNavigation)
                    .WithMany(p => p.ChiTietSp)
                    .HasForeignKey(d => d.IdMauSac)
                    .HasConstraintName("FK__ChiTietSP__IdMau__03F0984C");

                entity.HasOne(d => d.IdNsxNavigation)
                    .WithMany(p => p.ChiTietSp)
                    .HasForeignKey(d => d.IdNsx)
                    .HasConstraintName("FK__ChiTietSP__IdNsx__02FC7413");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.ChiTietSp)
                    .HasForeignKey(d => d.IdSp)
                    .HasConstraintName("FK__ChiTietSP__IdSP__02084FDA");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__ChucVu__3214CC9EE358B277")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);
            });

            modelBuilder.Entity<CuaHang>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__CuaHang__3214CC9E1C161A1E")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);
            });

            modelBuilder.Entity<DongSp>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__DongSP__3214CC9EA4B8FDF1")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__GioHang__3214CC9EDB233D4F")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TinhTrang).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.GioHang)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__GioHang__IdKH__00200768");
            });

            modelBuilder.Entity<GioHangChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.IdGioHang, e.IdChiTietSp })
                    .HasName("PK_GioHangCT");

                entity.Property(e => e.DonGia).HasDefaultValueSql("((0))");

                entity.Property(e => e.DonGiaKhiGiam).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.GioHangChiTiet)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_IdChiTietSP");

                entity.HasOne(d => d.IdGioHangNavigation)
                    .WithMany(p => p.GioHangChiTiet)
                    .HasForeignKey(d => d.IdGioHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_IdGioHang");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__HoaDon__3214CC9EBBA4B6C8")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TinhTrang).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__HoaDon__IdKH__7F2BE32F");

                entity.HasOne(d => d.IdNvNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.IdNv)
                    .HasConstraintName("FK__HoaDon__IdNV__01142BA1");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.IdHoaDon, e.IdChiTietSp })
                    .HasName("PK_HoaDonCT");

                entity.Property(e => e.DonGia).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.HoaDonChiTiet)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiet)
                    .HasForeignKey(d => d.IdHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__KhachHan__3214CC9E54A3FA66")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__MauSac__3214CC9EE8073796")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__NhanVien__3214CC9E73E677D0")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChNavigation)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.IdCh)
                    .HasConstraintName("FK__NhanVien__IdCH__7C4F7684");

                entity.HasOne(d => d.IdCvNavigation)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.IdCv)
                    .HasConstraintName("FK__NhanVien__IdCV__7D439ABD");

                entity.HasOne(d => d.IdGuiBcNavigation)
                    .WithMany(p => p.InverseIdGuiBcNavigation)
                    .HasForeignKey(d => d.IdGuiBc)
                    .HasConstraintName("FK__NhanVien__IdGuiB__7E37BEF6");
            });

            modelBuilder.Entity<Nsx>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__NSX__3214CC9E1BC487D3")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UQ__SanPham__3214CC9E9A0F3CDD")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
