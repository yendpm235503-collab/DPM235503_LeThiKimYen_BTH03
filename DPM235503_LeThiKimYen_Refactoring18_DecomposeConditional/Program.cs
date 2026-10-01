using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring18_ReplaceParameterWithExplicitMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 18: REPLACE PARAMETER WITH EXPLICIT METHODS ===");

            BeforeExample before = new BeforeExample();
            before.SetValue("height", 100);
            Console.WriteLine($"Before Height: {before.Height}");

            AfterExample after = new AfterExample();
            after.SetHeight(100);
            Console.WriteLine($"After Height: {after.Height}");

            HopDongDaiLyAnGiang hd = new HopDongDaiLyAnGiang();
            hd.KichHoatHopDong();

            Console.ReadKey();
        }
    }
}