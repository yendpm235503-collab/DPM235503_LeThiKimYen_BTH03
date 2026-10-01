namespace DPM235503_LeThiKimYen_Refactoring08_ReplaceTempWithQuery
{
    public class RealNongDuocAnGiang
    {
        private int _soLuongThung = 20;
        private double _donGiaThung = 500000;

        public double TinhTongTienXuatKho()
        {
            if (GetTongTienGoc() > 8000000)
                return GetTongTienGoc() * 0.90; // Chiết khấu 10%
            return GetTongTienGoc();
        }

        private double GetTongTienGoc() => _soLuongThung * _donGiaThung;
    }
}