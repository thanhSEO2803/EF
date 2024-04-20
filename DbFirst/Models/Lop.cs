using System;
using System.Collections.Generic;

namespace DbFirst;

public partial class Lop
{
    public int MaLop { get; set; }

    public string? TenLop { get; set; }

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
