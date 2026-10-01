namespace DPM235503_LeThiKimYen_Refactoring07_InlineTemp
{
    public class RealNongDuocAnGiang
    {
        public bool LaDonHangKhuyenMaiAnGiang(double giaTriDonHang)
        {
            // Inline trực tiếp giá trị vào biểu thức so sánh
            return giaTriDonHang >= 50000000;
        }
    }
}