using System.ComponentModel.DataAnnotations;
using CodeFirst.Models;

namespace DefaultNamespace;

public class SinhVien
{
    [Key]
    public int MaSinhVien { get; set; }
    public string? HoTen { get; set; }
    public int? Age { get; set; }
    public int? LopMaLop { get; set; }
    public Lop Lop { get; set; }
    public int? KhoaMaKhoa { get; set; }
    public Khoa Khoa { get; set; }
}