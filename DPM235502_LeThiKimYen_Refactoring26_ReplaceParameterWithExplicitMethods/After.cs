namespace DPM235503_LeThiKimYen_Refactoring26_ReplaceParameterWithExplicitMethods
{
    public class AfterExample
    {
        public bool IsActive { get; private set; }

        public void Activate() => IsActive = true;
        public void Deactivate() => IsActive = false;
    }
}