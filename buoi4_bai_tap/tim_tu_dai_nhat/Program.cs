// viết chương trình nhập 1 chuỗi và trả về từ dài nhất trong chuỗi
// ví dụ: "I love programming" -> "programming"

// input
Console.Write($@"Nhập vào chuỗi: ");
string chuoi = Console.ReadLine();

// output
string tuDaiNhat = "";

// process
tuDaiNhat = Method.tim_tu_dai_nhat(chuoi);

// xuất output
Console.WriteLine($@"
    Chuỗi nhập vào: {chuoi}
    Từ dài nhất: {tuDaiNhat}
");