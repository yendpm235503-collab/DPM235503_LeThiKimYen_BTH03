using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring06_InlineMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 06: INLINE METHOD ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Rating: {before.GetRating()}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Rating: {after.GetRating()}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            bool cầnNhập = real.KiemTraTonKhoCanCanhBao(5);
            Console.WriteLine($"[Nông Dược An Giang] Cảnh báo tồn kho thấp (5 chai): {cầnNhập}");

            Console.ReadKey();
        }
    }
}