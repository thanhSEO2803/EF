using Microsoft.EntityFrameworkCore;

namespace DbFirst;

public static class ConsoleResult
{
    public static void Show(this WebApplication webApplication)
    {
        using (var scope = webApplication.Services.CreateScope())
        {
            var applicationDbContext = scope.ServiceProvider.GetRequiredService<DatabaseFirstContext>();
            
            var result = applicationDbContext.SinhViens.Where(sv => sv.KhoaMaKhoa == 1 && (sv.Age >= 18 && sv.Age <= 20))
                .Include(sinhVien => sinhVien.LopMaLopNavigation)
                .Include(sinhVien => sinhVien.KhoaMaKhoaNavigation).ToList();
            result.ForEach(sv => Console.WriteLine($"sinh vien name: {sv.HoTen} - age: {sv.Age} - lop: {sv.LopMaLopNavigation?.TenLop} - khoa: {sv.KhoaMaKhoaNavigation?.TenKhoa}"));
        }
    }
}