using System;
using System.Collections.Generic;
using ComputerStore.DAL;
using ComputerStore.Models;

namespace ComputerStore.BLL
{
    public class HoaDonService
    {
        private readonly HoaDonRepository _repository;

        public HoaDonService(string connectionString)
        {
            _repository = new HoaDonRepository(connectionString);
        }

        // Thêm hóa đơn
        public int AddHoaDon(HoaDon hoaDon)
        {
            if (string.IsNullOrEmpty(hoaDon.TenKhachHang))
            {
                throw new ArgumentException("Tên khách hàng không được để trống!");
            }

            if (hoaDon.TongTien <= 0)
            {
                throw new ArgumentException("Tổng tiền phải lớn hơn 0!");
            }

            return _repository.AddHoaDon(hoaDon);
        }

        // Thêm chi tiết hóa đơn
        public void AddChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            if (chiTietHoaDon.MaHD <= 0)
            {
                throw new ArgumentException("Mã hóa đơn không hợp lệ!");
            }

            if (chiTietHoaDon.MaSP <= 0)
            {
                throw new ArgumentException("Mã sản phẩm không hợp lệ!");
            }

            if (chiTietHoaDon.SoLuong <= 0)
            {
                throw new ArgumentException("Số lượng phải lớn hơn 0!");
            }

            if (chiTietHoaDon.DonGia <= 0)
            {
                throw new ArgumentException("Đơn giá phải lớn hơn 0!");
            }

            _repository.AddChiTietHoaDon(chiTietHoaDon);
        }

        // Lấy danh sách hóa đơn
        public List<HoaDon> GetAllHoaDons()
        {
            return _repository.GetAllHoaDons();
        }
    }
}