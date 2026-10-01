namespace DPM235503_LeThiKimYen_Refactoring10_RemoveAssignmentsToParameters
{
    public class RealNongDuocAnGiang
    {
        public double TinhGiaThucTeThuocTruSau(double giaGoc, int soLuongBao, bool isKhachQuen)
        {
            double giaSauGiam = giaGoc; // Tạo biến lưu kết quả, không làm biến đổi tham số giaGoc
            if (soLuongBao >= 50) giaSauGiam *= 0.95;
            if (isKhachQuen) giaSauGiam -= 10000;
            return giaSauGiam;
        }
    }
}