using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring14_HideDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 14: HIDE DELEGATE ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Manager: {before.Department.Manager}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Manager: {after.GetManager()}");

            DaiLyNongDuoc daily = new DaiLyNongDuoc { TenDaiLy = "Đại Lý Long Xuyên" };
            Console.WriteLine($"[Nông Dược An Giang] Nhân viên phụ trách {daily.TenDaiLy}: {daily.GetNhanVienPhuTrach()}");

            Console.ReadKey();
        }
    }
}