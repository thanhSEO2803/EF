using Microsoft.EntityFrameworkCore;

namespace CodeFirst;

public class ConsoleResult(ApplicationDbContext dbContext)
{
    private readonly ApplicationDbContext _dbContext = dbContext;
    
    public void Show()
    {
        var result = _dbContext.SinhViens.Where(sv => sv.KhoaMaKhoa == 1 && (sv.Age >= 18 && sv.Age <= 20))
            .Include(sinhVien => sinhVien.Lop)
            .Include(sinhVien => sinhVien.Khoa).ToList();
        result.ForEach(sv => Console.WriteLine($"sinh vien name: {sv.HoTen} - age: {sv.Age} - lop: {sv.Lop.TenLop} - khoa: {sv.Khoa.TenKhoa}"));
    }
}