using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring17_ParameterizeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 17: PARAMETERIZE METHOD ===");

            BeforeExample before = new BeforeExample();
            before.FivePercentRaise();
            Console.WriteLine($"Before Salary: {before.Salary}");

            AfterExample after = new AfterExample();
            after.Raise(0.05);
            Console.WriteLine($"After Salary: {after.Salary}");

            SanPhamAnGiang sp = new SanPhamAnGiang { TenThuoc = "Phân Bón NPK An Giang" };
            sp.DieuChinhGia(0.08); // Tăng giá 8%
            Console.WriteLine($"[Nông Dược An Giang] Giá mới {sp.TenThuoc}: {sp.GiaKhuyenNghi:N0} VNĐ");

            Console.ReadKey();
        }
    }
}