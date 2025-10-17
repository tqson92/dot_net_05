// nhập vào chuỗi ký tự và loại bỏ các ký tự đặc biệt
// ví dụ: he@llo! worl#d ->  hello world

//input
Console.Write($@"Nhập vào chuỗi: ");
string chuoi = Console.ReadLine();

//output
string chuoiCuoiCung = "";

//process
chuoiCuoiCung = Method.bo_ky_tu_dac_biet(chuoi);

//in ra
Console.WriteLine($@"
    Chuỗi nhập vào: {chuoi}
    Chuỗi đã bỏ ký tự đặc biệt: {chuoiCuoiCung}
");