using CS_Bai2_2;

public class Program
{
    static List<Video> movieList = new List<Video>();
    static List<LichChieuPhim> LichChieu = new List<LichChieuPhim>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Them 1 phim moi");
            Console.WriteLine("2. Tim phim theo the loai");
            Console.WriteLine("3. Tim phim theo the nam chinh");
            Console.WriteLine("4. Tim phim theo the dao dien");
            Console.WriteLine("5. Them lich chieu phim");
            Console.WriteLine("6. Liet ke tat ca lich chieu phim");
            Console.WriteLine("7. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ThemPhimMoi();
                    break;
                case 2:
                    TimPhimTheoTheLoai();
                    break;
                case 3:
                    TimPhimTheoDienVien();
                    break;
                case 4:
                    TimPhimTheoDaoDien();
                    break;
                case 5:
                    ThemLichChieuPhim();
                    break;
                case 6:
                    TatCaLichChieuPhim();
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void ThemPhimMoi()
    {
        Console.WriteLine("Nhap ten phim: ");
        string tenPhim = Console.ReadLine();

        Console.WriteLine("Nhap the loai (hinh su, hanh dong, tinh cam, hai): ");
        string theLoai = Console.ReadLine();

        Console.WriteLine("Nhap dao dien: ");
        string daoDien = Console.ReadLine();

        Console.WriteLine("Nhap nam chinh: ");
        string namChinh = Console.ReadLine();

        Console.WriteLine("Nhap nu chinh: ");
        string nuChinh = Console.ReadLine();

        Console.WriteLine("Nhap nam san xuat: ");
        int namSx = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap hang san xuat: ");
        string hangSx = Console.ReadLine();

        movieList.Add(new Video(tenPhim, theLoai, daoDien, namChinh, nuChinh, namSx, hangSx));
        Console.WriteLine("Them phim thanh cong.");
    }

    static void TimPhimTheoTheLoai()
    {
        Console.WriteLine("Nhap the loai: ");
        string theLoai = Console.ReadLine();

        var locphim = movieList.FindAll(movie => movie.TheLoai == theLoai);
        foreach (var movie in locphim)
        {
            Console.WriteLine($"Ten phim: {movie.TenPhim}, Dao dien: {movie.DaoDien}, Nam chinh: {movie.NamChinh}, Nu chinh: {movie.NuChinh}, Nam: {movie.NamSx}, Hang: {movie.HangSx}");
        }
    }

    static void TimPhimTheoDienVien()
    {
        Console.WriteLine("Nhap ten nam chinh: ");
        string namChinh = Console.ReadLine();

        var locphim = movieList.FindAll(movie => movie.NamChinh == namChinh);
        foreach (var movie in locphim)
        {
            Console.WriteLine($"Ten phim: {movie.TenPhim},The loai: {movie.TheLoai}, Dao dien: {movie.DaoDien}, Nu chinh: {movie.NuChinh}, Nam: {movie.NamSx}, Hang: {movie.HangSx}");
        }

    }

    static void TimPhimTheoDaoDien()
    {
        Console.WriteLine("Nhap ten dao dien: ");
        string daoDien = Console.ReadLine();

        var locphim = movieList.FindAll(movie => movie.DaoDien == daoDien);
        foreach (var movie in locphim)
        {
            Console.WriteLine($"Ten phim: {movie.TenPhim},The loai: {movie.TheLoai}, Nam chinh: {movie.NamChinh}, Nu chinh: {movie.NuChinh}, Nam: {movie.NamSx}, Hang: {movie.HangSx}");
        }
    }

    static void ThemLichChieuPhim()
    {
        Console.WriteLine("Nhap ten phim: ");
        string tenPhim = Console.ReadLine();

        var movie = movieList.Find(m =>  m.TenPhim == tenPhim);
        if (movie == null)
        {
            Console.WriteLine("Khong tim thay phim");
            return;
        }

        Console.WriteLine("Nhap ngay chieu (e.g., Monday, Tuesday, etc.): ");
        string ngayChieu = Console.ReadLine();

        Console.WriteLine("Nhap xuat chieu: ");
        string xuatChieu = Console.ReadLine();

        Console.WriteLine("Gio bat dau: ");
        string gioBatDau = Console.ReadLine();

        Console.WriteLine("Gio ket thuc: ");
        string gioKetThuc = Console.ReadLine();

        Console.WriteLine("Gia ve: ");
        double giaVe = double.Parse(Console.ReadLine());

        var lichChieu = new LichChieuPhim(movie.TenPhim, movie.TheLoai, movie.DaoDien, movie.NamChinh, movie.NuChinh, movie.NamSx, movie.HangSx, ngayChieu, xuatChieu, gioBatDau, gioKetThuc, giaVe);
        lichChieu.GiamGiaVe();

        LichChieu.Add(lichChieu);
        Console.WriteLine("Them danh sach phim thanh cong.");
    }

    static void TatCaLichChieuPhim()
    {
        foreach (var lichChieu in LichChieu)
        {
            Console.WriteLine(lichChieu);
        }
    }
}
