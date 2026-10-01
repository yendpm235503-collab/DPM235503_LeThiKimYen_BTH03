namespace DPM235503_LeThiKimYen_Refactoring12_MoveField
{
    public class AccountType
    {
        public string TypeName { get; set; }
    }

    public class BeforeExample
    {
        public AccountType Type { get; set; }
        // Biến InterestRate nằm ở Account nhưng logic tính lãi suất lại thuộc về AccountType
        public double InterestRate { get; set; } = 0.05;

        public double CalculateInterest(double amount)
        {
            return amount * InterestRate;
        }
    }
}