using System;

namespace DPM235503_LeThiKimYen_Refactoring01_ExtractMethod
{
    public class BeforeExample
    {
        public void PrintOwing(string name, double amount)
        {
            // In banner
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");

            // In chi tiết
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Amount: {amount}");
        }
    }
}