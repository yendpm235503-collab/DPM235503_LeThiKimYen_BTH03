using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring24_SeparateQueryFromModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 24: SEPARATE QUERY FROM MODIFIER ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Stock After Reduction: {before.CheckAndReduceStock(10)}");

            AfterExample after = new AfterExample();
            after.ReduceStock(10);
            Console.WriteLine($"After Current Stock: {after.GetStock()}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            real.XuatKhoPhanBon(15);
            Console.WriteLine($"[Nông Dược An Giang] Tồn kho phân bón còn lại: {real.GetSoThungTonKho()} thùng");

            Console.ReadKey();
        }
    }
}