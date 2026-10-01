namespace DPM235503_LeThiKimYen_Refactoring26_ReplaceParameterWithExplicitMethods
{
    public class BeforeExample
    {
        public bool IsActive { get; set; }

        public void SetState(int code)
        {
            if (code == 1) IsActive = true;
            else if (code == 0) IsActive = false;
        }
    }
}