namespace DPM235503_LeThiKimYen_Refactoring05_ReplaceConditionalWithPolymorphism
{
    public abstract class EmployeeAfter
    {
        public abstract double GetBonus(double salary);
    }

    public class Manager : EmployeeAfter
    {
        public override double GetBonus(double salary) => salary * 0.3;
    }

    public class Salesman : EmployeeAfter
    {
        public override double GetBonus(double salary) => salary * 0.1;
    }
}