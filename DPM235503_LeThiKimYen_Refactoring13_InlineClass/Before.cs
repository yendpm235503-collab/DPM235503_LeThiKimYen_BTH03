namespace DPM235503_LeThiKimYen_Refactoring13_InlineClass
{
    // Class qua don gian, chi chua 1 thuoc tinh duy nhat
    public class TelephoneNumber
    {
        public string Number { get; set; }
    }

    public class BeforeExample
    {
        public string Name { get; set; }
        public TelephoneNumber Phone { get; set; } = new TelephoneNumber();
    }
}