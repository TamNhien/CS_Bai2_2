using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai2_2
{
    internal class Video
    {
        public string TenPhim { get; set; }
        public string TheLoai { get; set; }
        public string DaoDien {  get; set; }
        public string NamChinh { get; set; }
        public string NuChinh { get; set; }
        public int NamSx { get; set; }
        public string HangSx { get; set; }

        public Video(string tenPhim, string theLoai, string daoDien, string namChinh, string nuChinh, int namSx, string hangSx)
        {
            TenPhim = tenPhim;
            TheLoai = theLoai;
            DaoDien = daoDien;
            NamChinh = namChinh;
            NuChinh = nuChinh;
            NamSx = namSx;
            HangSx = hangSx;
        }
    }
}
