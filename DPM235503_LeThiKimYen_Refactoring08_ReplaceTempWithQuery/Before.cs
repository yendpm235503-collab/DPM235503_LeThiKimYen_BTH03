namespace DPM235503_LeThiKimYen_Refactoring08_ReplaceTempWithQuery
{
    public class BeforeExample
    {
        private int _quantity = 10;
        private double _itemPrice = 50;

        public double CalculateTotal()
        {
            double basePrice = _quantity * _itemPrice;
            if (basePrice > 1000)
                return basePrice * 0.95;
            else
                return basePrice * 0.98;
        }
    }
}