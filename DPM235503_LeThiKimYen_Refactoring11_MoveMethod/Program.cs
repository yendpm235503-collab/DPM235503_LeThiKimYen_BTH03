using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring11_MoveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 11: MOVE METHOD ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Bank Charge: {before.BankCharge()}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Bank Charge: {after.BankCharge()}");

            LoHangNongDuoc loHang = new LoHangNongDuoc();
            loHang.LoaiKho.KhoLanhChuyenDung = true;
            Console.WriteLine($"[Nông Dược An Giang] Phí lưu kho lạnh (5 ngày): {loHang.TinhTongChiPhiLuuKho():N0} VNĐ");

            Console.ReadKey();
        }
    }
}