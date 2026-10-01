using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring01_ExtractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 01: EXTRACT METHOD ===");

            Console.WriteLine("\n[1. BEFORE]");
            BeforeExample before = new BeforeExample();
            before.PrintOwing("Nguyễn Văn A", 1500000);

            Console.WriteLine("\n[2. AFTER]");
            AfterExample after = new AfterExample();
            after.PrintOwing("Trần Thị B", 2500000);

            Console.WriteLine("\n[3. REAL - NÔNG DƯỢC AN GIANG]");
            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            real.XuLyHoaDonThuocNongNghiep("Đại Lý Long Xuyên", 12500000);

            Console.ReadKey();
        }
    }
}