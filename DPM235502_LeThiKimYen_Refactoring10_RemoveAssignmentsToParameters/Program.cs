using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring10_RemoveAssignmentsToParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 10: REMOVE ASSIGNMENTS TO PARAMETERS ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Discount: {before.Discount(60, 150, 12)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Discount: {after.Discount(60, 150, 12)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            double giaBan = real.TinhGiaThucTeThuocTruSau(200000, 60, true);
            Console.WriteLine($"[Nông Dược An Giang] Giá thực tế/bao: {giaBan:N0} VNĐ");

            Console.ReadKey();
        }
    }
}