namespace DPM235503_LeThiKimYen_Refactoring18_ReplaceParameterWithExplicitMethods
{
    public class BeforeExample
    {
        public int Height { get; set; }
        public int Width { get; set; }

        // Dùng tham số cờ string nguy hiểm, dễ gõ sai
        public void SetValue(string name, int value)
        {
            if (name.Equals("height")) Height = value;
            if (name.Equals("width")) Width = value;
        }
    }
}