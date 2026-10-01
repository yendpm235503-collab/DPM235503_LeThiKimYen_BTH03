namespace DPM235503_LeThiKimYen_Refactoring06_InlineMethod
{
    public class AfterExample
    {
        private int _numberOfLateDeliveries = 6;

        public int GetRating()
        {
            return _numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}