namespace DPM235503_LeThiKimYen_Refactoring28_PullUpMethod
{
    public class SanPhamNongNghiepBase
    {
        public string GetXuatXu() => "Công ty Cổ phần Nông Dược An Giang";
    }

    public class ThuocTruSauAnGiang : SanPhamNongNghiepBase { }
    public class PhanBonAnGiang : SanPhamNongNghiepBase { }
}