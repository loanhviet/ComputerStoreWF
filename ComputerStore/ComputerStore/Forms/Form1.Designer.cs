namespace ComputerStore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPageLoaiSanPham = new TabPage();
            panel4 = new Panel();
            txtSearchProduct = new TextBox();
            label23 = new Label();
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            numericUpDownSoLuongTon = new NumericUpDown();
            comboBoxLoaiSanPham = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtProductGiaBan = new TextBox();
            label6 = new Label();
            txtProductName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnAddProduct = new Button();
            dtvgProduct = new DataGridView();
            panel3 = new Panel();
            txtSearchCategory = new TextBox();
            btnDeleteCategory = new Button();
            label24 = new Label();
            btnUpdateCategory = new Button();
            txtNameCategory = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnAddCategory = new Button();
            dtvgCategory = new DataGridView();
            tabPageHoaDon = new TabPage();
            panel6 = new Panel();
            txtTongTien = new TextBox();
            label17 = new Label();
            dtgvHoaDon = new DataGridView();
            panel5 = new Panel();
            btnHoanTatHoaDon = new Button();
            label16 = new Label();
            btnThemVaoHoaDon = new Button();
            numericUpDownHoaDonSoLuong = new NumericUpDown();
            txtHoaDonDonGia = new TextBox();
            label15 = new Label();
            cbbHoaDonProduct = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            dtpkHoaDonNgayLapHoaDon = new DateTimePicker();
            label11 = new Label();
            txtHoaDonTenKhachHang = new TextBox();
            label10 = new Label();
            label9 = new Label();
            tabPageThongKe = new TabPage();
            dateTimePickerThongKeEnd = new DateTimePicker();
            label25 = new Label();
            label21 = new Label();
            panel7 = new Panel();
            txtTongDoanhThu = new TextBox();
            label22 = new Label();
            dtvgThongKe = new DataGridView();
            dateTimePickerThongKeStart = new DateTimePicker();
            cbbThongKe = new ComboBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            btnXemBaoCao = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageLoaiSanPham.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuongTon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvgProduct).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvgCategory).BeginInit();
            tabPageHoaDon.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHoaDon).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHoaDonSoLuong).BeginInit();
            tabPageThongKe.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvgThongKe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 22);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Cửa Hàng Máy Tính";
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 459);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageLoaiSanPham);
            tabControl1.Controls.Add(tabPageHoaDon);
            tabControl1.Controls.Add(tabPageThongKe);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(867, 459);
            tabControl1.TabIndex = 0;
            // 
            // tabPageLoaiSanPham
            // 
            tabPageLoaiSanPham.Controls.Add(panel4);
            tabPageLoaiSanPham.Controls.Add(panel3);
            tabPageLoaiSanPham.Location = new Point(4, 24);
            tabPageLoaiSanPham.Name = "tabPageLoaiSanPham";
            tabPageLoaiSanPham.Padding = new Padding(3);
            tabPageLoaiSanPham.Size = new Size(859, 431);
            tabPageLoaiSanPham.TabIndex = 0;
            tabPageLoaiSanPham.Text = "Loại sản phẩm";
            tabPageLoaiSanPham.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Linen;
            panel4.Controls.Add(txtSearchProduct);
            panel4.Controls.Add(label23);
            panel4.Controls.Add(btnDeleteProduct);
            panel4.Controls.Add(btnUpdateProduct);
            panel4.Controls.Add(numericUpDownSoLuongTon);
            panel4.Controls.Add(comboBoxLoaiSanPham);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtProductGiaBan);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtProductName);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(btnAddProduct);
            panel4.Controls.Add(dtvgProduct);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(336, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(520, 425);
            panel4.TabIndex = 1;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(384, 110);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(100, 23);
            txtSearchProduct.TabIndex = 19;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(334, 113);
            label23.Name = "label23";
            label23.Size = new Size(26, 15);
            label23.TabIndex = 18;
            label23.Text = "Lọc";
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(344, 71);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 17;
            btnDeleteProduct.Text = "Xóa";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(246, 112);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(75, 23);
            btnUpdateProduct.TabIndex = 16;
            btnUpdateProduct.Text = "Sửa";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // numericUpDownSoLuongTon
            // 
            numericUpDownSoLuongTon.Location = new Point(106, 114);
            numericUpDownSoLuongTon.Name = "numericUpDownSoLuongTon";
            numericUpDownSoLuongTon.Size = new Size(120, 23);
            numericUpDownSoLuongTon.TabIndex = 15;
            // 
            // comboBoxLoaiSanPham
            // 
            comboBoxLoaiSanPham.FormattingEnabled = true;
            comboBoxLoaiSanPham.Location = new Point(344, 37);
            comboBoxLoaiSanPham.Name = "comboBoxLoaiSanPham";
            comboBoxLoaiSanPham.Size = new Size(121, 23);
            comboBoxLoaiSanPham.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(246, 40);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 13;
            label8.Text = "Loại sản phẩm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 114);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 11;
            label7.Text = "Số lượng tồn";
            // 
            // txtProductGiaBan
            // 
            txtProductGiaBan.Location = new Point(106, 72);
            txtProductGiaBan.Name = "txtProductGiaBan";
            txtProductGiaBan.Size = new Size(120, 23);
            txtProductGiaBan.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 75);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 9;
            label6.Text = "Giá bán";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(106, 32);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(120, 23);
            txtProductName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(194, 12);
            label4.Name = "label4";
            label4.Size = new Size(136, 17);
            label4.TabIndex = 7;
            label4.Text = "Thông tin sản phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 35);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 6;
            label5.Text = "Tên sản phẩm";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(246, 67);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 5;
            btnAddProduct.Text = "Thêm";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dtvgProduct
            // 
            dtvgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgProduct.Dock = DockStyle.Bottom;
            dtvgProduct.Location = new Point(0, 155);
            dtvgProduct.Name = "dtvgProduct";
            dtvgProduct.ReadOnly = true;
            dtvgProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvgProduct.Size = new Size(520, 270);
            dtvgProduct.TabIndex = 1;
            dtvgProduct.CellClick += dtvgProduct_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Linen;
            panel3.Controls.Add(txtSearchCategory);
            panel3.Controls.Add(btnDeleteCategory);
            panel3.Controls.Add(label24);
            panel3.Controls.Add(btnUpdateCategory);
            panel3.Controls.Add(txtNameCategory);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnAddCategory);
            panel3.Controls.Add(dtvgCategory);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 425);
            panel3.TabIndex = 0;
            // 
            // txtSearchCategory
            // 
            txtSearchCategory.Location = new Point(93, 119);
            txtSearchCategory.Name = "txtSearchCategory";
            txtSearchCategory.Size = new Size(100, 23);
            txtSearchCategory.TabIndex = 21;
            txtSearchCategory.TextChanged += txtSearchCategory_TextChanged;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(206, 84);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(75, 23);
            btnDeleteCategory.TabIndex = 6;
            btnDeleteCategory.Text = "Xóa loại";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(43, 122);
            label24.Name = "label24";
            label24.Size = new Size(26, 15);
            label24.TabIndex = 20;
            label24.Text = "Lọc";
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Location = new Point(106, 84);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(75, 23);
            btnUpdateCategory.TabIndex = 5;
            btnUpdateCategory.Text = "Sửa loại";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // txtNameCategory
            // 
            txtNameCategory.Location = new Point(138, 40);
            txtNameCategory.Name = "txtNameCategory";
            txtNameCategory.Size = new Size(100, 23);
            txtNameCategory.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 16);
            label3.Name = "label3";
            label3.Size = new Size(102, 17);
            label3.TabIndex = 3;
            label3.Text = "Loại sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 45);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên loại mới";
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(25, 84);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(75, 23);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "Thêm loại";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // dtvgCategory
            // 
            dtvgCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgCategory.Dock = DockStyle.Bottom;
            dtvgCategory.Location = new Point(0, 155);
            dtvgCategory.Name = "dtvgCategory";
            dtvgCategory.ReadOnly = true;
            dtvgCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvgCategory.Size = new Size(327, 270);
            dtvgCategory.TabIndex = 0;
            dtvgCategory.CellClick += dtvgCategory_CellClick;
            // 
            // tabPageHoaDon
            // 
            tabPageHoaDon.Controls.Add(panel6);
            tabPageHoaDon.Controls.Add(panel5);
            tabPageHoaDon.Location = new Point(4, 24);
            tabPageHoaDon.Name = "tabPageHoaDon";
            tabPageHoaDon.Padding = new Padding(3);
            tabPageHoaDon.Size = new Size(859, 431);
            tabPageHoaDon.TabIndex = 1;
            tabPageHoaDon.Text = "Hóa đơn";
            tabPageHoaDon.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtTongTien);
            panel6.Controls.Add(label17);
            panel6.Controls.Add(dtgvHoaDon);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(3, 164);
            panel6.Name = "panel6";
            panel6.Size = new Size(853, 264);
            panel6.TabIndex = 1;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(122, 220);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(154, 23);
            txtTongTien.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(31, 225);
            label17.Name = "label17";
            label17.Size = new Size(58, 15);
            label17.TabIndex = 8;
            label17.Text = "Tổng tiền";
            // 
            // dtgvHoaDon
            // 
            dtgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHoaDon.Dock = DockStyle.Top;
            dtgvHoaDon.Location = new Point(0, 0);
            dtgvHoaDon.Name = "dtgvHoaDon";
            dtgvHoaDon.ReadOnly = true;
            dtgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvHoaDon.Size = new Size(853, 210);
            dtgvHoaDon.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MistyRose;
            panel5.Controls.Add(btnHoanTatHoaDon);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(btnThemVaoHoaDon);
            panel5.Controls.Add(numericUpDownHoaDonSoLuong);
            panel5.Controls.Add(txtHoaDonDonGia);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(cbbHoaDonProduct);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(dtpkHoaDonNgayLapHoaDon);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(txtHoaDonTenKhachHang);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Dock = DockStyle.Fill;
            panel5.ForeColor = Color.Black;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(853, 425);
            panel5.TabIndex = 0;
            // 
            // btnHoanTatHoaDon
            // 
            btnHoanTatHoaDon.Location = new Point(722, 99);
            btnHoanTatHoaDon.Name = "btnHoanTatHoaDon";
            btnHoanTatHoaDon.Size = new Size(89, 39);
            btnHoanTatHoaDon.TabIndex = 16;
            btnHoanTatHoaDon.Text = "Hoàn tất hóa đơn";
            btnHoanTatHoaDon.UseVisualStyleBackColor = true;
            btnHoanTatHoaDon.Click += btnHoanTatHoaDon_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(371, 143);
            label16.Name = "label16";
            label16.Size = new Size(92, 15);
            label16.TabIndex = 6;
            label16.Text = "Chi tiết hóa đơn";
            // 
            // btnThemVaoHoaDon
            // 
            btnThemVaoHoaDon.Location = new Point(722, 40);
            btnThemVaoHoaDon.Name = "btnThemVaoHoaDon";
            btnThemVaoHoaDon.Size = new Size(89, 44);
            btnThemVaoHoaDon.TabIndex = 15;
            btnThemVaoHoaDon.Text = "Thêm vào hóa đơn";
            btnThemVaoHoaDon.UseVisualStyleBackColor = true;
            btnThemVaoHoaDon.Click += btnThemVaoHoaDon_Click;
            // 
            // numericUpDownHoaDonSoLuong
            // 
            numericUpDownHoaDonSoLuong.Location = new Point(545, 78);
            numericUpDownHoaDonSoLuong.Name = "numericUpDownHoaDonSoLuong";
            numericUpDownHoaDonSoLuong.Size = new Size(144, 23);
            numericUpDownHoaDonSoLuong.TabIndex = 14;
            // 
            // txtHoaDonDonGia
            // 
            txtHoaDonDonGia.Location = new Point(545, 107);
            txtHoaDonDonGia.Name = "txtHoaDonDonGia";
            txtHoaDonDonGia.Size = new Size(144, 23);
            txtHoaDonDonGia.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(462, 107);
            label15.Name = "label15";
            label15.Size = new Size(47, 15);
            label15.TabIndex = 12;
            label15.Text = "đơn giá";
            // 
            // cbbHoaDonProduct
            // 
            cbbHoaDonProduct.FormattingEnabled = true;
            cbbHoaDonProduct.Location = new Point(545, 40);
            cbbHoaDonProduct.Name = "cbbHoaDonProduct";
            cbbHoaDonProduct.Size = new Size(144, 23);
            cbbHoaDonProduct.TabIndex = 10;
            cbbHoaDonProduct.SelectedIndexChanged += cbbHoaDonProduct_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(462, 80);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 8;
            label12.Text = "Số lượng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(462, 43);
            label13.Name = "label13";
            label13.Size = new Size(60, 15);
            label13.TabIndex = 6;
            label13.Text = "Sản phẩm";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(545, 12);
            label14.Name = "label14";
            label14.Size = new Size(114, 15);
            label14.TabIndex = 5;
            label14.Text = "Thông tin sản phẩm";
            // 
            // dtpkHoaDonNgayLapHoaDon
            // 
            dtpkHoaDonNgayLapHoaDon.CustomFormat = "dd/MM/yyyy";
            dtpkHoaDonNgayLapHoaDon.Format = DateTimePickerFormat.Custom;
            dtpkHoaDonNgayLapHoaDon.Location = new Point(132, 90);
            dtpkHoaDonNgayLapHoaDon.Name = "dtpkHoaDonNgayLapHoaDon";
            dtpkHoaDonNgayLapHoaDon.Size = new Size(144, 23);
            dtpkHoaDonNgayLapHoaDon.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 96);
            label11.Name = "label11";
            label11.Size = new Size(101, 15);
            label11.TabIndex = 3;
            label11.Text = "Ngày lập hóa đơn";
            // 
            // txtHoaDonTenKhachHang
            // 
            txtHoaDonTenKhachHang.Location = new Point(132, 50);
            txtHoaDonTenKhachHang.Name = "txtHoaDonTenKhachHang";
            txtHoaDonTenKhachHang.Size = new Size(144, 23);
            txtHoaDonTenKhachHang.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 53);
            label10.Name = "label10";
            label10.Size = new Size(91, 15);
            label10.TabIndex = 1;
            label10.Text = "Tên khách hàng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 12);
            label9.Name = "label9";
            label9.Size = new Size(124, 15);
            label9.TabIndex = 0;
            label9.Text = "Thông tin khách hàng";
            // 
            // tabPageThongKe
            // 
            tabPageThongKe.Controls.Add(dateTimePickerThongKeEnd);
            tabPageThongKe.Controls.Add(label25);
            tabPageThongKe.Controls.Add(label21);
            tabPageThongKe.Controls.Add(panel7);
            tabPageThongKe.Controls.Add(dateTimePickerThongKeStart);
            tabPageThongKe.Controls.Add(cbbThongKe);
            tabPageThongKe.Controls.Add(label20);
            tabPageThongKe.Controls.Add(label19);
            tabPageThongKe.Controls.Add(label18);
            tabPageThongKe.Controls.Add(btnXemBaoCao);
            tabPageThongKe.Location = new Point(4, 24);
            tabPageThongKe.Name = "tabPageThongKe";
            tabPageThongKe.Padding = new Padding(3);
            tabPageThongKe.Size = new Size(859, 431);
            tabPageThongKe.TabIndex = 2;
            tabPageThongKe.Text = "Thống kê";
            tabPageThongKe.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerThongKeEnd
            // 
            dateTimePickerThongKeEnd.CustomFormat = "dd/MM/yyyy";
            dateTimePickerThongKeEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerThongKeEnd.Location = new Point(455, 96);
            dateTimePickerThongKeEnd.Name = "dateTimePickerThongKeEnd";
            dateTimePickerThongKeEnd.Size = new Size(144, 23);
            dateTimePickerThongKeEnd.TabIndex = 9;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(334, 102);
            label25.Name = "label25";
            label25.Size = new Size(81, 15);
            label25.TabIndex = 8;
            label25.Text = "Ngày kết thúc";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label21.Location = new Point(334, 129);
            label21.Name = "label21";
            label21.Size = new Size(160, 22);
            label21.TabIndex = 7;
            label21.Text = "Báo cáo doanh thu";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtTongDoanhThu);
            panel7.Controls.Add(label22);
            panel7.Controls.Add(dtvgThongKe);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(3, 154);
            panel7.Name = "panel7";
            panel7.Size = new Size(853, 274);
            panel7.TabIndex = 6;
            // 
            // txtTongDoanhThu
            // 
            txtTongDoanhThu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTongDoanhThu.Location = new Point(185, 228);
            txtTongDoanhThu.Name = "txtTongDoanhThu";
            txtTongDoanhThu.ReadOnly = true;
            txtTongDoanhThu.Size = new Size(100, 26);
            txtTongDoanhThu.TabIndex = 9;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label22.Location = new Point(36, 226);
            label22.Name = "label22";
            label22.Size = new Size(143, 25);
            label22.TabIndex = 8;
            label22.Text = "Tổng doanh thu";
            // 
            // dtvgThongKe
            // 
            dtvgThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvgThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgThongKe.Dock = DockStyle.Top;
            dtvgThongKe.Location = new Point(0, 0);
            dtvgThongKe.Name = "dtvgThongKe";
            dtvgThongKe.ReadOnly = true;
            dtvgThongKe.Size = new Size(853, 218);
            dtvgThongKe.TabIndex = 0;
            // 
            // dateTimePickerThongKeStart
            // 
            dateTimePickerThongKeStart.CustomFormat = "dd/MM/yyyy";
            dateTimePickerThongKeStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerThongKeStart.Location = new Point(175, 96);
            dateTimePickerThongKeStart.Name = "dateTimePickerThongKeStart";
            dateTimePickerThongKeStart.Size = new Size(144, 23);
            dateTimePickerThongKeStart.TabIndex = 5;
            // 
            // cbbThongKe
            // 
            cbbThongKe.FormattingEnabled = true;
            cbbThongKe.Location = new Point(175, 61);
            cbbThongKe.Name = "cbbThongKe";
            cbbThongKe.Size = new Size(144, 23);
            cbbThongKe.TabIndex = 4;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(54, 102);
            label20.Name = "label20";
            label20.Size = new Size(78, 15);
            label20.TabIndex = 3;
            label20.Text = "Ngày bắt đầu";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(54, 61);
            label19.Name = "label19";
            label19.Size = new Size(111, 15);
            label19.TabIndex = 2;
            label19.Text = "Theo loại sản phẩm";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(94, 20);
            label18.Name = "label18";
            label18.Size = new Size(138, 22);
            label18.TabIndex = 1;
            label18.Text = "Bộ lọc thống kê";
            // 
            // btnXemBaoCao
            // 
            btnXemBaoCao.Location = new Point(632, 106);
            btnXemBaoCao.Name = "btnXemBaoCao";
            btnXemBaoCao.Size = new Size(91, 42);
            btnXemBaoCao.TabIndex = 0;
            btnXemBaoCao.Text = "Xem báo cáo";
            btnXemBaoCao.UseVisualStyleBackColor = true;
            btnXemBaoCao.Click += btnXemBaoCao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 501);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cửa hàng máy tính";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageLoaiSanPham.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuongTon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvgProduct).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvgCategory).EndInit();
            tabPageHoaDon.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHoaDon).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHoaDonSoLuong).EndInit();
            tabPageThongKe.ResumeLayout(false);
            tabPageThongKe.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvgThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPageLoaiSanPham;
        private TabPage tabPageHoaDon;
        private TabPage tabPageThongKe;
        private Panel panel4;
        private TextBox textBox4;
        private Label label7;
        private TextBox txtProductGiaBan;
        private Label label6;
        private TextBox txtProductName;
        private Label label4;
        private Label label5;
        private Button btnAddProduct;
        private DataGridView dtvgProduct;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Button btnAddCategory;
        private DataGridView dtvgCategory;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private NumericUpDown numericUpDownSoLuongTon;
        private ComboBox comboBoxLoaiSanPham;
        private Label label8;
        private Panel panel6;
        private Panel panel5;
        private TextBox txtHoaDonTenKhachHang;
        private Label label10;
        private Label label9;
        private TextBox txtTongTien;
        private Label label17;
        private DataGridView dtgvHoaDon;
        private Button btnHoanTatHoaDon;
        private Label label16;
        private Button btnThemVaoHoaDon;
        private NumericUpDown numericUpDownHoaDonSoLuong;
        private TextBox txtHoaDonDonGia;
        private Label label15;
        private ComboBox cbbHoaDonProduct;
        private Label label12;
        private Label label13;
        private Label label14;
        private DateTimePicker dtpkHoaDonNgayLapHoaDon;
        private Label label11;
        private Label label21;
        private Panel panel7;
        private TextBox txtTongDoanhThu;
        private Label label22;
        private DataGridView dtvgThongKe;
        private DateTimePicker dateTimePickerThongKeStart;
        private ComboBox cbbThongKe;
        private Label label20;
        private Label label19;
        private Label label18;
        private Button btnXemBaoCao;
        private TextBox txtNameCategory;
        private Button btnDeleteCategory;
        private Button btnUpdateCategory;
        private TextBox txtSearchProduct;
        private Label label23;
        private TextBox txtSearchCategory;
        private Label label24;
        private DateTimePicker dateTimePickerThongKeEnd;
        private Label label25;
    }
}
