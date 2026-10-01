using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring29_PushDownMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 29: PUSH DOWN METHOD ===");

            Dog dogBefore = new Dog();
            Console.WriteLine($"Before Dog Bark: {dogBefore.Bark()}");

            DogAfter dogAfter = new DogAfter();
            Console.WriteLine($"After Dog Bark: {dogAfter.Bark()}");

            FlycamPhunThuoc flycam = new FlycamPhunThuoc();
            Console.WriteLine($"[Nông Dược An Giang] {flycam.BayPhunThuocTuDong()}");

            Console.ReadKey();
        }
    }
}