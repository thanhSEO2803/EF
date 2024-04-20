using System.ComponentModel.DataAnnotations;
using DefaultNamespace;

namespace CodeFirst.Models;

public class Khoa
{
    [Key]
    public int MaKhoa { get; set; }
    public string? TenKhoa { get; set; }
    public ICollection<SinhVien>? SinhViens { get; set; }
}