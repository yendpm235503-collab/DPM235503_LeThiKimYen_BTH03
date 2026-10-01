namespace DPM235503_LeThiKimYen_Refactoring07_InlineTemp
{
    public class Order
    {
        public double BasePrice { get; set; } = 1500;
    }

    public class BeforeExample
    {
        public bool IsSpecialOrder(Order order)
        {
            double basePrice = order.BasePrice;
            return basePrice > 1000;
        }
    }
}