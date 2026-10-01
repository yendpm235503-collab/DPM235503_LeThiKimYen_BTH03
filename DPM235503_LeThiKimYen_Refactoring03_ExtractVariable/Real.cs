using System;

namespace DPM235503_LeThiKimYen_Refactoring03_ExtractVariable
{
    public class RealNongDuocAnGiang
    {
        public bool KiemTraKhuVucGiaoHangMienPhi(string khuVuc, double tongGiaTriDon, double khoangCachKm)
        {
            bool isAnGiang = khuVuc.Equals("An Giang", StringComparison.OrdinalIgnoreCase);
            bool isDonHangGiaTriCao = tongGiaTriDon >= 20000000;
            bool isGanKho = khoangCachKm <= 30;

            return (isAnGiang && isGanKho) || isDonHangGiaTriCao;
        }
    }
}