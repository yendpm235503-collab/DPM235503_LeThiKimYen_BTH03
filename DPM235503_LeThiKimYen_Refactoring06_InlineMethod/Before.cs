namespace DPM235503_LeThiKimYen_Refactoring06_InlineMethod
{
    public class BeforeExample
    {
        private int _numberOfLateDeliveries = 6;

        public int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }

        private bool MoreThanFiveLateDeliveries()
        {
            return _numberOfLateDeliveries > 5;
        }
    }
}