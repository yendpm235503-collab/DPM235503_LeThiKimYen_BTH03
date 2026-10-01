namespace DPM235503_LeThiKimYen_Refactoring27_PreserveWholeObject
{
    public class AfterExample
    {
        public bool IsWithinRange(TemperatureRange range)
        {
            return range.Low >= 0 && range.High <= 40;
        }
    }
}