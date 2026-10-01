namespace DPM235503_LeThiKimYen_Refactoring11_MoveMethod
{
    public class AccountTypeAfter
    {
        public bool IsPremium { get; set; }

        // Di chuyển hàm tính phí về lớp sở hữu loại tài khoản
        public double OverdraftCharge(int daysOverdrawn)
        {
            if (IsPremium)
            {
                return 10;
            }
            return daysOverdrawn * 1.75;
        }
    }

    public class AfterExample
    {
        public AccountTypeAfter Type { get; set; } = new AccountTypeAfter();
        public int DaysOverdrawn { get; set; } = 10;

        public double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0)
            {
                result += Type.OverdraftCharge(DaysOverdrawn);
            }
            return result;
        }
    }
}