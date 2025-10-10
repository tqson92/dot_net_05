// viết chương trình nhập tháng và hiển thị mùa tương ứng

// input
Console.Write($@"Nhập vào số tháng (từ tháng 1 tới tháng 12): ");
double soThang = Convert.ToInt16(Console.ReadLine());

// output
string mua = "";

// process
mua = soThang switch
{
    >= 1 and <= 3 => "xuân",
    >= 4 and <= 6 => "hạ",
    >= 7 and <= 9 => "thu",
    >= 10 and <= 12 => "đông",
    _ => "không xác định"
};

// xuất output
Console.WriteLine($@"
    Tháng nhập vào: {soThang}
    Mùa theo tháng là mùa {mua}
");