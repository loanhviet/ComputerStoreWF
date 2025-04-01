using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    public class ThongKe
    {
        public ThongKe()
        {
        }

        public ThongKe(string tenLoaiSanPham, int soLuongBan, decimal tongDoanhThu)
        {
            TenLoaiSanPham = tenLoaiSanPham;
            SoLuongBan = soLuongBan;
            TongDoanhThu = tongDoanhThu;
        }

        public string TenLoaiSanPham { get; set; }
        public int SoLuongBan { get; set; }
        public decimal TongDoanhThu { get; set; }
    }
}
