namespace DPM235503_LeThiKimYen_Refactoring04_ExtractClass
{
    public class TelephoneNumber
    {
        public string AreaCode { get; set; }
        public string Number { get; set; }

        public string GetFullNumber() => $"({AreaCode}) {Number}";
    }

    public class PersonAfter
    {
        public string Name { get; set; }
        public TelephoneNumber Phone { get; set; } = new TelephoneNumber();
    }
}