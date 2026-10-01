using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring20_ReplaceParameterWithMethodCall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 20: REPLACE PARAMETER WITH METHOD CALL ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Final Price: {before.CalculateFinalPrice(1000, before.GetDiscountLevel())}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Final Price: {after.CalculateFinalPrice(1000)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            double tongTien = real.TinhTongThanhToanSauThue(50000000);
            Console.WriteLine($"[Nông Dược An Giang] Tổng hóa đơn có VAT: {tongTien:N0} VNĐ");

            Console.ReadKey();
        }
    }
}