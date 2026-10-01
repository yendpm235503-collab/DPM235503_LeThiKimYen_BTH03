using System;

namespace DPM235503_LeThiKimYen_Refactoring13_InlineClass
{
    public class DaiLyNongDuocAnGiang
    {
        public string TenDaiLy { get; set; }
        // Inline thông tin Mã số thuế trực tiếp vào Lớp Đại lý thay vì tạo Lớp MaSoThue riêng lẻ
        public string MaSoThue { get; set; }

        public void InThongTinDaiLy()
        {
            Console.WriteLine($"[ĐẠI LÝ] {TenDaiLy} - MST: {MaSoThue}");
        }
    }
}