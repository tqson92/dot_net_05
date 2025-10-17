public class Method
{
    public static string bo_ky_tu_dac_biet(string chuoi)
    {
        string[] kyTuCanLoaiBo = ["#", "@", "!", "~", "$", "%", "^", "&", "*", "(", ")"];
        for (int i = 0; i < kyTuCanLoaiBo.Length; i++)
        {
            chuoi = chuoi.Replace(kyTuCanLoaiBo[i], "");
        }

        return chuoi;
    }
}