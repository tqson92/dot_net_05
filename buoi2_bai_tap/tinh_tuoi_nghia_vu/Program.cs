// viết chương trình nhập vào số tuổi của công dân và xuất ra xem có đủ tuổi đi nghĩa vụ quân sự hay không

// input
Console.Write($@"Nhập vào số tuổi của công dân: ");
double soTuoi = Convert.ToInt16(Console.ReadLine());

// output
string kiemTra = "";

// process
kiemTra = soTuoi switch
{
    < 18 => "chưa đủ tuổi tham gia NVQS",
    >= 18 and <= 27 => "đủ tuổi tham gia NVQS",
    _ => "quá tuổi tham gia NVQS"
};

// xuất output
Console.WriteLine($@"
    Tuổi của công dân là: {soTuoi}
    Nên {kiemTra}
");