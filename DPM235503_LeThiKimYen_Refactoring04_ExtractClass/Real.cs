using System;

namespace DPM235503_LeThiKimYen_Refactoring04_ExtractClass
{
    public class DiaChiKhoHang
    {
        public string SoNhaTenDuong { get; set; }
        public string PhuongXa { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhThanh { get; set; }

        public string GetDiaChiFull()
        {
            return $"{SoNhaTenDuong}, {PhuongXa}, {QuanHuyen}, {TinhThanh}";
        }
    }

    public class KhoNongDuocAnGiang
    {
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public DiaChiKhoHang DiaChi { get; set; } = new DiaChiKhoHang();

        public void HienThiThongTin()
        {
            Console.WriteLine($"[KHO NÔNG DƯỢC] {TenKho} ({MaKho}) - Địa chỉ: {DiaChi.GetDiaChiFull()}");
        }
    }
}