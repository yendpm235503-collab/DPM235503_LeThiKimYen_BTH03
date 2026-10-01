namespace DPM235503_LeThiKimYen_Refactoring14_HideDelegate
{
    public class KhuVucThiTruong
    {
        public string NhanVienPhuTrach { get; set; } = "Lê Văn Tấn (Kinh Doanh An Giang)";
    }

    public class DaiLyNongDuoc
    {
        public string TenDaiLy { get; set; }
        private KhuVucThiTruong _khuVuc = new KhuVucThiTruong();

        // Che giấu class KhuVucThiTruong, cung cấp hàm lấy NV trực tiếp
        public string GetNhanVienPhuTrach()
        {
            return _khuVuc.NhanVienPhuTrach;
        }
    }
}