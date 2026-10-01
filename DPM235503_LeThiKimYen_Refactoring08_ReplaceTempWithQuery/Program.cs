using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring08_ReplaceTempWithQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 08: REPLACE TEMP WITH QUERY ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Total: {before.CalculateTotal()}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Total: {after.CalculateTotal()}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            Console.WriteLine($"[Nông Dược An Giang] Tổng tiền xuất kho: {real.TinhTongTienXuatKho():N0} VNĐ");

            Console.ReadKey();
        }
    }
}