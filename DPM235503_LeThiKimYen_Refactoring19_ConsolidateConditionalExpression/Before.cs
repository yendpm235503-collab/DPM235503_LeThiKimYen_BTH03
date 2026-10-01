namespace DPM235503_LeThiKimYen_Refactoring19_PreserveWholeObject
{
    public class TempRange
    {
        public int Low { get; set; } = 15;
        public int High { get; set; } = 30;
    }

    public class BeforeExample
    {
        public bool WithinRange(int low, int high)
        {
            return low >= 10 && high <= 35;
        }
    }
}