using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring22_AddParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 22: ADD PARAMETER ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before: {before.CalculatePrice(100000)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After: {after.CalculatePrice(100000, 0.1)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            Console.WriteLine($"[Nông Dược An Giang] Giá sau giảm: {real.TinhGiaBanThuoc(150000, 0.05):N0} VNĐ");

            Console.ReadKey();
        }
    }
}