using System;

namespace DPM235503_LeThiKimYen_Refactoring15_EncapsulateField
{
    public class DaiLyChinhThucAnGiang
    {
        private double _doanhSoNam;

        // Đóng gói dữ liệu Doanh Số và kiểm tra điều kiện hợp lệ
        public double DoanhSoNam
        {
            get => _doanhSoNam;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Lỗi: Doanh số không được âm!");
                    _doanhSoNam = 0;
                }
                else
                {
                    _doanhSoNam = value;
                }
            }
        }
    }
}