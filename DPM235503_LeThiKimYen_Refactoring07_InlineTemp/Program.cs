using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring07_InlineTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 07: INLINE TEMP ===");

            Order order = new Order();
            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Is Special: {before.IsSpecialOrder(order)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Is Special: {after.IsSpecialOrder(order)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            Console.WriteLine($"[Nông Dược An Giang] Đơn 60 triệu được KM: {real.LaDonHangKhuyenMaiAnGiang(60000000)}");

            Console.ReadKey();
        }
    }
}