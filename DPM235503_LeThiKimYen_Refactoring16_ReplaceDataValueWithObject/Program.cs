using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring16_ExtractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 16: EXTRACT INTERFACE ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Charge: {before.Charge(new Employee(), 10)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Charge: {after.Charge(new EmployeeAfter(), 10)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            double phiFlycam = real.TinhTongThanhToan(new PhunThuocFlycamAnGiang(), 50);
            Console.WriteLine($"[Nông Dược An Giang] Dịch vụ Flycam 50 công: {phiFlycam:N0} VNĐ");

            Console.ReadKey();
        }
    }
}