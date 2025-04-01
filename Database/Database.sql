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

select * from ChiTietHoaDon
select * from HoaDon

CREATE TRIGGER trg_ResetChiTietHoaDonIdentity
ON ChiTietHoaDon
AFTER DELETE
AS
BEGIN
    -- Kiểm tra xem bảng có còn dữ liệu hay không
    IF NOT EXISTS (SELECT 1 FROM ChiTietHoaDon)
    BEGIN
        -- Reset giá trị Identity về 1
        DBCC CHECKIDENT ('ChiTietHoaDon', RESEED, 0);
    END
END;

CREATE TRIGGER trg_ResetHoaDonIdentity
ON HoaDon
AFTER DELETE
AS
BEGIN
    -- Kiểm tra xem bảng có còn dữ liệu hay không
    IF NOT EXISTS (SELECT 1 FROM HoaDon)
    BEGIN
        -- Reset giá trị Identity về 1
        DBCC CHECKIDENT ('HoaDon', RESEED, 0);
    END
END;

CREATE TRIGGER trg_ResetSanPhamIdentity
ON SanPham
AFTER DELETE
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM SanPham)
    BEGIN
        DBCC CHECKIDENT ('SanPham', RESEED, 0);
    END
END;

CREATE TRIGGER trg_ResetLoaiSanPhamIdentity
ON LoaiSanPham
AFTER DELETE
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM LoaiSanPham)
    BEGIN
        DBCC CHECKIDENT ('LoaiSanPham', RESEED, 0);
    END
END;

select * from HoaDon
select * from ChiTietHoaDon


SELECT
                    lsp.TenLoai,
                    SUM(cthd.SoLuong) AS SoLuongBan,
                    SUM(cthd.SoLuong * cthd.DonGia) AS TongDoanhThu
                FROM
                    ChiTietHoaDon cthd      
                INNER JOIN
                    HoaDon hd ON cthd.MaHD = hd.MaHD 
                INNER JOIN
                    SanPham sp ON cthd.MaSP = sp.MaSP 
                INNER JOIN
                    LoaiSanPham lsp ON sp.MaLoai = lsp.MaLoai 
               
                GROUP BY
                    lsp.TenLoai
                ORDER BY 
                    lsp.TenLoai