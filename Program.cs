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

