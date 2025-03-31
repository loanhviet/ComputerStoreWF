using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ComputerStore.DAL
{
    public class HoaDonRepository
    {
        private readonly string _connectionString;

        public HoaDonRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Thêm hóa đơn vào CSDL
        public int AddHoaDon(Models.HoaDon hoaDon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO HoaDon (NgayLap, TenKhachHang, TongTien) OUTPUT INSERTED.MaHD VALUES (@NgayLap, @TenKhachHang, @TongTien)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NgayLap", hoaDon.NgayLap);
                        cmd.Parameters.AddWithValue("@TenKhachHang", hoaDon.TenKhachHang);
                        cmd.Parameters.AddWithValue("@TongTien", hoaDon.TongTien);
                        return (int)cmd.ExecuteScalar(); // Trả về MaHD vừa thêm
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm hóa đơn: " + ex.Message);
            }
        }

        // Thêm chi tiết hóa đơn vào CSDL
        public void AddChiTietHoaDon(Models.ChiTietHoaDon chiTietHoaDon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", chiTietHoaDon.MaHD);
                        cmd.Parameters.AddWithValue("@MaSP", chiTietHoaDon.MaSP);
                        cmd.Parameters.AddWithValue("@SoLuong", chiTietHoaDon.SoLuong);
                        cmd.Parameters.AddWithValue("@DonGia", chiTietHoaDon.DonGia);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm chi tiết hóa đơn: " + ex.Message);
            }
        }

        // Lấy danh sách hóa đơn
        public List<Models.HoaDon> GetAllHoaDons()
        {
            List<Models.HoaDon> hoaDons = new List<Models.HoaDon>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaHD, NgayLap, TenKhachHang, TongTien FROM HoaDon";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                hoaDons.Add(new Models.HoaDon
                                {
                                    MaHD = Convert.ToInt32(reader["MaHD"]),
                                    NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                                    TenKhachHang = reader["TenKhachHang"].ToString(),
                                    TongTien = Convert.ToDecimal(reader["TongTien"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách hóa đơn: " + ex.Message);
            }

            return hoaDons;
        }
    }
}