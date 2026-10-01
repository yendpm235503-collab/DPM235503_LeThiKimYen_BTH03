namespace DPM235503_LeThiKimYen_Refactoring16_ExtractInterface
{
    // Tách Interface chứa các phương thức cần thiết
    public interface IBillable
    {
        double GetRate();
        bool HasSpecialSkill();
    }

    public class EmployeeAfter : IBillable
    {
        public double GetRate() => 100.0;
        public bool HasSpecialSkill() => true;
    }

    public class AfterExample
    {
        // Giờ đây phương thức chỉ phụ thuộc vào Interface IBillable
        public double Charge(IBillable billable, int hours)
        {
            double baseCharge = billable.GetRate() * hours;
            if (billable.HasSpecialSkill())
                return baseCharge * 1.25;
            return baseCharge;
        }
    }
}