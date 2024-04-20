using CodeFirst.Models;
using DefaultNamespace;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<SinhVien> SinhViens { get; set; }
    public DbSet<Lop> Lops { get; set; }
    public DbSet<Khoa> Khoas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Khoa>().HasData(
            new Khoa { MaKhoa = 1, TenKhoa = "CNTT" },
            new Khoa { MaKhoa = 2, TenKhoa = "DT" },
            new Khoa { MaKhoa = 3, TenKhoa = "CK" }
        );

        modelBuilder.Entity<Lop>().HasData(
            new Lop { MaLop = 1, TenLop = "21T3" },
            new Lop { MaLop = 2, TenLop = "22T3" },
            new Lop { MaLop = 3, TenLop = "22DT3" },
            new Lop { MaLop = 4, TenLop = "23CK1" }
        );

        modelBuilder.Entity<SinhVien>().HasData(
            new SinhVien { MaSinhVien = 1, HoTen = "Nguyen Van A", Age = 20, KhoaMaKhoa = 1, LopMaLop = 1},
            new SinhVien { MaSinhVien = 2, HoTen = "Nguyen Van E", Age = 19, KhoaMaKhoa = 1, LopMaLop = 2 },
            new SinhVien { MaSinhVien = 3, HoTen = "Nguyen Van C", Age = 22, KhoaMaKhoa = 1, LopMaLop = 1 },
            new SinhVien { MaSinhVien = 4, HoTen = "Tran Van B", Age = 21, KhoaMaKhoa = 2, LopMaLop = 2 },
            new SinhVien { MaSinhVien = 5, HoTen = "Tran Van D", Age = 21, KhoaMaKhoa = 2, LopMaLop = 2 }
        );
    }
}