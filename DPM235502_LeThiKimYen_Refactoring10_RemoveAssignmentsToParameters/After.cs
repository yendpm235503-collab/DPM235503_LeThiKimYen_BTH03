namespace DPM235503_LeThiKimYen_Refactoring10_RemoveAssignmentsToParameters
{
    public class AfterExample
    {
        public int Discount(int inputVal, int quantity, int yearsToGet)
        {
            int result = inputVal; // Dùng biến cục bộ riêng
            if (result > 50) result -= 2;
            if (quantity > 100) result -= 1;
            if (yearsToGet > 10) result -= 5;
            return result;
        }
    }
}