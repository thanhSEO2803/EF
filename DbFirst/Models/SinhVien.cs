using System;
using System.Collections.Generic;

namespace DbFirst;

public partial class SinhVien
{
    public int MaSinhVien { get; set; }

    public string? HoTen { get; set; }

    public int? Age { get; set; }

    public int? LopMaLop { get; set; }

    public int? KhoaMaKhoa { get; set; }

    public virtual Khoa? KhoaMaKhoaNavigation { get; set; }

    public virtual Lop? LopMaLopNavigation { get; set; }
}
