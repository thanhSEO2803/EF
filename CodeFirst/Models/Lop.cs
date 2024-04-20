using System.ComponentModel.DataAnnotations;
using DefaultNamespace;

namespace CodeFirst.Models;

public class Lop
{
    [Key]
    public int MaLop { get; set; }
    public string? TenLop { get; set; }
    public ICollection<SinhVien>? SinhViens { get; set; }
}