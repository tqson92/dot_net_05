/* 
bài tập collection.
Cho một collection lstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]
Làm các bài tập sau:
    1. Tính tổng các số lớn hơn 50 trong danh sách
    2. Đếm số phần tử lớn hơn 30
    3. Tìm số lớn nhất
    4. Tính trung bình cộng của các số lẻ
    5. In ra các số chẵn
    6. Tìm vị trí đầu tiên của số 20
    7. Tìm số lượng phần tử bằng 15
    8. Tính tổng các số nhỏ hơn 40
    9. Đếm số lượng số chia hết cho 5
    10. Tạo danh sách mới chứa các số nhỏ hơn 50
*/

//output
using System.Text.Json.Serialization;

int tong_cac_so_lon_hon_50 = Method.tinh_tong_cac_so_lon_hon_50();
int so_phan_tu_lon_hon_30 = Method.dem_cac_so_lon_hon_30();
int so_lon_nhat = Method.tim_so_lon_nhat();
int trung_binh_cong_so_le = Method.tinh_trung_binh_cong_so_le();
string cac_so_chan = Method.in_ra_so_chan();
int vi_tri_dau_tien_so_20 = Method.tim_vi_tri_dau_tien_so_20();
int so_luong_bang_15 = Method.tim_so_luong_bang_15();
int tong_cac_so_nho_hon_40 = Method.tinh_tong_cac_so_nho_hon_40();
int dem_cac_so_chia_het_cho_5 = Method.dem_cac_so_chia_het_cho_5();
List<int> danh_sach_cac_so_nho_hon_50 = Method.tao_danh_sach_cac_so_nho_hon_50();

//in ra kết quả
Console.WriteLine($@"
    Collection: lstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20].
    Có tổng các số lớn hơn 50:      {tong_cac_so_lon_hon_50}
    Số phần tử lớn hơn 30:          {so_phan_tu_lon_hon_30}
    Số lớn nhất:                    {so_lon_nhat}
    Trung bình cộng các số lẻ:      {trung_binh_cong_so_le}
    Các số chẵn:                    {cac_so_chan}
    Vị trí đầu tiên của số 20:      {vi_tri_dau_tien_so_20}
    Số lượng phần tử bằng 15:       {so_luong_bang_15}
    Tổng các số nhỏ hơn 40:         {tong_cac_so_nho_hon_40}
    Đếm số chia hết cho 5:          {dem_cac_so_chia_het_cho_5}
    Danh sách các số nhỏ hơn 50:    [{string.Join(", ", danh_sach_cac_so_nho_hon_50.Select(so_chan => so_chan.ToString()))}]
");