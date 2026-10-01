namespace DPM235503_LeThiKimYen_Refactoring12_MoveField
{
    public class NhomHangNongDuoc
    {
        public string TenNhom { get; set; }
        // Di chuyển ChietKhauPhanTramTram tu SanPham ve NhomHang
        public double ChietKhauPhanTram { get; set; } = 0.10; // 10%
    }

    public class SanPhamNongDuoc
    {
        public string TenThuoc { get; set; }
        public double DonGia { get; set; }
        public NhomHangNongDuoc Nhom { get; set; } = new NhomHangNongDuoc();

        public double TinhGiaSauChietKhau()
        {
            return DonGia * (1 - Nhom.ChietKhauPhanTram);
        }
    }
}