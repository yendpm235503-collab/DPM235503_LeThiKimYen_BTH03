namespace DPM235503_LeThiKimYen_Refactoring25_ParameterizeMethod
{
    public class AfterExample
    {
        private double _salary = 5000;

        public void Raise(double percentage) => _salary *= (1 + percentage);
        public double GetSalary() => _salary;
    }
}