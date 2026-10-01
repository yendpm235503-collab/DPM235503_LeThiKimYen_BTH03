namespace DPM235503_LeThiKimYen_Refactoring03_ExtractVariable
{
    public class AfterExample
    {
        public double RenderBanner(string platform, string browser, int resize)
        {
            bool isMacOs = platform.ToUpper().IndexOf("MAC") > -1;
            bool isIE = browser.ToUpper().IndexOf("IE") > -1;
            bool isResized = resize > 0;

            if (isMacOs && isIE && isResized)
            {
                return 1.5;
            }
            return 1.0;
        }
    }
}