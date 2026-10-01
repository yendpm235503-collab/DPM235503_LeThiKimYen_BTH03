namespace DPM235503_LeThiKimYen_Refactoring24_SeparateQueryFromModifier
{
    public class AfterExample
    {
        private int _stock = 100;

        // Tách riêng hàm Query (Lấy dữ liệu)
        public int GetStock() => _stock;

        // Tách riêng hàm Modifier (Thay đổi dữ liệu)
        public void ReduceStock(int amount)
        {
            _stock -= amount;
        }
    }
}