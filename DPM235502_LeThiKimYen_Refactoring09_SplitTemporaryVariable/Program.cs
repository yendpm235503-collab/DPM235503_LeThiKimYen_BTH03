using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring09_SplitTemporaryVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 09: SPLIT TEMPORARY VARIABLE ===");

            Console.WriteLine("\n[1. BEFORE]");
            BeforeExample before = new BeforeExample();
            before.Calculate(5, 10);

            Console.WriteLine("\n[2. AFTER]");
            AfterExample after = new AfterExample();
            after.Calculate(5, 10);

            Console.WriteLine("\n[3. REAL - NÔNG DƯỢC AN GIANG]");
            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            real.TinhThuThapChiPhiPhanBon(10000000, 500000);

            Console.ReadKey();
        }
    }
}