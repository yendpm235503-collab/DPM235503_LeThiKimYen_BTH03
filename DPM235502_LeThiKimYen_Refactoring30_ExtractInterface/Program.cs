using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring30_ExtractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 30: EXTRACT INTERFACE ===");

            IPrinter printer = new PrinterAfter();
            printer.Print("Test document");
            Console.WriteLine("After Interface: Print successfully.");

            IThanhToanNongDuoc thanhToan = new ThanhToanChuyenKhoanAnGiang();
            thanhToan.ThanhToan(15000000);

            Console.ReadKey();
        }
    }
}