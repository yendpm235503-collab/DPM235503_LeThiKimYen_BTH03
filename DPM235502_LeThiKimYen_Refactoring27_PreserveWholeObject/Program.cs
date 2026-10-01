using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring27_PreserveWholeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 27: PRESERVE WHOLE OBJECT ===");

            TemperatureRange range = new TemperatureRange();
            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before: {before.IsWithinRange(range.Low, range.High)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After: {after.IsWithinRange(range)}");

            ThongSoLuaGiong giong = new ThongSoLuaGiong();
            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            Console.WriteLine($"[Nông Dược An Giang] Lúa giống đạt chuẩn xuất kho: {real.KiemTraLuaGiongDatChuan(giong)}");

            Console.ReadKey();
        }
    }
}