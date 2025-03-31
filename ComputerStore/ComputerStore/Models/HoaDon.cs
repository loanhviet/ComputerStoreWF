using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    public class HoaDon
    {
        public HoaDon()
        {
        }

        public HoaDon(int maHD, string tenKhachHang, DateTime ngayLap, decimal tongTien)
        {
            MaHD = maHD;
            TenKhachHang = tenKhachHang;
            NgayLap = ngayLap;
            TongTien = tongTien;
        }

        public int MaHD { get; set; }
        public string TenKhachHang { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
    }
}
