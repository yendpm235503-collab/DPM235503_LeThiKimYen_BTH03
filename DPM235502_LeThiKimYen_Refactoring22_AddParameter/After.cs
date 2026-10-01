namespace DPM235503_LeThiKimYen_Refactoring22_AddParameter
{
    public class AfterExample
    {
        // Thêm tham số taxRate để tính thêm thuế
        public double CalculatePrice(double basePrice, double taxRate)
        {
            return basePrice * (1 + taxRate);
        }
    }
}