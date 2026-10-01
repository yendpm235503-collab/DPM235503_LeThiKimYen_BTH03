using System;

namespace DPM235503_LeThiKimYen_Refactoring24_SeparateQueryFromModifier
{
    public class BeforeExample
    {
        private int _stock = 100;

        // Vừa kiểm tra tồn kho vừa thực hiện trừ tồn kho (Nguy hiểm)
        public int CheckAndReduceStock(int amount)
        {
            _stock -= amount;
            return _stock;
        }
    }
}