using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai2_2
{
    internal class LichChieuPhim : Video
    {
        public string NgayChieu {  get; set; }
        public string XuatChieu { get; set; }
        public string GioBatDau {  get; set; }
        public string GioKetThuc { get; set; }
        public double GiaVe { get; set; }

        public LichChieuPhim(string tenPhim, string theLoai, string daoDien, string namChinh, string nuChinh, int namSx, string hangSx, string ngayChieu, string xuatChieu, string gioBatDau, string gioKetThuc, double giaVe)
            : base(tenPhim, theLoai, daoDien, namChinh, nuChinh, namSx, hangSx)
        {
            NgayChieu = ngayChieu;
            XuatChieu = xuatChieu;
            GioBatDau = gioBatDau;
            GioKetThuc = gioKetThuc;
            GiaVe = giaVe;
        }

        public void GiamGiaVe()
        {
            if (NgayChieu == "Thu 4" || NgayChieu == "Thu 5")
            {
                GiaVe *= 0.5;
            }
        }

        public override string ToString()
        {
            return $"Ten Phim: {TenPhim}, The loai: {TheLoai}, Dao Dien: {DaoDien}, Nam Chinh: {NamChinh}, Nu Chinh: {NuChinh}, Nam San Xuat: {NamSx}, Hang San Xuat: {HangSx}, Ngay: {NgayChieu}, Xuat: {XuatChieu}, Bat Dau: {GioBatDau}, Ket thuc: {GioKetThuc}, Gia Ve: {GiaVe}";
        }
    }
}
