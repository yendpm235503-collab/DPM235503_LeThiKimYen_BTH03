using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring15_EncapsulateField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 15: ENCAPSULATE FIELD ===");

            BeforeExample before = new BeforeExample();
            before.Name = "Sản phẩm A";
            Console.WriteLine($"Before Field: {before.Name}");

            AfterExample after = new AfterExample();
            after.Name = "Sản phẩm B";
            Console.WriteLine($"After Field: {after.Name}");

            DaiLyChinhThucAnGiang daily = new DaiLyChinhThucAnGiang();
            daily.DoanhSoNam = -5000000; // Thử gán giá trị lỗi
            daily.DoanhSoNam = 120000000;
            Console.WriteLine($"[Nông Dược An Giang] Doanh số hợp lệ: {daily.DoanhSoNam:N0} VNĐ");

            Console.ReadKey();
        }
    }
}