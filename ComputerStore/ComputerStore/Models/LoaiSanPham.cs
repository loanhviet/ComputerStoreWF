using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    public class LoaiSanPham
    {
        public LoaiSanPham()
        {
        }

        public LoaiSanPham(int maLoai, string tenLoai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
    }
}
