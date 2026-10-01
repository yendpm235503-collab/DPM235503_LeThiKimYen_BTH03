namespace DPM235503_LeThiKimYen_Refactoring27_PreserveWholeObject
{
    public class ThongSoLuaGiong
    {
        public double DoAm { get; set; } = 12.5;
        public double DoSach { get; set; } = 99.0;
    }

    public class RealNongDuocAnGiang
    {
        public bool KiemTraLuaGiongDatChuan(ThongSoLuaGiong thongSo)
        {
            return thongSo.DoAm <= 13.5 && thongSo.DoSach >= 98.0;
        }
    }
}