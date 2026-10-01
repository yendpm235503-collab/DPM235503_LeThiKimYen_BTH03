namespace DPM235503_LeThiKimYen_Refactoring11_MoveMethod
{
    public class LoaiKhoNongDuoc
    {
        public bool KhoLanhChuyenDung { get; set; }

        // Chuyển phương thức tính phí lưu kho vào đúng lớp quy định Loại Kho
        public double TinhPhiLuuKhoTheoNgay(int soNgayLuu, double giaTieuChuan)
        {
            if (KhoLanhChuyenDung)
            {
                return soNgayLuu * giaTieuChuan * 1.5; // Phụ phí bảo quản lạnh
            }
            return soNgayLuu * giaTieuChuan;
        }
    }

    public class LoHangNongDuoc
    {
        public LoaiKhoNongDuoc LoaiKho { get; set; } = new LoaiKhoNongDuoc();
        public int SoNgayLuuKho { get; set; } = 5;

        public double TinhTongChiPhiLuuKho()
        {
            return LoaiKho.TinhPhiLuuKhoTheoNgay(SoNgayLuuKho, 20000);
        }
    }
}