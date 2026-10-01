namespace DPM235503_LeThiKimYen_Refactoring27_PreserveWholeObject
{
    public class TemperatureRange
    {
        public int Low { get; set; } = 10;
        public int High { get; set; } = 30;
    }

    public class BeforeExample
    {
        public bool IsWithinRange(int low, int high) => low >= 0 && high <= 40;
    }
}