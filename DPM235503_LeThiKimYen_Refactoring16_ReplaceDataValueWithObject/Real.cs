namespace DPM235503_LeThiKimYen_Refactoring16_ExtractInterface
{
    public interface IDichVuNongNghiep
    {
        double TinhChiPhi(double dienTichSao);
    }

    public class PhunThuocFlycamAnGiang : IDichVuNongNghiep
    {
        public double TinhChiPhi(double dienTichSao)
        {
            return dienTichSao * 180000; // 180k / công (sào)
        }
    }

    public class RealNongDuocAnGiang
    {
        public double TinhTongThanhToan(IDichVuNongNghiep dichVu, double dienTich)
        {
            return dichVu.TinhChiPhi(dienTich);
        }
    }
}