using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ComputerStore.Models;

namespace ComputerStore.DAL
{
    public class LoaiSanPhamRepository
    {
        private readonly string _connectionString;

        // Constructor nhận chuỗi kết nối từ DatabaseHelper hoặc file cấu hình
        public LoaiSanPhamRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Thêm một loại sản phẩm mới vào CSDL
        /// </summary>
        /// <param name="tenLoai">Tên loại sản phẩm</param>
        public void AddCategory(string tenLoai)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO LoaiSanPham (TenLoai) VALUES (@TenLoai)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenLoai", tenLoai);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm loại sản phẩm: " + ex.Message);
            }
        }

        /// <summary>
        /// Lấy danh sách tất cả các loại sản phẩm từ CSDL
        /// </summary>
        /// <returns>Danh sách các loại sản phẩm</returns>
        public List<LoaiSanPham> GetAllCategories()
        {
            List<LoaiSanPham> categories = new List<LoaiSanPham>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaLoai, TenLoai FROM LoaiSanPham";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                categories.Add(new LoaiSanPham
                                {
                                    MaLoai = Convert.ToInt32(reader["MaLoai"]),
                                    TenLoai = reader["TenLoai"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách loại sản phẩm: " + ex.Message);
            }

            return categories;
        }

        /// <summary>
        /// Cập nhật thông tin của một loại sản phẩm
        /// </summary>
        /// <param name="maLoai">Mã loại sản phẩm cần cập nhật</param>
        /// <param name="tenLoaiMoi">Tên loại sản phẩm mới</param>
        public void UpdateCategory(int maLoai, string tenLoaiMoi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "UPDATE LoaiSanPham SET TenLoai = @TenLoai WHERE MaLoai = @MaLoai";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                        cmd.Parameters.AddWithValue("@TenLoai", tenLoaiMoi);
                        cmd.ExecuteNonQuery();
                    }
                }
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
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM LoaiSanPham WHERE MaLoai = @MaLoai";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa loại sản phẩm: " + ex.Message);
            }
        }
    }
}