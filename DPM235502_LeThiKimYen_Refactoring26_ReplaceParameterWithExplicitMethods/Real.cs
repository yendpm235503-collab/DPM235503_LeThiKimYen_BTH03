using System;

namespace DPM235503_LeThiKimYen_Refactoring26_ReplaceParameterWithExplicitMethods
{
    public class RealNongDuocAnGiang
    {
        public bool TrangThaiKhoLanh { get; private set; }

        public void BieuMoKhoLanh()
        {
            TrangThaiKhoLanh = true;
            Console.WriteLine("Kho lạnh bảo quản nông dược đã BẬT.");
        }

        public void TatKhoLanh()
        {
            TrangThaiKhoLanh = false;
            Console.WriteLine("Kho lạnh bảo quản nông dược đã TẮT.");
        }
    }
}