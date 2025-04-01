using System;
using System.Collections.Generic;
using ComputerStore.DAL;
using ComputerStore.Models;

namespace ComputerStore.BLL
{
    public class LoaiSanPhamService
    {
        private readonly LoaiSanPhamRepository _repository;

        // Constructor nhận chuỗi kết nối từ DatabaseHelper hoặc file cấu hình
        public LoaiSanPhamService(string connectionString)
        {
            _repository = new LoaiSanPhamRepository(connectionString);
        }

        /// <summary>
        /// Thêm một loại sản phẩm mới
        /// </summary>
        /// <param name="tenLoai">Tên loại sản phẩm</param>
        public void AddCategory(string tenLoai)
        {
            if (string.IsNullOrEmpty(tenLoai))
            {
                throw new ArgumentException("Tên loại sản phẩm không được để trống!");
            }

            try
            {
                _repository.AddCategory(tenLoai);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm loại sản phẩm: " + ex.Message);
            }
        }

        /// <summary>
        /// Lấy danh sách tất cả các loại sản phẩm
        /// </summary>
        /// <returns>Danh sách các đối tượng LoaiSanPham</returns>
        public List<LoaiSanPham> GetAllCategories()
        {
            try
            {
                return _repository.GetAllCategories();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách loại sản phẩm: " + ex.Message);
            }
        }

        /// <summary>
        /// Cập nhật thông tin của một loại sản phẩm
        /// </summary>
        /// <param name="maLoai">Mã loại sản phẩm cần cập nhật</param>
        /// <param name="tenLoaiMoi">Tên loại sản phẩm mới</param>
        public void UpdateCategory(int maLoai, string tenLoaiMoi)
        {
            if (string.IsNullOrEmpty(tenLoaiMoi))
            {
                throw new ArgumentException("Tên loại sản phẩm không được để trống!");
            }

            try
            {
                _repository.UpdateCategory(maLoai, tenLoaiMoi);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật loại sản phẩm: " + ex.Message);
            }
        }

        /// <summary>
        /// Xóa một loại sản phẩm khỏi CSDL
        /// </summary>
        /// <param name="maLoai">Mã loại sản phẩm cần xóa</param>
        public void DeleteCategory(int maLoai)
        {
            try
            {
                _repository.DeleteCategory(maLoai);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa loại sản phẩm: " + ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm các loại sản phẩm theo từ khóa
        /// </summary>
        /// <param name="keyword">Từ khóa tìm kiếm</param>
        /// <returns>Danh sách các loại sản phẩm phù hợp</returns>
        public List<LoaiSanPham> SearchCategories(string keyword)
        {
            return _repository.SearchCategories(keyword);
        }
    }
}