namespace DPM235503_LeThiKimYen_Refactoring30_ExtractInterface
{
    public interface IPrinter
    {
        void Print(string document);
    }

    public class PrinterAfter : IPrinter
    {
        public void Print(string document)
        {
            // In thông qua Interface
        }
    }
}