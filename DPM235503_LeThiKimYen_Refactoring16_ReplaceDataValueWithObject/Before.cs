namespace DPM235503_LeThiKimYen_Refactoring16_ExtractInterface
{
    public class Employee
    {
        public double GetRate() => 100.0;
        public bool HasSpecialSkill() => true;
    }

    public class BeforeExample
    {
        // Phụ thuộc trực tiếp vào lớp cụ thể Employee
        public double Charge(Employee emp, int hours)
        {
            double baseCharge = emp.GetRate() * hours;
            if (emp.HasSpecialSkill())
                return baseCharge * 1.25;
            return baseCharge;
        }
    }
}