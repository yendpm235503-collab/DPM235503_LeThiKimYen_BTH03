namespace DPM235503_LeThiKimYen_Refactoring20_ReplaceParameterWithMethodCall
{
    public class AfterExample
    {
        // Bỏ tham số discountLevel, tự gọi hàm GetDiscountLevel() bên trong
        public double CalculateFinalPrice(double basePrice)
        {
            int discountLevel = GetDiscountLevel();
            if (discountLevel == 2) return basePrice * 0.8;
            return basePrice * 0.9;
        }

        public int GetDiscountLevel() => 2;
    }
}