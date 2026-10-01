using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring28_PullUpMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 28: PULL UP METHOD ===");

            Car car = new Car();
            Console.WriteLine($"Before Car Brand: {car.GetBrand()}");

            CarAfter carAfter = new CarAfter();
            Console.WriteLine($"After Car Brand: {carAfter.GetBrand()}");

            ThuocTruSauAnGiang thuoc = new ThuocTruSauAnGiang();
            Console.WriteLine($"[Nông Dược An Giang] Xuất xứ: {thuoc.GetXuatXu()}");

            Console.ReadKey();
        }
    }
}