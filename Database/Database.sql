create database BaiTapLon_ComputerStore

CREATE TABLE LoaiSanPham (
    MaLoai INT PRIMARY KEY IDENTITY(1,1), 
    TenLoai NVARCHAR(100) NOT NULL        
);

CREATE TABLE SanPham (
    MaSP INT PRIMARY KEY IDENTITY(1,1),   
    TenSP NVARCHAR(200) NOT NULL,         
    MaLoai INT NOT NULL,                  
    GiaBan DECIMAL(18, 2) NOT NULL,      
    SoLuongTon INT NOT NULL,              
    FOREIGN KEY (MaLoai) REFERENCES LoaiSanPham(MaLoai)
);

CREATE TABLE HoaDon (
    MaHD INT PRIMARY KEY IDENTITY(1,1),   
    TenKhachHang NVARCHAR(200) NOT NULL,  
    NgayLap DATETIME NOT NULL,            
    TongTien DECIMAL(18, 2) NOT NULL     
);


CREATE TABLE ChiTietHoaDon (
    MaCTHD INT PRIMARY KEY IDENTITY(1,1), 
    MaHD INT NOT NULL,                   
    MaSP INT NOT NULL,                    
    SoLuong INT NOT NULL,                 
    DonGia DECIMAL(18, 2) NOT NULL,       
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

