namespace DPM235503_LeThiKimYen_Refactoring14_HideDelegate
{
    public class Department
    {
        public string Manager { get; set; } = "Nguyễn Văn A";
    }

    public class BeforeExample
    {
        public Department Department { get; set; } = new Department();
        // Client phải gọi person.Department.Manager (bị lộ cấu trúc liên kết)
    }
}