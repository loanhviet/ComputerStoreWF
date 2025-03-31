using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    public class SanPham
    {

        
        public SanPham(int maSP, string tenSP, int maLoai, decimal giaBan, int soLuongTon)
        {
            MaSP = maSP;
            TenSP = tenSP;
            MaLoai = maLoai;
            GiaBan = giaBan;
            SoLuongTon = soLuongTon;
        }

        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int MaLoai { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }

        public SanPham() { }

    }

}
