
//Label 1.1
// Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào [tên], bạn [tuổi] tuổi!".
using System;

namespace BasicExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bài 1
            Console.WriteLine("Bài 1: Nhập tên và tuổi, sau đó in ra màn hình thông báo");
            Console.Write("Nhập tên của bạn: ");
            string name = Console.ReadLine();
            Console.Write("Nhập tuổi của bạn: ");
            string age = Console.ReadLine();
            Console.WriteLine($"Xin chào {name}, bạn {age} tuổi!");

            // Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và chiều rộng.
            Console.WriteLine("\nBài 2: Tính diện tích hình chữ nhật");
            Console.Write("Nhập chiều dài: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Diện tích hình chữ nhật: {length * width}");

            // Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
            Console.WriteLine("\nBài 3: Chuyển đổi nhiệt độ từ độ C sang độ F");
            Console.Write("Nhập nhiệt độ (°C): ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Nhiệt độ tương ứng: {fahrenheit}°F");

            // Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn hay không.
            Console.WriteLine("\nBài 4: Kiểm tra số chẵn hay lẻ");
            Console.Write("Nhập một số nguyên: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Số chẵn");
            else
                Console.WriteLine("Số lẻ");

            // Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
            Console.WriteLine("\nBài 5: Tính tổng và tích của hai số");
            Console.Write("Nhập số thứ nhất: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Tổng: {num1 + num2}, Tích: {num1 * num2}");

            // Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.
            Console.WriteLine("\nBài 6: Kiểm tra số dương, âm hoặc bằng 0");
            Console.Write("Nhập một số: ");
            double number = Convert.ToDouble(Console.ReadLine());
            if (number > 0)
                Console.WriteLine("Số dương");
            else if (number < 0)
                Console.WriteLine("Số âm");
            else
                Console.WriteLine("Số không");

            // Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
            Console.WriteLine("\nBài 7: Kiểm tra năm nhuận");
            Console.Write("Nhập năm: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("Năm nhuận");
            else
                Console.WriteLine("Không phải năm nhuận");

            // Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.
            Console.WriteLine("\nBài 8: In bảng cửu chương từ 1 đến 10");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i} x {j} = {i * j}\t");
                }
                Console.WriteLine();
            }

            // Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
            Console.WriteLine("\nBài 9: Tính giai thừa của một số nguyên dương");
            Console.Write("Nhập số nguyên dương: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Giai thừa của {n} là {factorial}");

            // Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
            Console.WriteLine("\nBài 10: Kiểm tra số nguyên tố");
            Console.Write("Nhập một số nguyên: ");
            int primeCheck = Convert.ToInt32(Console.ReadLine());
            bool isPrime = primeCheck > 1;
            for (int i = 2; i <= Math.Sqrt(primeCheck); i++)
            {
                if (primeCheck % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime ? "Là số nguyên tố" : "Không phải số nguyên tố");
        }
    }
}


//Lab1.2
//Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.
int TinhTongChan(int[] arr)
{
    int tong = 0;
    foreach (int x in arr)
    {
        if (x % 2 == 0)
            tong += x;
    }
    return tong;
}

//Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm
//tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử
//là số nguyên tố trong mảng.
bool LaSoNguyenTo(int n)
{
    if (n < 2) return false;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}

void InSoNguyenTo(int[] arr)
{
    Console.WriteLine("Các số nguyên tố trong mảng:");
    for (int i = 0; i < arr.Length; i++)
    {
        if (LaSoNguyenTo(arr[i]))
            Console.WriteLine($"Chỉ số: {i}, Giá trị: {arr[i]}");
    }
}

//Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập
//từ bàn phím.
void DemSoAmDuong(int[] arr, out int soAm, out int soDuong)
{
    soAm = 0;
    soDuong = 0;
    foreach (int x in arr)
    {
        if (x < 0) soAm++;
        else if (x > 0) soDuong++;
    }
}

//Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
int TimSoLonThuHai(int[] arr)
{
    int max = int.MinValue;
    int secondMax = int.MinValue;

    foreach (int x in arr)
    {
        if (x > max)
        {
            secondMax = max;
            max = x;
        }
        else if (x > secondMax && x < max)
        {
            secondMax = x;
        }
    }

    return secondMax;
}

//Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.
void HoanVi(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

//Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.
void SapXepTangDan(double[] arr)
{
    Array.Sort(arr); // Cách đơn giản nhất
}


//Lab1.3


// Bài 1: Tính diện tích và chu vi hình chữ nhật
class HinhChuNhat
{
    public double ChieuDai { get; set; }
    public double ChieuRong { get; set; }

    public double TinhDienTich() => ChieuDai * ChieuRong;
    public double TinhChuVi() => 2 * (ChieuDai + ChieuRong);
}

// Bài 2: Tính diện tích và chu vi hình tròn
class HinhTron
{
    public double BanKinh { get; set; }

    public double TinhDienTich() => Math.PI * BanKinh * BanKinh;
    public double TinhChuVi() => 2 * Math.PI * BanKinh;
}

// Bài 3: Quản lý thông tin sinh viên
class SinhVien
{
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public string Lop { get; set; }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Tuổi: {Tuoi}, Lớp: {Lop}");
    }
}

// Bài 4: Lớp phân số
class PhanSo
{
    public int Tu { get; set; }
    public int Mau { get; set; }

    public PhanSo RutGon()
    {
        int gcd = GCD(Tu, Mau);
        return new PhanSo { Tu = Tu / gcd, Mau = Mau / gcd };
    }

    private int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

    public void HienThi() => Console.WriteLine($"{Tu}/{Mau}");
}

// Bài 5: Tính tổng các số nguyên trong mảng
class MangSoNguyen
{
    public int[] Mang { get; set; }

    public int TinhTong() => Mang.Sum();
}

// Bài 6: Lớp hình vuông kế thừa hình chữ nhật
class HinhVuong : HinhChuNhat
{
    public HinhVuong(double canh)
    {
        ChieuDai = ChieuRong = canh;
    }
}

// Bài 7: Quản lý danh sách sinh viên
class DanhSachSinhVien
{
    public List<SinhVien> SinhViens { get; set; } = new List<SinhVien>();

    public void ThemSinhVien(SinhVien sv) => SinhViens.Add(sv);
    public void HienThiTatCa()
    {
        foreach (var sv in SinhViens) sv.HienThiThongTin();
    }
}

// Bài 8: Quản lý sản phẩm
class SanPham
{
    public string Ten { get; set; }
    public double Gia { get; set; }

    public void HienThi() => Console.WriteLine($"Sản phẩm: {Ten}, Giá: {Gia}");
}

// Bài 9: Lớp động vật
abstract class DongVat
{
    public abstract void Keu();
}

class Cho : DongVat
{
    public override void Keu() => Console.WriteLine("Gâu gâu");
}

class Meo : DongVat
{
    public override void Keu() => Console.WriteLine("Meo meo");
}

// Bài 10: Quản lý nhân viên
class NhanVien
{
    public string Ten { get; set; }
    public double Luong { get; set; }

    public void HienThi() => Console.WriteLine($"Tên: {Ten}, Lương: {Luong}");
}

// Bài 11: Tính diện tích tam giác
class TamGiac
{
    public double CanhA { get; set; }
    public double CanhB { get; set; }
    public double CanhC { get; set; }

    public double TinhDienTich()
    {
        double p = (CanhA + CanhB + CanhC) / 2;
        return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC));
    }
}

// Bài 12: Lớp máy tính
class MayTinh
{
    public double Cong(double a, double b) => a + b;
    public double Tru(double a, double b) => a - b;
    public double Nhan(double a, double b) => a * b;
    public double Chia(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException();
}

// Bài 13: Quản lý điểm học sinh
class DiemHocSinh
{
    public string Ten { get; set; }
    public double DiemToan { get; set; }
    public double DiemVan { get; set; }

    public double DiemTB() => (DiemToan + DiemVan) / 2;
}

// Bài 14: Lớp ô tô
class OTo
{
    public string Hang { get; set; }
    public string Mau { get; set; }

    public void HienThi() => Console.WriteLine($"Hãng: {Hang}, Màu: {Mau}");
}

// Bài 15: Lớp điểm 3D kế thừa điểm 2D
class Diem2D
{
    public double X { get; set; }
    public double Y { get; set; }
}

class Diem3D : Diem2D
{
    public double Z { get; set; }
}

// Bài 16: Quản lý sách
class Sach
{
    public string TieuDe { get; set; }
    public string TacGia { get; set; }

    public void HienThi() => Console.WriteLine($"Sách: {TieuDe}, Tác giả: {TacGia}");
}

// Bài 17: Lớp hình học với đa hình
abstract class HinhHoc
{
    public abstract double TinhDienTich();
}

class HinhChuNhat2 : HinhHoc
{
    public double Dai { get; set; }
    public double Rong { get; set; }
    public override double TinhDienTich() => Dai * Rong;
}

class HinhTron2 : HinhHoc
{
    public double BanKinh { get; set; }
    public override double TinhDienTich() => Math.PI * BanKinh * BanKinh;
}

// Bài 18: Quản lý tài khoản ngân hàng
class TaiKhoanNganHang
{
    public string SoTaiKhoan { get; set; }
    public double SoDu { get; set; }

    public void NapTien(double soTien) => SoDu += soTien;
    public bool RutTien(double soTien)
    {
        if (soTien > SoDu) return false;
        SoDu -= soTien;
        return true;
    }
    public void HienThi() => Console.WriteLine($"Số TK: {SoTaiKhoan}, Số dư: {SoDu}");
}

// Bài 19: Lớp quản lý điện thoại
class DienThoai
{
    public string Ten { get; set; }
    public string Hang { get; set; }

    public void Goi() => Console.WriteLine("Đang gọi...");
    public void NhanTin() => Console.WriteLine("Đang nhắn tin...");
}

// Bài 20: Quản lý đơn hàng
class DonHang
{
    public string MaDon { get; set; }
    public List<SanPham> SanPhams { get; set; } = new List<SanPham>();

    public double TinhTongTien() => SanPhams.Sum(sp => sp.Gia);
}

// Bài 21: Lớp quản lý lịch hẹn
class LichHen
{
    public string NoiDung { get; set; }
    public DateTime ThoiGian { get; set; }

    public void HienThi() => Console.WriteLine($"Lịch hẹn: {NoiDung}, Thời gian: {ThoiGian}");
}

// Bài 22: Lớp người kế thừa bởi học sinh và giáo viên
class Nguoi
{
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
}

class HocSinh : Nguoi
{
    public string Lop { get; set; }
}

class GiaoVien : Nguoi
{
    public string MonDay { get; set; }
}

