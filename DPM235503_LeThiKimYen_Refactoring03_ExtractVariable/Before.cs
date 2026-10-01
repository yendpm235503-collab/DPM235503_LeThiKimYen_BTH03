namespace DPM235503_LeThiKimYen_Refactoring03_ExtractVariable
{
    public class BeforeExample
    {
        public double RenderBanner(string platform, string browser, int resize)
        {
            if ((platform.ToUpper().IndexOf("MAC") > -1) &&
                (browser.ToUpper().IndexOf("IE") > -1) &&
                resize > 0)
            {
                return 1.5;
            }
            return 1.0;
        }
    }
}