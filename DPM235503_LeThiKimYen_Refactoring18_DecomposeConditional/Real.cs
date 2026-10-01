using System;

namespace DPM235503_LeThiKimYen_Refactoring18_ReplaceParameterWithExplicitMethods
{
    public class HopDongDaiLyAnGiang
    {
        public bool IsKichHoat { get; private set; }

        // Tách hàm kích hoạt/khóa hợp đồng rõ ràng thay vì SetStatus(bool active)
        public void KichHoatHopDong()
        {
            IsKichHoat = true;
            Console.WriteLine("Hợp đồng Đại lý An Giang đã được KÍCH HOẠT.");
        }

        public void TuyenHuyHopDong()
        {
            IsKichHoat = false;
            Console.WriteLine("Hợp đồng Đại lý An Giang đã bị TẠM KHÓA.");
        }
    }
}