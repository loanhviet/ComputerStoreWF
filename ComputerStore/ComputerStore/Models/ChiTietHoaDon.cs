using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    public class ChiTietHoaDon
    {
        public ChiTietHoaDon()
        {
        }

        public ChiTietHoaDon(int maCTHD, int maHD, int maSP, int soLuong, decimal donGia)
        {
            MaCTHD = maCTHD;
            MaHD = maHD;
            MaSP = maSP;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public int MaCTHD { get; set; }
        public int MaHD { get; set; }
        public int MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}
