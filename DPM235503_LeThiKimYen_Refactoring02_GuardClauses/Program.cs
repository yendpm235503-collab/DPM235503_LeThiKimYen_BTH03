using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring02_GuardClauses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 02: GUARD CLAUSES ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Pay Amount: {before.GetPayAmount(false, false, true)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Pay Amount: {after.GetPayAmount(false, false, true)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            double chietKhau = real.TinhTienChietKhauDaiLy(false, false, true, 100000000);
            Console.WriteLine($"[Nông Dược An Giang] Chiết khấu Đại lý: {chietKhau:N0} VNĐ");

            Console.ReadKey();
        }
    }
}