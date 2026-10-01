namespace DPM235503_LeThiKimYen_Refactoring06_InlineMethod
{
    public class RealNongDuocAnGiang
    {
        public bool KiemTraTonKhoCanCanhBao(int soLuongTon)
        {
            // Inline trực tiếp điều kiện so sánh thay vì tách thành hàm nhỏ thừa thãi
            return soLuongTon < 10;
        }
    }
}