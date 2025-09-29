// viết chương trình nhập vào cân nặng và chiều cao, sau đó tính và hiển thị chỉ số BMI

// input
Console.Write($@"Nhập vào cân nặng (theo kg): ");
double canNang = Convert.ToDouble(Console.ReadLine());
Console.Write($@"Nhập vào chiều cao (theo mét): ");
double chieuCao = Convert.ToDouble(Console.ReadLine());

// output
double bmi = 0;

// process
bmi = canNang / (chieuCao * chieuCao);

// xuất output
Console.WriteLine($@"
    Cân nặng: {canNang} kg
    Chiều cao: {chieuCao} m
    Chỉ số Body Mass Index: {bmi}
");