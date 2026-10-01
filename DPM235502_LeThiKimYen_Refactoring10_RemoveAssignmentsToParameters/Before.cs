namespace DPM235503_LeThiKimYen_Refactoring10_RemoveAssignmentsToParameters
{
    public class BeforeExample
    {
        public int Discount(int inputVal, int quantity, int yearsToGet)
        {
            if (inputVal > 50) inputVal -= 2; // Gán trực tiếp vào tham số inputVal
            if (quantity > 100) inputVal -= 1;
            if (yearsToGet > 10) inputVal -= 5;
            return inputVal;
        }
    }
}