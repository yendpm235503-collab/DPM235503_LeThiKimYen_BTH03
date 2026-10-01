namespace DPM235503_LeThiKimYen_Refactoring02_GuardClauses
{
    public class AfterExample
    {
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            if (isDead) return DeadAmount();
            if (isSeparated) return SeparatedAmount();
            if (isRetired) return RetiredAmount();

            return NormalPayAmount();
        }

        private double DeadAmount() => 1000;
        private double SeparatedAmount() => 2000;
        private double RetiredAmount() => 3000;
        private double NormalPayAmount() => 5000;
    }
}