using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring19_PreserveWholeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 19: PRESERVE WHOLE OBJECT ===");

            TempRange range = new TempRange();
            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Within Range: {before.WithinRange(range.Low, range.High)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Within Range: {after.WithinRange(range)}");

            ThongSoMoiTruongKho kho = new ThongSoMoiTruongKho();
            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            Console.WriteLine($"[Nông Dược An Giang] Kho thuốc đạt chuẩn bảo quản: {real.KiemTraAnToanLuuKho(kho)}");

            Console.ReadKey();
        }
    }
}