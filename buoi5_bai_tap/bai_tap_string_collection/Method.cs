public static class Method
{

    public static List<string> lstStrings = ["apple", "banana", "orange", "kiwi", "mango", "pineapple", "grape", "melon"];

    public static int tinh_do_dai_cua_mang()
    {
        return lstStrings.Count();
    }

    public static List<string> tim_cac_chuoi_dai_hon_5_ky_tu()
    {
        List<string> cac_chuoi_dai_hon_5_ky_tu = lstStrings.FindAll(chuoi => chuoi.Length > 5);
        return cac_chuoi_dai_hon_5_ky_tu;
    }

    public static string tim_chuoi_dai_nhat()
    {

        int so_ky_tu = 0;
        string chuoi_dai_nhat = "";
        foreach (string chuoi in lstStrings)
        {
            if (chuoi.Length > so_ky_tu)
            {
                chuoi_dai_nhat = chuoi;
                so_ky_tu = chuoi.Length;
            }
        }

        return chuoi_dai_nhat;
    }

    public static List<string> tim_cac_chuoi_chua_chu_a()
    {

        List<string> cac_chuoi_chua_chu_a = lstStrings.FindAll(chuoi =>
        {
            List<char> cac_ky_tu = chuoi.ToCharArray().ToList();
            return cac_ky_tu.FindIndex(ky_tu => ky_tu == 'a') >= 0;
        });

        return cac_chuoi_chua_chu_a;
    }
}