using System;

namespace DPM235503_LeThiKimYen_Refactoring09_SplitTemporaryVariable
{
    public class RealNongDuocAnGiang
    {
        public void TinhThuThapChiPhiPhanBon(double giaGoc, double phiVanChuyen)
        {
            // Tách thành 2 biến rõ nghĩa riêng biệt
            double tongChiPhiNhap = giaGoc + phiVanChuyen;
            Console.WriteLine($"Tổng chi phí nhập lô hàng: {tongChiPhiNhap:N0} VNĐ");

            double giaBanGoiY = tongChiPhiNhap * 1.15;
            Console.WriteLine($"Giá bán gợi ý cho Đại lý An Giang: {giaBanGoiY:N0} VNĐ");
        }
    }
}