using System;

namespace DPM235503_LeThiKimYen_Refactoring09_SplitTemporaryVariable
{
    public class AfterExample
    {
        public void Calculate(double height, double width)
        {
            double perimeter = 2 * (height + width);
            Console.WriteLine($"Perimeter: {perimeter}");

            double area = height * width;
            Console.WriteLine($"Area: {area}");
        }
    }
}