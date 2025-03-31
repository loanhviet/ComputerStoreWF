using System;
using System.Collections.Generic;
using ComputerStore.DAL;
using ComputerStore.Models;

namespace ComputerStore.BLL
{
    public class SanPhamService
    {
        private readonly SanPhamRepository _repository;

        // Constructor nhận chuỗi kết nối từ DatabaseHelper hoặc file cấu hình
        public SanPhamService(string connectionString)
        {
            _repository = new SanPhamRepository(connectionString);
        }

        /// <summary>
        /// Thêm một sản phẩm mới
        /// </summary>
        /// <param name="sanPham">Đối tượng sản phẩm cần thêm</param>
        public void AddProduct(SanPham sanPham)
        {
            if (sanPham == null)
            {
                throw new ArgumentNullException("Thông tin sản phẩm không được để trống!");
            }

            if (string.IsNullOrEmpty(sanPham.TenSP))
            {
                throw new ArgumentException("Tên sản phẩm không được để trống!");
            }

            if (sanPham.GiaBan <= 0)
            {
                throw new ArgumentException("Giá bán phải lớn hơn 0!");
            }

            if (sanPham.SoLuongTon < 0)
            {
                throw new ArgumentException("Số lượng tồn không hợp lệ!");
            }

            try
            {
                _repository.AddProduct(sanPham);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        /// <summary>
        /// Lấy danh sách tất cả các sản phẩm
        /// </summary>
        /// <returns>Danh sách các đối tượng SanPham</returns>
        public List<SanPham> GetAllProducts()
        {
            try
            {
                return _repository.GetAllProducts();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách sản phẩm: " + ex.Message);
            }
        }

        /// <summary>
        /// Cập nhật thông tin của một sản phẩm
        /// </summary>
        /// <param name="sanPham">Đối tượng sản phẩm cần cập nhật</param>
        public void UpdateProduct(SanPham sanPham)
        {
            if (sanPham == null)
            {
                throw new ArgumentNullException("Thông tin sản phẩm không được để trống!");
            }

            if (string.IsNullOrEmpty(sanPham.TenSP))
            {
                throw new ArgumentException("Tên sản phẩm không được để trống!");
            }

            if (sanPham.GiaBan <= 0)
            {
                throw new ArgumentException("Giá bán phải lớn hơn 0!");
            }

            if (sanPham.SoLuongTon < 0)
            {
                throw new ArgumentException("Số lượng tồn không hợp lệ!");
            }

            try
            {
                _repository.UpdateProduct(sanPham);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật sản phẩm: " + ex.Message);
            }
        }

        /// <summary>
        /// Xóa một sản phẩm khỏi CSDL
        /// </summary>
        /// <param name="maSP">Mã sản phẩm cần xóa</param>
        public void DeleteProduct(int maSP)
        {
            if (maSP <= 0)
            {
                throw new ArgumentException("Mã sản phẩm không hợp lệ!");
            }

            try
            {
                _repository.DeleteProduct(maSP);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa sản phẩm: " + ex.Message);
            }
        }
    }
}