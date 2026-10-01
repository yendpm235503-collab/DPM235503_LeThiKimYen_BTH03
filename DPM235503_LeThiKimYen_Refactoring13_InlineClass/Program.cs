using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring13_InlineClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 13: INLINE CLASS ===");

            BeforeExample before = new BeforeExample { Name = "Cty An Giang" };
            before.Phone.Number = "02963852111";
            Console.WriteLine($"Before Phone: {before.Phone.Number}");

            AfterExample after = new AfterExample { Name = "Cty An Giang", PhoneNumber = "02963852111" };
            Console.WriteLine($"After Phone: {after.PhoneNumber}");

            DaiLyNongDuocAnGiang daily = new DaiLyNongDuocAnGiang
            {
                TenDaiLy = "Đại Lý VTNN Châu Thành",
                MaSoThue = "1600123456"
            };
            daily.InThongTinDaiLy();

            Console.ReadKey();
        }
    }
}