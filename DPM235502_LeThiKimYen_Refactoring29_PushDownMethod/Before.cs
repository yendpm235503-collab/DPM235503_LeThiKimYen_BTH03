namespace DPM235503_LeThiKimYen_Refactoring29_PushDownMethod
{
    public class Animal
    {
        // Phương thức Bark() đặt ở Animal là không hợp lý cho tất cả động vật
        public string Bark() => "Woof!";
    }

    public class Dog : Animal { }
    public class Cat : Animal { }
}