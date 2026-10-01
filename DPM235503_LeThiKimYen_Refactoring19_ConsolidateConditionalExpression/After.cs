namespace DPM235503_LeThiKimYen_Refactoring19_PreserveWholeObject
{
    public class AfterExample
    {
        // Truyền thẳng đối tượng TempRange
        public bool WithinRange(TempRange range)
        {
            return range.Low >= 10 && range.High <= 35;
        }
    }
}