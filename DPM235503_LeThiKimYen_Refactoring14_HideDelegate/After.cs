namespace DPM235503_LeThiKimYen_Refactoring14_HideDelegate
{
    public class DepartmentAfter
    {
        public string Manager { get; set; } = "Nguyễn Văn A";
    }

    public class AfterExample
    {
        private DepartmentAfter _department = new DepartmentAfter();

        // Che giấu đối tượng Department bằng cách cung cấp phương thức trực tiếp
        public string GetManager()
        {
            return _department.Manager;
        }
    }
}