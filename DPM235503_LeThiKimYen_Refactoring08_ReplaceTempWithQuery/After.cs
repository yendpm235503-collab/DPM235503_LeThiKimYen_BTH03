namespace DPM235503_LeThiKimYen_Refactoring08_ReplaceTempWithQuery
{
    public class AfterExample
    {
        private int _quantity = 10;
        private double _itemPrice = 50;

        public double CalculateTotal()
        {
            if (GetBasePrice() > 1000)
                return GetBasePrice() * 0.95;
            else
                return GetBasePrice() * 0.98;
        }

        private double GetBasePrice() => _quantity * _itemPrice;
    }
}