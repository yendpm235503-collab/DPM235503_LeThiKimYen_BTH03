using System;

namespace DPM235503_LeThiKimYen_Refactoring01_ExtractMethod
{
    public class RealNongDuocAnGiang
    {
        public void XuLyHoaDonThuocNongNghiep(string tenDaiLy, double tongTien)
        {
            InTieuDeHoaDon();
            InThongTinThanhToan(tenDaiLy, tongTien);
        }

        private void InTieuDeHoaDon()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("   CÔNG TY CỔ PHẦN NÔNG DƯỢC AN GIANG       ");
            Console.WriteLine("      HÓA ĐƠN XUẤT KHO VẬT TƯ NÔNG NGHIỆP    ");
            Console.WriteLine("=============================================");
        }

        private void InThongTinThanhToan(string tenDaiLy, double tongTien)
        {
            Console.WriteLine($"Tên Đại Lý : {tenDaiLy}");
            Console.WriteLine($"Tổng Chi Phí: {tongTien:N0} VNĐ");
            Console.WriteLine("---------------------------------------------");
        }
    }
}