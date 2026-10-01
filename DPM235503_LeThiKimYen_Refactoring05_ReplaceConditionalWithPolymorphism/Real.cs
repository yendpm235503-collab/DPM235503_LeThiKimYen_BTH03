namespace DPM235503_LeThiKimYen_Refactoring05_ReplaceConditionalWithPolymorphism
{
    public abstract class SanPhamNongDuoc
    {
        public string TenSanPham { get; set; }
        public double GiaNhap { get; set; }
        public abstract double TinhGiaBan();
    }

    public class ThuocTruSau : SanPhamNongDuoc
    {
        public override double TinhGiaBan() => GiaNhap * 1.20; // +20%
    }

    public class PhanBonLa : SanPhamNongDuoc
    {
        public override double TinhGiaBan() => GiaNhap * 1.12; // +12%
    }
}