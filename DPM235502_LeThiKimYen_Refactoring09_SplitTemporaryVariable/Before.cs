using System;

namespace DPM235503_LeThiKimYen_Refactoring09_SplitTemporaryVariable
{
    public class BeforeExample
    {
        public void Calculate(double height, double width)
        {
            double temp = 2 * (height + width); // Dùng temp cho chu vi
            Console.WriteLine($"Perimeter: {temp}");

            temp = height * width; // Dùng lại temp cho diện tích
            Console.WriteLine($"Area: {temp}");
        }
    }
}