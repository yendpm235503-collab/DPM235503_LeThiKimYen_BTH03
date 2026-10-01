namespace DPM235503_LeThiKimYen_Refactoring20_ReplaceParameterWithMethodCall
{
    public class RealNongDuocAnGiang
    {
        public double TinhTongThanhToanSauThue(double tongTienChuaThue)
        {
            double thueSuat = GetThueSuatVATNongNghiep();
            return tongTienChuaThue * (1 + thueSuat);
        }

        private double GetThueSuatVATNongNghiep()
        {
            return 0.05; // VAT 5% áp dụng cho sản phẩm nông nghiệp
        }
    }
}