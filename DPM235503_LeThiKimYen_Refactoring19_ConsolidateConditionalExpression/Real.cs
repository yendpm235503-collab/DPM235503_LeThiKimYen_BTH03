namespace DPM235503_LeThiKimYen_Refactoring19_PreserveWholeObject
{
    public class ThongSoMoiTruongKho
    {
        public double NhietDo { get; set; } = 22.5; // Đọ C
        public double DoAm { get; set; } = 60.0;    // %
    }

    public class RealNongDuocAnGiang
    {
        // Truyền nguyên đối tượng thông số môi trường để kiểm tra điều kiện bảo quản thuốc
        public bool KiemTraAnToanLuuKho(ThongSoMoiTruongKho thongSo)
        {
            return thongSo.NhietDo <= 25.0 && thongSo.DoAm <= 70.0;
        }
    }
}