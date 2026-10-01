namespace DPM235503_LeThiKimYen_Refactoring17_ParameterizeMethod
{
    public class BeforeExample
    {
        public double Salary { get; set; } = 1000;

        // Các hàm tăng lương bị lặp lại logic
        public void FivePercentRaise()
        {
            Salary *= 1.05;
        }

        public void TenPercentRaise()
        {
            Salary *= 1.10;
        }
    }
}