namespace DPM235503_LeThiKimYen_Refactoring11_MoveMethod
{
    public class AccountType
    {
        public bool IsPremium { get; set; }
    }

    public class BeforeExample
    {
        public AccountType Type { get; set; } = new AccountType();
        public int DaysOverdrawn { get; set; } = 10;

        // Hàm này sử dụng thuộc tính IsPremium của AccountType nhiều hơn bản thân lớp BeforeExample
        public double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0)
            {
                if (Type.IsPremium)
                {
                    result += 10;
                }
                else
                {
                    result += DaysOverdrawn * 1.75;
                }
            }
            return result;
        }
    }
}