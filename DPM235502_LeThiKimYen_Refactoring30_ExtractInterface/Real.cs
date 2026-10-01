using System;

namespace DPM235503_LeThiKimYen_Refactoring30_ExtractInterface
{
    public interface IThanhToanNongDuoc
    {
        void ThanhToan(double soTien);
    }

    public class ThanhToanChuyenKhoanAnGiang : IThanhToanNongDuoc
    {
        public void ThanhToan(double soTien)
        {
            Console.WriteLine($"[Nông Dược An Giang] Đã thanh toán chuyển khoản: {soTien:N0} VNĐ thành công.");
        }
    }
}