using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring23_RemoveParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 23: REMOVE PARAMETER ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before: {before.GetDiscount(500000, true)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After: {after.GetDiscount(500000)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            Console.WriteLine($"[Nông Dược An Giang] Chiết khấu: {real.TinhChietKhauThuoc(10000000):N0} VNĐ");

            Console.ReadKey();
        }
    }
}