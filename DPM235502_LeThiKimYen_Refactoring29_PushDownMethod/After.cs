namespace DPM235503_LeThiKimYen_Refactoring29_PushDownMethod
{
    public class AnimalAfter { }

    public class DogAfter : AnimalAfter
    {
        // Đẩy hàm Bark() xuống riêng cho Lớp Dog
        public string Bark() => "Woof!";
    }

    public class CatAfter : AnimalAfter { }
}