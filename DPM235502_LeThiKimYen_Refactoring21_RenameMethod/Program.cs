using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring21_RenameMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 21: RENAME METHOD ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before: {before.GetInv(10, 50000)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After: {after.CalculateInvoiceTotal(10, 50000)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            Console.WriteLine($"[Nông Dược An Giang] Doanh thu: {real.TinhTongDoanhThuDaiLy(20, 250000):N0} VNĐ");

            Console.ReadKey();
        }
    }
}