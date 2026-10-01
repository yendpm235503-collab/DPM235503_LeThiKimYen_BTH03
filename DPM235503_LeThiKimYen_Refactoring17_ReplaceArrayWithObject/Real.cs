namespace DPM235503_LeThiKimYen_Refactoring17_ParameterizeMethod
{
    public class SanPhamAnGiang
    {
        public string TenThuoc { get; set; }
        public double GiaKhuyenNghi { get; set; } = 200000;

        // Tham số hóa việc điều chỉnh giá bán thuốc nông nghiệp
        public void DieuChinhGia(double phanTramDieuChinh)
        {
            GiaKhuyenNghi *= (1 + phanTramDieuChinh);
        }
    }
}