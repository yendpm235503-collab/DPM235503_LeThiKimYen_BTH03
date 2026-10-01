namespace DPM235503_LeThiKimYen_Refactoring18_ReplaceParameterWithExplicitMethods
{
    public class AfterExample
    {
        public int Height { get; set; }
        public int Width { get; set; }

        // Tách ra từng hàm tường minh
        public void SetHeight(int value) => Height = value;
        public void SetWidth(int value) => Width = value;
    }
}