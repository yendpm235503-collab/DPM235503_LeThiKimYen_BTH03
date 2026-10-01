using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring05_ReplaceConditionalWithPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 05: REPLACE CONDITIONAL WITH POLYMORPHISM ===");

            EmployeeBefore eb = new EmployeeBefore { Type = 0 };
            Console.WriteLine($"Before Bonus Manager: {eb.GetBonus(10000000):N0} VNĐ");

            EmployeeAfter ea = new Manager();
            Console.WriteLine($"After Bonus Manager: {ea.GetBonus(10000000):N0} VNĐ");

            SanPhamNongDuoc sp = new ThuocTruSau { TenSanPham = "Thuốc Diệt Cỏ An Giang", GiaNhap = 100000 };
            Console.WriteLine($"[Nông Dược An Giang] Giá bán lẻ {sp.TenSanPham}: {sp.TinhGiaBan():N0} VNĐ");

            Console.ReadKey();
        }
    }
}