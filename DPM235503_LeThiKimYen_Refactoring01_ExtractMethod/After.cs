using System;

namespace DPM235503_LeThiKimYen_Refactoring01_ExtractMethod
{
    public class AfterExample
    {
        public void PrintOwing(string name, double amount)
        {
            PrintBanner();
            PrintDetails(name, amount);
        }

        private void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");
        }

        private void PrintDetails(string name, double amount)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Amount: {amount}");
        }
    }
}