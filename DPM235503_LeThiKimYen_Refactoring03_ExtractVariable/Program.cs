using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring03_ExtractVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 03: EXTRACT VARIABLE ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Render Banner: {before.RenderBanner("MAC", "IE", 5)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Render Banner: {after.RenderBanner("MAC", "IE", 5)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            bool duocMienPhi = real.KiemTraKhuVucGiaoHangMienPhi("An Giang", 15000000, 20);
            Console.WriteLine($"[Nông Dược An Giang] Được Free Ship: {duocMienPhi}");

            Console.ReadKey();
        }
    }
}