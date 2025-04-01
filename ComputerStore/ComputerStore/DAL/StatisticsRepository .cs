using System;
using System.Collections.Generic;
using System.Data.SqlClient;
// using System.Linq; // Không cần thiết nếu không dùng LINQ
// using System.Text; // Không cần thiết
// using System.Threading.Tasks; // Không cần thiết
using ComputerStore.Models;

namespace ComputerStore.DAL
{
    public class StatisticsRepository
    {
        private readonly string _connectionString;

        public StatisticsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Lấy doanh thu theo loại sản phẩm và khoảng thời gian
        /// </summary>
        public List<ThongKe> GetRevenueByCategory(int maLoai, DateTime fromDate, DateTime toDate)
        {
            List<ThongKe> statistics = new List<ThongKe>();
            // --- SỬA CÂU QUERY Ở ĐÂY ---
            string query = @"
                SELECT
                    lsp.TenLoai,
                    SUM(cthd.SoLuong) AS SoLuongBan,
                    SUM(cthd.SoLuong * cthd.DonGia) AS TongDoanhThu
                FROM
                    ChiTietHoaDon cthd       -- Bắt đầu từ ChiTietHoaDon
                INNER JOIN
                    HoaDon hd ON cthd.MaHD = hd.MaHD -- JOIN HoaDon để lấy NgayLap
                INNER JOIN
                    SanPham sp ON cthd.MaSP = sp.MaSP -- JOIN SanPham để lấy MaLoai
                INNER JOIN
                    LoaiSanPham lsp ON sp.MaLoai = lsp.MaLoai -- JOIN LoaiSanPham để lấy TenLoai
                WHERE
                    sp.MaLoai = @MaLoai              -- Lọc theo MaLoai từ bảng SanPham
                    AND hd.NgayLap BETWEEN @FromDate AND @ToDate -- Lọc theo ngày từ bảng HoaDon
                GROUP BY
                    lsp.TenLoai";
            // --- KẾT THÚC SỬA QUERY ---

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                        // Đảm bảo fromDate và toDate bao gồm cả ngày bắt đầu và kết thúc
                        // Nếu NgayLap lưu cả giờ, cần xử lý cẩn thận hơn
                        cmd.Parameters.AddWithValue("@FromDate", fromDate.Date); // Chỉ lấy phần ngày
                        cmd.Parameters.AddWithValue("@ToDate", toDate.Date.AddDays(1).AddTicks(-1)); // Lấy đến cuối ngày kết thúc

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                statistics.Add(new ThongKe
                                {
                                    TenLoaiSanPham = reader["TenLoai"].ToString(),
                                    // Kiểm tra DBNull trước khi convert
                                    SoLuongBan = reader["SoLuongBan"] != DBNull.Value ? Convert.ToInt32(reader["SoLuongBan"]) : 0,
                                    TongDoanhThu = reader["TongDoanhThu"] != DBNull.Value ? Convert.ToDecimal(reader["TongDoanhThu"]) : 0m
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Nên ghi log chi tiết lỗi ở đây
                throw new Exception("Lỗi khi lấy thống kê doanh thu theo loại: " + ex.Message, ex);
            }

            return statistics;
        }

        /// <summary>
        /// Lấy doanh thu theo khoảng thời gian (gom nhóm theo từng loại sản phẩm)
        /// </summary>
        public List<ThongKe> GetRevenueByDate(DateTime fromDate, DateTime toDate)
        {
            List<ThongKe> statistics = new List<ThongKe>();
            // --- SỬA CÂU QUERY Ở ĐÂY ---
            string query = @"
                SELECT
                    lsp.TenLoai,
                    SUM(cthd.SoLuong) AS SoLuongBan,
                    SUM(cthd.SoLuong * cthd.DonGia) AS TongDoanhThu
                FROM
                    ChiTietHoaDon cthd       -- Bắt đầu từ ChiTietHoaDon
                INNER JOIN
                    HoaDon hd ON cthd.MaHD = hd.MaHD -- JOIN HoaDon để lấy NgayLap
                INNER JOIN
                    SanPham sp ON cthd.MaSP = sp.MaSP -- JOIN SanPham để lấy MaLoai
                INNER JOIN
                    LoaiSanPham lsp ON sp.MaLoai = lsp.MaLoai -- JOIN LoaiSanPham để lấy TenLoai
                WHERE
                    hd.NgayLap BETWEEN @FromDate AND @ToDate -- Chỉ lọc theo ngày từ bảng HoaDon
                GROUP BY
                    lsp.TenLoai
                ORDER BY -- Thêm sắp xếp để kết quả dễ nhìn hơn (tùy chọn)
                    lsp.TenLoai";
            // --- KẾT THÚC SỬA QUERY ---

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Đảm bảo fromDate và toDate bao gồm cả ngày bắt đầu và kết thúc
                        cmd.Parameters.AddWithValue("@FromDate", fromDate.Date); // Chỉ lấy phần ngày
                        cmd.Parameters.AddWithValue("@ToDate", toDate.Date.AddDays(1).AddTicks(-1)); // Lấy đến cuối ngày kết thúc

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                statistics.Add(new ThongKe
                                {
                                    TenLoaiSanPham = reader["TenLoai"].ToString(),
                                    // Kiểm tra DBNull trước khi convert
                                    SoLuongBan = reader["SoLuongBan"] != DBNull.Value ? Convert.ToInt32(reader["SoLuongBan"]) : 0,
                                    TongDoanhThu = reader["TongDoanhThu"] != DBNull.Value ? Convert.ToDecimal(reader["TongDoanhThu"]) : 0m
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Nên ghi log chi tiết lỗi ở đây
                throw new Exception("Lỗi khi lấy thống kê doanh thu theo ngày: " + ex.Message, ex);
            }

            return statistics;
        }
    }
}