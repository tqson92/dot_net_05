public class Method
{
    public static string tim_tu_dai_nhat(string chuoi)
    {
        if (chuoi != null)
        {
            string[] tachChuoi = chuoi.Split(" ");

            string tuDaiNhat = tachChuoi[0];
            for (int i = 1; i < tachChuoi.Length; i++)
            {
                if(tuDaiNhat.Length < tachChuoi[i].Length)
                {
                    tuDaiNhat = tachChuoi[i];
                }
            }

            return tuDaiNhat;
        }
        
        return "";
    }
}