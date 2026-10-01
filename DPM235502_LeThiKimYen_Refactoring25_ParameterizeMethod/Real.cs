namespace DPM235503_LeThiKimYen_Refactoring25_ParameterizeMethod
{
    public class RealNongDuocAnGiang
    {
        private double _giaThuocLuuHanh = 200000;

        public void TangGiaNongDuoc(double phanTramTang)
        {
            _giaThuocLuuHanh *= (1 + phanTramTang);
        }

        public double GetGiaThuoc() => _giaThuocLuuHanh;
    }
}