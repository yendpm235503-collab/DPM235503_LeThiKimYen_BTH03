namespace DPM235503_LeThiKimYen_Refactoring20_ReplaceParameterWithMethodCall
{
    public class BeforeExample
    {
        public double CalculateFinalPrice(double basePrice, int discountLevel)
        {
            if (discountLevel == 2) return basePrice * 0.8;
            return basePrice * 0.9;
        }

        public int GetDiscountLevel() => 2;
    }
}