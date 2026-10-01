using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring04_ExtractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 04: EXTRACT CLASS ===");

            PersonBefore b = new PersonBefore { Name = "John", OfficeAreaCode = "0296", OfficeNumber = "3852111" };
            Console.WriteLine($"Before Phone: {b.GetTelephoneNumber()}");

            PersonAfter a = new PersonAfter { Name = "John" };
            a.Phone.AreaCode = "0296";
            a.Phone.Number = "3852111";
            Console.WriteLine($"After Phone: {a.Phone.GetFullNumber()}");

            KhoNongDuocAnGiang kho = new KhoNongDuocAnGiang
            {
                MaKho = "KHO-LX-01",
                TenKho = "Kho Vật Tư Long Xuyên"
            };
            kho.DiaChi.SoNhaTenDuong = "123 Trần Hưng Đạo";
            kho.DiaChi.PhuongXa = "Mỹ Bình";
            kho.DiaChi.QuanHuyen = "TP. Long Xuyên";
            kho.DiaChi.TinhThanh = "An Giang";
            kho.HienThiThongTin();

            Console.ReadKey();
        }
    }
}