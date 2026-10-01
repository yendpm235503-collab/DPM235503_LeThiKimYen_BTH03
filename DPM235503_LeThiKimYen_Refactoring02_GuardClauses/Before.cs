namespace DPM235503_LeThiKimYen_Refactoring02_GuardClauses
{
    public class BeforeExample
    {
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            double result;
            if (isDead)
            {
                result = DeadAmount();
            }
            else
            {
                if (isSeparated)
                {
                    result = SeparatedAmount();
                }
                else
                {
                    if (isRetired)
                        result = RetiredAmount();
                    else
                        result = NormalPayAmount();
                }
            }
            return result;
        }

        private double DeadAmount() => 1000;
        private double SeparatedAmount() => 2000;
        private double RetiredAmount() => 3000;
        private double NormalPayAmount() => 5000;
    }
}