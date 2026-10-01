namespace DPM235503_LeThiKimYen_Refactoring28_PullUpMethod
{
    public class VehicleAfter
    {
        // Kéo phương thức chung lên lớp cha
        public string GetBrand() => "Generic Brand";
    }

    public class CarAfter : VehicleAfter { }
    public class TruckAfter : VehicleAfter { }
}