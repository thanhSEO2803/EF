using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DbFirst;

public partial class DatabaseFirstContext : DbContext
{
    public DatabaseFirstContext()
    {
    }

    public DatabaseFirstContext(DbContextOptions<DatabaseFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-F79T3I7P\\SQLEXPRESS;Initial Catalog=DatabaseFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.MaKhoa).HasName("PK__Khoa__653904056B1C219D");

            entity.ToTable("Khoa");

            entity.Property(e => e.MaKhoa).ValueGeneratedNever();
        });

        modelBuilder.Entity<Lop>(entity =>
        {
            entity.HasKey(e => e.MaLop).HasName("PK__Lop__3B98D273E9DD7093");

            entity.ToTable("Lop");

            entity.Property(e => e.MaLop).ValueGeneratedNever();
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSinhVien).HasName("PK__SinhVien__939AE7758DBB4251");

            entity.ToTable("SinhVien");

            entity.Property(e => e.MaSinhVien).ValueGeneratedNever();

            entity.HasOne(d => d.KhoaMaKhoaNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.KhoaMaKhoa)
                .HasConstraintName("FK__SinhVien__KhoaMa__4E88ABD4");

            entity.HasOne(d => d.LopMaLopNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.LopMaLop)
                .HasConstraintName("FK__SinhVien__LopMaL__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
