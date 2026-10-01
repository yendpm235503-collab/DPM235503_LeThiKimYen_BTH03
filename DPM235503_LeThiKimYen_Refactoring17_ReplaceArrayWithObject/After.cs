namespace DPM235503_LeThiKimYen_Refactoring17_ParameterizeMethod
{
    public class AfterExample
    {
        public double Salary { get; set; } = 1000;

        // Gộp chung thành 1 hàm có tham số phần trăm
        public void Raise(double percentage)
        {
            Salary *= (1 + percentage);
        }
    }
}