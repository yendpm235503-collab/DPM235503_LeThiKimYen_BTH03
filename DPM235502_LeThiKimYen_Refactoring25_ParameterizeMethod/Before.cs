namespace DPM235503_LeThiKimYen_Refactoring25_ParameterizeMethod
{
    public class BeforeExample
    {
        private double _salary = 5000;

        public void FivePercentRaise() => _salary *= 1.05;
        public void TenPercentRaise() => _salary *= 1.10;
        public double GetSalary() => _salary;
    }
}