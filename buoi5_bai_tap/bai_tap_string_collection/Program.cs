/* 
bài tập collection.
Cho một collection lstStrings = ["apple", "banana", "orange", "kiwi", "mango", "pineapple", "grape", "melon"]
Làm các bài tập sau:
    1. Tính độ dài của mảng
    2. In ra các chuỗi dài hơn 5 ký tự
    3. Tìm chuỗi dài nhất trong mảng
    4. In ra các chuỗi có chứa chữ a
*/

//output
int do_dai_cua_mang = Method.tinh_do_dai_cua_mang();
List<string> cac_chuoi_dai_hon_5_ky_tu = Method.tim_cac_chuoi_dai_hon_5_ky_tu();
string chuoi_dai_nhat = Method.tim_chuoi_dai_nhat();
List<string> cac_chuoi_chua_chu_a = Method.tim_cac_chuoi_chua_chu_a();

//in ra kết quả
Console.WriteLine($@"
    Collection: lstNumber = ['apple', 'banana', 'orange', 'kiwi', 'mango', 'pineapple', 'grape', 'melon']
    Độ dài của mảng:            {do_dai_cua_mang}
    Các chuỗi dài hơn 5 ký tự:  {string.Join(", ", cac_chuoi_dai_hon_5_ky_tu.Select(chuoi => chuoi))}
    Chuỗi dài nhất:             {chuoi_dai_nhat}
    Chuỗi chứa chữ a:           {string.Join(", ", cac_chuoi_chua_chu_a.Select(chuoi => chuoi))}
");