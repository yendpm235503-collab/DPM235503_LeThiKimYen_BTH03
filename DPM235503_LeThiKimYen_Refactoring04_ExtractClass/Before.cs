namespace DPM235503_LeThiKimYen_Refactoring04_ExtractClass
{
    public class PersonBefore
    {
        public string Name { get; set; }
        public string OfficeAreaCode { get; set; }
        public string OfficeNumber { get; set; }

        public string GetTelephoneNumber()
        {
            return $"({OfficeAreaCode}) {OfficeNumber}";
        }
    }
}