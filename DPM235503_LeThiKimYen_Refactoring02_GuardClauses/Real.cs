namespace DPM235503_LeThiKimYen_Refactoring02_GuardClauses
{
    public class RealNongDuocAnGiang
    {
        public double TinhTienChietKhauDaiLy(bool daHuyHopDong, bool biViPham, bool isDaiLyCap1, double tongDoanhSo)
        {
            if (daHuyHopDong) return 0;
            if (biViPham) return 0;
            if (isDaiLyCap1) return tongDoanhSo * 0.15;

            return tongDoanhSo * 0.05;
        }
    }
}