public static class Method
{

    public static List<int> lstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20];

    public static int tinh_tong_cac_so_lon_hon_50()
    {
        List<int> list_cac_so_lon_hon_50 = lstNumber.FindAll(number => number > 50);

        int tong_cac_so_lon_hon_50 = list_cac_so_lon_hon_50.Sum();

        return tong_cac_so_lon_hon_50;
    }

    public static int dem_cac_so_lon_hon_30()
    {
        List<int> list_cac_so_lon_hon_30 = lstNumber.FindAll(number => number > 30);

        return list_cac_so_lon_hon_30.Count;
    }

    public static int tim_so_lon_nhat()
    {
        return lstNumber.Max();
    }

    public static int tinh_trung_binh_cong_so_le()
    {
        List<int> cac_so_le = lstNumber.FindAll(number => number % 2 > 0);

        int trung_binh_cong_cac_so_le = cac_so_le.Sum() / cac_so_le.Count();

        return trung_binh_cong_cac_so_le;
    }

    public static string in_ra_so_chan()
    {
        List<int> cac_so_chan = lstNumber.FindAll(number => number % 2 == 0);

        string chuoi_in_ra = string.Join(", ", cac_so_chan.Select(so_chan => so_chan.ToString()));

        return chuoi_in_ra;
    }

    public static int tim_vi_tri_dau_tien_so_20()
    {
        int vi_tri_dau_tien_so_20 = lstNumber.FindIndex(number => number == 20);

        return vi_tri_dau_tien_so_20;
    }

    public static int tim_so_luong_bang_15()
    {
        List<int> cac_so_bang_15 = lstNumber.FindAll(number => number == 15);

        return cac_so_bang_15.Count();
    }

    public static int tinh_tong_cac_so_nho_hon_40()
    {
        List<int> list_cac_so_nho_hon_40 = lstNumber.FindAll(number => number < 40);

        return list_cac_so_nho_hon_40.Sum();
    }

    public static int dem_cac_so_chia_het_cho_5()
    {
        List<int> list_cac_so_chia_het_cho_5 = lstNumber.FindAll(number => number % 5 == 0);

        return list_cac_so_chia_het_cho_5.Count();
    }

    public static List<int> tao_danh_sach_cac_so_nho_hon_50()
    {
        List<int> list_cac_so_chia_het_cho_5 = lstNumber.FindAll(number => number < 50);

        return list_cac_so_chia_het_cho_5;
    }
}