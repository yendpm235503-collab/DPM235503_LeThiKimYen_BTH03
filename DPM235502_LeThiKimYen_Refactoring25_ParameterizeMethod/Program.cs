using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring25_ParameterizeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 25: PARAMETERIZE METHOD ===");

            BeforeExample before = new BeforeExample();
            before.FivePercentRaise();
            Console.WriteLine($"Before Salary: {before.GetSalary()}");

            AfterExample after = new AfterExample();
            after.Raise(0.05);
            Console.WriteLine($"After Salary: {after.GetSalary()}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            real.TangGiaNongDuoc(0.07);
            Console.WriteLine($"[Nông Dược An Giang] Giá thuốc sau tăng 7%: {real.GetGiaThuoc():N0} VNĐ");

            Console.ReadKey();
        }
    }
}