using System;
using System.Collections.Generic;

namespace DbFirst;

public partial class Khoa
{
    public int MaKhoa { get; set; }

    public string? TenKhoa { get; set; }

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
