using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ComputerStore.DAL
{
    public class SanPhamRepository
    {
        private readonly string _connectionString;

        // Constructor nhận chuỗi kết nối từ DatabaseHelper hoặc file cấu hình
        public SanPhamRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Thêm một sản phẩm mới vào CSDL
        /// </summary>
        /// <param name="sanPham">Đối tượng sản phẩm cần thêm</param>
        public void AddProduct(Models.SanPham sanPham)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO SanPham (TenSP, MaLoai, GiaBan, SoLuongTon) VALUES (@TenSP, @MaLoai, @GiaBan, @SoLuongTon)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenSP", sanPham.TenSP);
                        cmd.Parameters.AddWithValue("@MaLoai", sanPham.MaLoai);
                        cmd.Parameters.AddWithValue("@GiaBan", sanPham.GiaBan);
                        cmd.Parameters.AddWithValue("@SoLuongTon", sanPham.SoLuongTon);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        /// <summary>
        /// Lấy danh sách tất cả các sản phẩm từ CSDL
        /// </summary>
        /// <returns>Danh sách các đối tượng SanPham</returns>
        public List<Models.SanPham> GetAllProducts()
        {
            List<Models.SanPham> products = new List<Models.SanPham>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaSP, TenSP, MaLoai, GiaBan, SoLuongTon FROM SanPham";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(new Models.SanPham
                                {
                                    MaSP = Convert.ToInt32(reader["MaSP"]),
                                    TenSP = reader["TenSP"].ToString(),
                                    MaLoai = Convert.ToInt32(reader["MaLoai"]),
                                    GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                                    SoLuongTon = Convert.ToInt32(reader["SoLuongTon"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách sản phẩm: " + ex.Message);
            }

            return products;
        }

        /// <summary>
        /// Cập nhật thông tin của một sản phẩm
        /// </summary>
        /// <param name="sanPham">Đối tượng sản phẩm cần cập nhật</param>
        public void UpdateProduct(Models.SanPham sanPham)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "UPDATE SanPham SET TenSP = @TenSP, MaLoai = @MaLoai, GiaBan = @GiaBan, SoLuongTon = @SoLuongTon WHERE MaSP = @MaSP";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSP", sanPham.MaSP);
                        cmd.Parameters.AddWithValue("@TenSP", sanPham.TenSP);
                        cmd.Parameters.AddWithValue("@MaLoai", sanPham.MaLoai);
                        cmd.Parameters.AddWithValue("@GiaBan", sanPham.GiaBan);
                        cmd.Parameters.AddWithValue("@SoLuongTon", sanPham.SoLuongTon);
                        cmd.ExecuteNonQuery();
                    }
                }
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
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSP", maSP);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa sản phẩm: " + ex.Message);
            }
        }
    }
}