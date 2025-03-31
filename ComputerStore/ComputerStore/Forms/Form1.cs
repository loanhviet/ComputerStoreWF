using System.Data;
using System.Data.SqlClient;
using ComputerStore.BLL;
using ComputerStore.BLL;
using ComputerStore.DAL;
using ComputerStore.Models;
namespace ComputerStore
{
    public partial class Form1 : Form
    {
        private readonly LoaiSanPhamService _loaiSanPhamService;
        private readonly SanPhamService _sanPhamService;
        private readonly HoaDonService _hoaDonService;
        private List<Models.ChiTietHoaDon> _chiTietHoaDons = new List<Models.ChiTietHoaDon>();
        private decimal _tongTien = 0;
        public Form1()
        {
            InitializeComponent();
            string connectionString = DatabaseHelper.GetConnection().ConnectionString;
            _loaiSanPhamService = new LoaiSanPhamService(connectionString);
            _sanPhamService = new SanPhamService(connectionString);
            _hoaDonService = new HoaDonService(connectionString);
        }
        private void LoadCategories()
        {
            try
            {
                var categories = _loaiSanPhamService.GetAllCategories();
                dtvgCategory.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm: " + ex.Message);
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtNameCategory.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm!");
                return;
            }

            try
            {
                _loaiSanPhamService.AddCategory(categoryName);
                MessageBox.Show("Thêm loại sản phẩm thành công!");

                // Tải lại danh sách loại sản phẩm
                LoadCategories();
                LoadCategoriesToComboBox();
                ClearInputCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
            LoadCategoriesToComboBox();
            LoadProductsToComboBox();
        }
        private void LoadCategoriesToComboBox()
        {
            try
            {
                var categories = _loaiSanPhamService.GetAllCategories();
                comboBoxLoaiSanPham.DataSource = categories;
                comboBoxLoaiSanPham.DisplayMember = "TenLoai"; // Hiển thị tên loại
                comboBoxLoaiSanPham.ValueMember = "MaLoai";   // Giá trị là mã loại
                comboBoxLoaiSanPham.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm cho ComboBox: " + ex.Message);
            }
        }

        private void dtvgCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dtvgCategory.Rows[e.RowIndex];

                // Lấy giá trị cột "TenLoai" (tên loại sản phẩm) và gán vào TextBox
                string tenLoai = selectedRow.Cells["TenLoai"].Value?.ToString();
                txtNameCategory.Text = tenLoai;
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (dtvgCategory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một loại sản phẩm để sửa!");
                return;
            }

            // Lấy mã loại sản phẩm từ dòng được chọn
            int maLoai = Convert.ToInt32(dtvgCategory.SelectedRows[0].Cells["MaLoai"].Value);
            string tenLoaiMoi = txtNameCategory.Text.Trim();

            if (string.IsNullOrEmpty(tenLoaiMoi))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm mới!");
                return;
            }

            try
            {
                _loaiSanPhamService.UpdateCategory(maLoai, tenLoaiMoi);
                MessageBox.Show("Cập nhật loại sản phẩm thành công!");

                // Tải lại danh sách loại sản phẩm
                LoadCategories();
                ClearInputCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void ClearInputCategory()
        {

            txtNameCategory.Clear();

            // Nếu có ComboBox hoặc các control khác, cũng có thể reset chúng
            // comboBoxLoaiSanPham.SelectedIndex = -1;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dtvgCategory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một loại sản phẩm để xóa!");
                return;
            }


            int maLoai = Convert.ToInt32(dtvgCategory.SelectedRows[0].Cells["MaLoai"].Value);

            try
            {

                _loaiSanPhamService.DeleteCategory(maLoai);
                MessageBox.Show("Xóa loại sản phẩm thành công!");


                LoadCategories();


                ClearInputCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadProducts()
        {
            try
            {
                var service = new SanPhamService(DatabaseHelper.GetConnection().ConnectionString);
                var products = service.GetAllProducts();
                dtvgProduct.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string tenSP = txtProductName.Text.Trim();
            decimal giaBan;
            int soLuongTon;
            int maLoai;


            if (string.IsNullOrEmpty(tenSP))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!");
                return;
            }

            if (!decimal.TryParse(txtProductGiaBan.Text, out giaBan) || giaBan <= 0)
            {
                MessageBox.Show("Giá bán không hợp lệ!");
                return;
            }

            if (!int.TryParse(numericUpDownSoLuongTon.Value.ToString(), out soLuongTon) || soLuongTon < 0)
            {
                MessageBox.Show("Số lượng tồn không hợp lệ!");
                return;
            }

            if (comboBoxLoaiSanPham.SelectedValue == null || !int.TryParse(comboBoxLoaiSanPham.SelectedValue.ToString(), out maLoai))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm!");
                return;
            }

            try
            {
                var service = new SanPhamService(DatabaseHelper.GetConnection().ConnectionString);
                service.AddProduct(new Models.SanPham
                {
                    TenSP = tenSP,
                    MaLoai = maLoai,
                    GiaBan = giaBan,
                    SoLuongTon = soLuongTon
                });

                MessageBox.Show("Thêm sản phẩm thành công!");


                LoadProducts();
                LoadProductsToComboBox();
                ClearInputProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void ClearInputProduct()
        {
            txtProductName.Clear();
            txtProductGiaBan.Clear();
            numericUpDownSoLuongTon.Value = 0;
            comboBoxLoaiSanPham.SelectedIndex = -1;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dtvgProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa!");
                return;
            }

            int maSP = Convert.ToInt32(dtvgProduct.SelectedRows[0].Cells["MaSP"].Value);
            string tenSP = txtProductName.Text.Trim();
            decimal giaBan;
            int soLuongTon;
            int maLoai;


            if (string.IsNullOrEmpty(tenSP))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!");
                return;
            }

            if (!decimal.TryParse(txtProductGiaBan.Text, out giaBan) || giaBan <= 0)
            {
                MessageBox.Show("Giá bán không hợp lệ!");
                return;
            }

            if (!int.TryParse(numericUpDownSoLuongTon.Value.ToString(), out soLuongTon) || soLuongTon < 0)
            {
                MessageBox.Show("Số lượng tồn không hợp lệ!");
                return;
            }

            if (comboBoxLoaiSanPham.SelectedValue == null || !int.TryParse(comboBoxLoaiSanPham.SelectedValue.ToString(), out maLoai))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm!");
                return;
            }

            try
            {
                var product = new Models.SanPham
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    GiaBan = giaBan,
                    SoLuongTon = soLuongTon,
                    MaLoai = maLoai
                };

                _sanPhamService.UpdateProduct(product);
                MessageBox.Show("Cập nhật sản phẩm thành công!");


                LoadProducts();


                ClearInputProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dtvgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = dtvgProduct.Rows[e.RowIndex];


                txtProductName.Text = selectedRow.Cells["TenSP"].Value?.ToString();
                txtProductGiaBan.Text = selectedRow.Cells["GiaBan"].Value?.ToString();
                numericUpDownSoLuongTon.Value = Convert.ToInt32(selectedRow.Cells["SoLuongTon"].Value);
                comboBoxLoaiSanPham.SelectedValue = Convert.ToInt32(selectedRow.Cells["MaLoai"].Value);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dtvgProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!");
                return;
            }

            int maSP = Convert.ToInt32(dtvgProduct.SelectedRows[0].Cells["MaSP"].Value);

            try
            {
                _sanPhamService.DeleteProduct(maSP);
                MessageBox.Show("Xóa sản phẩm thành công!");

                LoadProducts();
                ClearInputProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ClearHoaDon()
        {

            txtHoaDonTenKhachHang.Clear();
            dtpkHoaDonNgayLapHoaDon.Value = DateTime.Now;
            numericUpDownHoaDonSoLuong.Value = 0;
            txtHoaDonDonGia.Clear();


            _chiTietHoaDons.Clear();
            _tongTien = 0;
            txtTongTien.Clear();


            dtgvHoaDon.DataSource = null;


            cbbHoaDonProduct.SelectedIndex = -1;
        }

        private void LoadProductsToComboBox()
        {
            try
            {
                var products = _sanPhamService.GetAllProducts();
                cbbHoaDonProduct.DataSource = products;
                cbbHoaDonProduct.DisplayMember = "TenSP";
                cbbHoaDonProduct.ValueMember = "MaSP";
                cbbHoaDonProduct.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message);
            }
        }

        private void btnThemVaoHoaDon_Click(object sender, EventArgs e)
        {
            if (cbbHoaDonProduct.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }

            int maSP = Convert.ToInt32(cbbHoaDonProduct.SelectedValue); // Lấy mã sản phẩm
            string tenSP = cbbHoaDonProduct.Text;                      // Tên sản phẩm
            int soLuong = (int)numericUpDownHoaDonSoLuong.Value;       // Số lượng
            decimal donGia = Convert.ToDecimal(txtHoaDonDonGia.Text);   // Đơn giá

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            // Tìm sản phẩm trong danh sách đã tải từ CSDL
            var product = _sanPhamService.GetAllProducts().FirstOrDefault(p => p.MaSP == maSP);
            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!");
                return;
            }

            // Kiểm tra số lượng tồn
            if (product.SoLuongTon < soLuong)
            {
                MessageBox.Show($"Số lượng tồn không đủ! Chỉ còn {product.SoLuongTon} sản phẩm.");
                return;
            }

            // Giảm số lượng tồn tạm thời
            product.SoLuongTon -= soLuong;

            // Thêm sản phẩm vào danh sách chi tiết hóa đơn
            var existingItem = _chiTietHoaDons.FirstOrDefault(ct => ct.MaSP == maSP);
            if (existingItem != null)
            {
                existingItem.SoLuong += soLuong;
            }
            else
            {
                _chiTietHoaDons.Add(new Models.ChiTietHoaDon
                {
                    MaSP = maSP,
                    SoLuong = soLuong,
                    DonGia = donGia
                });
            }

            // Cập nhật tổng tiền
            _tongTien += soLuong * donGia;
            txtTongTien.Text = _tongTien.ToString();

            // Cập nhật DataGridView
            dtgvHoaDon.DataSource = null;
            dtgvHoaDon.DataSource = _chiTietHoaDons;
            

            // Xóa dữ liệu nhập
            numericUpDownHoaDonSoLuong.Value = 0;
            txtHoaDonDonGia.Clear();
        }

        private void btnHoanTatHoaDon_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txtHoaDonTenKhachHang.Text.Trim();
            DateTime ngayLap = dtpkHoaDonNgayLapHoaDon.Value;

            if (string.IsNullOrEmpty(tenKhachHang))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                return;
            }

            if (_chiTietHoaDons.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào hóa đơn!");
                return;
            }

            try
            {
                // Thêm hóa đơn vào CSDL
                var hoaDon = new Models.HoaDon
                {
                    TenKhachHang = tenKhachHang,
                    NgayLap = ngayLap,
                    TongTien = _tongTien
                };

                int maHoaDon = _hoaDonService.AddHoaDon(hoaDon);

                // Thêm chi tiết hóa đơn và cập nhật số lượng tồn
                foreach (var chiTiet in _chiTietHoaDons)
                {
                    chiTiet.MaHD = maHoaDon;
                    _hoaDonService.AddChiTietHoaDon(chiTiet);

                    // Cập nhật số lượng tồn trong CSDL
                    UpdateSoLuongTon(chiTiet.MaSP, chiTiet.SoLuong);
                    
                }

                MessageBox.Show("Hoàn tất hóa đơn thành công!");
                LoadProducts();
                LoadProductsToComboBox();
                

                // Reset dữ liệu hóa đơn
                ClearHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void UpdateSoLuongTon(int maSP, int soLuongBan)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE SanPham SET SoLuongTon = SoLuongTon - @SoLuongBan WHERE MaSP = @MaSP";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSP", maSP);
                        cmd.Parameters.AddWithValue("@SoLuongBan", soLuongBan);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật số lượng tồn: " + ex.Message);
            }
        }
        

        private void cbbHoaDonProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedProduct = cbbHoaDonProduct.SelectedItem as Models.SanPham;


            if (selectedProduct == null)
            {
                txtHoaDonDonGia.Clear();
                return;
            }

            try
            {

                txtHoaDonDonGia.Text = selectedProduct.GiaBan.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi lấy thông tin giá sản phẩm: " + ex.Message);
                txtHoaDonDonGia.Clear();
            }
        }
    }
}
