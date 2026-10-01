namespace DPM235503_LeThiKimYen_Refactoring15_EncapsulateField
{
    public class AfterExample
    {
        private string _name;

        // Đóng gói trường dữ liệu qua Property
        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}