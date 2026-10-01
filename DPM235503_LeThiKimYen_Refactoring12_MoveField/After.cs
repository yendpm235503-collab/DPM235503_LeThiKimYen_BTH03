namespace DPM235503_LeThiKimYen_Refactoring12_MoveField
{
    public class AccountTypeAfter
    {
        public string TypeName { get; set; }
        // Di chuyển thuộc tính InterestRate sang đúng lớp AccountTypeAfter
        public double InterestRate { get; set; } = 0.05;
    }

    public class AfterExample
    {
        public AccountTypeAfter Type { get; set; } = new AccountTypeAfter();

        public double CalculateInterest(double amount)
        {
            return amount * Type.InterestRate;
        }
    }
}