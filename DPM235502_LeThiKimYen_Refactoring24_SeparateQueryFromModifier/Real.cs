namespace DPM235503_LeThiKimYen_Refactoring24_SeparateQueryFromModifier
{
    public class RealNongDuocAnGiang
    {
        private int _soThungTonKho = 50;

        public int GetSoThungTonKho() => _soThungTonKho;

        public void XuatKhoPhanBon(int soLuongXuat)
        {
            if (soLuongXuat <= _soThungTonKho)
                _soThungTonKho -= soLuongXuat;
        }
    }
}