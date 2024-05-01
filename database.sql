use master
go
create database QuanLyOlympicOrg
go
use QuanLyOlympicOrg
go
-- Tạo bảng Cuộc thi
CREATE TABLE CuocThi (
	Id int identity primary key,
	Ten nvarchar(max),
	NgayBatdau date,
	NgayKetThuc date,
	MoTa nvarchar(max),
	DiaChi nvarchar(max),
	DonViToChuc nvarchar(max),
	SDT nvarchar(20),
);
-- Tạo bảng Người dùng
CREATE TABLE NguoiDung (
    Id INT identity PRIMARY KEY,
    TenTaiKhoan NVARCHAR(50),
    MatKhau NVARCHAR(255),
	HoTen nvarchar(max),
	DiaChi nvarchar(max),
	NgaySinh date,
	SoCCCD nvarchar(max),
	SDT nvarchar(20),
    Role NVARCHAR(max)
);
-- Tạo bảng Đội thi
CREATE TABLE DoiThi (
    Id INT identity PRIMARY KEY,
    IdCuocThi INT not null,
	TenCuocThi nvarchar(max),
    TenDoiThi NVARCHAR(255),
    IdNguoiHuongDan int not null,
	HoTenNguoiHuongDan nvarchar(max)
);

-- Tạo bảng Thành viên đội thi
CREATE TABLE ThanhVien(
	Id INT identity PRIMARY KEY,
    IdDoiThi INT,
	TenDoiThi nvarchar(max),
	IdSinhVien int,
	TenSinhVien nvarchar(max),
    VaiTro NVARCHAR(50),
);


-- Tạo bảng Kết quả thi
CREATE TABLE KetQua (
	Id int identity primary key,
	IdCuocThi int,
	TenCuocThi nvarchar(max),
	IdDoiThi int,
	TenDoiThi nvarchar(max),
	XepHang nvarchar(max),
	MoTa nvarchar(max)
);



-- Tạo bảng Phân quyền
CREATE TABLE PhanQuyen (
	Id int identity primary key,
	ChucVu nvarchar(max),
	MoTa nvarchar(max)
);
