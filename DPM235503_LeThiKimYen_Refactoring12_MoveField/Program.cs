using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring12_MoveField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 12: MOVE FIELD ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Interest: {before.CalculateInterest(10000)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Interest: {after.CalculateInterest(10000)}");

            SanPhamNongDuoc sp = new SanPhamNongDuoc
            {
                TenThuoc = "Thuốc Trừ Sâu An Giang 250ml",
                DonGia = 150000
            };
            Console.WriteLine($"[Nông Dược An Giang] Giá sau chiết khấu nhóm hàng: {sp.TinhGiaSauChietKhau():N0} VNĐ");

            Console.ReadKey();
        }
    }
}