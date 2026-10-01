namespace DPM235503_LeThiKimYen_Refactoring05_ReplaceConditionalWithPolymorphism
{
    public class EmployeeBefore
    {
        public int Type { get; set; } // 0: Manager, 1: Salesman

        public double GetBonus(double salary)
        {
            switch (Type)
            {
                case 0: return salary * 0.3;
                case 1: return salary * 0.1;
                default: return 0;
            }
        }
    }
}