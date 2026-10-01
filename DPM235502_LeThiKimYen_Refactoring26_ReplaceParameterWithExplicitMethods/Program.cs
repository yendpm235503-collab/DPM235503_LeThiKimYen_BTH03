using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring26_ReplaceParameterWithExplicitMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 26: REPLACE PARAMETER WITH EXPLICIT METHODS ===");

            BeforeExample before = new BeforeExample();
            before.SetState(1);
            Console.WriteLine($"Before State: {before.IsActive}");

            AfterExample after = new AfterExample();
            after.Activate();
            Console.WriteLine($"After State: {after.IsActive}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            real.BieuMoKhoLanh();

            Console.ReadKey();
        }
    }
}