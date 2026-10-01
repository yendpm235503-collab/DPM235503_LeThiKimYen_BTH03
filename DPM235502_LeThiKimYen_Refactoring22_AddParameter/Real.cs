namespace DPM235503_LeThiKimYen_Refactoring22_AddParameter
{
    public class RealNongDuocAnGiang
    {
        // Thêm tham số tiLeGiamGia vào phương thức tính giá thuốc nông nghiệp
        public double TinhGiaBanThuoc(double giaGoc, double tiLeGiamGia)
        {
            return giaGoc * (1 - tiLeGiamGia);
        }
    }
}