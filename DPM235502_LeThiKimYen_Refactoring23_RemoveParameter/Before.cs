namespace DPM235503_LeThiKimYen_Refactoring23_RemoveParameter
{
    public class BeforeExample
    {
        // Tham số unusedParam không còn được dùng trong logic
        public double GetDiscount(double price, bool unusedParam)
        {
            return price * 0.1;
        }
    }
}