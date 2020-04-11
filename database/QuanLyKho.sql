create database QLKho
go
use QLKho
go
create table NhanVien
(
	NhanVienID nvarchar(50) primary key,
	HoTen nvarchar(50)null,
	NgaySinh date null,
	GioiTinh bit null,
	ChucVu nvarchar(20)null,
	DiaChi nvarchar(100)null,
	Email varchar(50)null,
	SoDienThoai varchar(15)null,
	Luong int null
)
go
create table NhaCungCap
(
	NhaCungCapID nvarchar(50) primary key,
	TenNhaCungCap nvarchar(50)null ,
	DiaChi nvarchar(100)null,
	SoDienThoai nvarchar(15)null,
	Email nvarchar(50)null,
	MoreInfo nvarchar(max),
	TGHopDong Date,

)
go

go
create table SanPham
(
    SanPhamID nvarchar(128) primary key,
	NhaCungCapID nvarchar(50) not null,
	TenSanPham nvarchar(max)null,
	Hang nvarchar(50)null,
	XuatXu nvarchar(50)null,
	MauSac nvarchar(50)null,
	SoLuongTon int null,
	DonGiaSanPham int null,
	NgaySanXuat date null,
	ThoiGianBaoHanh nvarchar(50) null
	foreign key(NhaCungCapID) references NhaCungCap(NhaCungCapID),

)
go



create table HoaDonNhap
(
   IdNhap nvarchar(128) primary key,
   	NhanVienID nvarchar(50) foreign key references NhanVien(NhanVienID),
   NgayHD Date,
   Tong int ,

)
go

create table NhapChiTiet
(
	IdNhap nvarchar(128) foreign key references HoaDonNhap(IdNhap),
	SanPhamID nvarchar(128) foreign key references SanPham(SanPhamID),
	SoLuong int null,
	DonGia int null,
	primary key(SanPhamID,IdNhap)
)
go

create table HoaDonXuat
(
   IdXuat nvarchar(128) primary key,
   NhanVienID nvarchar(50) foreign key references NhanVien(NhanVienID),
   NgayHD Date,
   Tong int ,
)
go
create table XuatChiTiet
(
	IdXuat nvarchar(128) foreign key references HoaDonXuat(IdXuat),
	SanPhamID nvarchar(128) foreign key references SanPham(SanPhamID),
	SoLuong int null,
	DonGia int null,
	primary key(SanPhamID,IdXuat)
)
go

CREATE TABLE TaiKhoan(
	[acc] char(15) primary key,
	[pass] char(15) null,
	NhanVienID nvarchar(50) foreign key references NhanVien(NhanVienID),

)
go

insert into NhanVien values(N'NV01',N'Đàm Viết Tùng','1999-08-07',1,N'Tiếp Thị',N'Hà Nội','NhanVien1@gmail.com','012345679',3000000)
insert into NhanVien values(N'NV02',N'Đàm Viết Độ','1999-09-07',1,N'Nhân Viên Kĩ Thuật',N'Hà Nội','NhanVien2@gmail.com','012345679',3000000)
insert into NhanVien values(N'NV03',N'Đặng Quốc Khánh','1999-07-07',1,N'Tiếp Thị',N'Hà Nội','NhanVien3@gmail.com','012345679',3000000)
insert into NhanVien values(N'NV04',N'Lê Văn Hoàng','1999-03-03',1,N'Bảo Vệ',N'Hà Nội','NhanVien4@gmail.com','012345679',3000000)
insert into NhanVien values(N'NV05',N'Lê Văn Luyện','1999-12-07',1,N'Tiếp Thị',N'Hà Nội','NhanVien5@gmail.com','012345679',3000000)

INSERT [dbo].[TaiKhoan]  VALUES (N'admin', N'1',N'NV01')
INSERT [dbo].[TaiKhoan]  VALUES (N'admin1', N'123',N'NV02')
INSERT [dbo].[TaiKhoan] VALUES (N'admin2', N'123',N'NV03')
INSERT [dbo].[TaiKhoan]  VALUES (N'admin3', N'123',N'NV04')

INSERT [dbo].[NhaCungCap]  VALUES (N'001', N'Nhà cung cấp 1', N'Cầu Giấy-HN', N'01681796124  ', N'NCC1@gmail.com',null,N'2019-01-01')
INSERT [dbo].[NhaCungCap]  VALUES (N'002', N'Nhà cung cấp 2', N'Nhổn-HN', N'01668546124  ', N'NCC2@gmail.com',null,N'2019-02-01')
INSERT [dbo].[NhaCungCap]  VALUES (N'003', N'Nhà xuất bản 3', N'Xuân Thủy-HN', N'01689896124  ', N'NCC3@gmail.com',null,N'2020-03-01')
INSERT [dbo].[NhaCungCap] VALUES (N'004', N'Nhà xuất bản 4', N'Phạm Quang-HN', N'01674156129  ', N'NCC4@gmail.com',null,N'2020-05-01')
INSERT [dbo].[NhaCungCap] VALUES (N'005', N'Nhà xuất bản 5', N'Phạm Hùng-HN', N'01674156124  ', N'NCC5@gmail.com',null,N'2020-04-01')


insert into SanPham values(N'001',N'001',N'IPhone 11','Nokia','ChiNa','Đen',50,11000000,'2018-12-12',N'12 tháng')
insert into SanPham values(N'002',N'002',N'IPhone 17','Nokia','ChiNa','Gold',50,9000000,'2016-02-02',N'12 tháng')
insert into SanPham values(N'003',N'003',N'IPhone 16','Nokia','ChiNa','Trắng',50,6000000,'2015-07-12',N'12 tháng')
insert into SanPham values(N'004',N'004',N'IPhone 15','Nokia','ChiNa','Đen',50,5000000,'2017-12-12',N'12 tháng')
insert into SanPham values(N'005',N'005',N'ViVoy15','ViVo','ChiNa','Xanh',50,7500000,'2019-09-12',N'12 tháng')

INSERT [dbo].[HoaDonNhap]  VALUES (N'001',N'NV01', N'2020-01-01',110000000 )
INSERT [dbo].[HoaDonNhap]  VALUES (N'002',N'NV02', N'2016-02-02', 9000000)
INSERT [dbo].[HoaDonNhap]  VALUES (N'003',N'NV03', N'2016-01-02', 60000000)
INSERT [dbo].[HoaDonNhap]  VALUES (N'004',N'NV04', N'2015-04-04',5000000)
INSERT [dbo].[HoaDonNhap]  VALUES (N'005',N'NV05', N'2010-04-04', 7500000)

INSERT [dbo].[NhapChiTiet]  VALUES (N'001', N'001', 10,  110000000)
INSERT [dbo].[NhapChiTiet]  VALUES (N'002', N'002', 1, 9000000)
INSERT [dbo].[NhapChiTiet]  VALUES (N'003', N'003', 10, 6000000)
INSERT [dbo].[NhapChiTiet]  VALUES (N'004', N'004',1, 5000000)
INSERT [dbo].[NhapChiTiet]  VALUES (N'005', N'005', 1, 7500000)


INSERT [dbo].[HoaDonXuat]  VALUES (N'001',N'NV05', N'2020-01-01',11000000 )
INSERT [dbo].[HoaDonXuat]  VALUES (N'002',N'NV04', N'2016-02-02', 90000000)
INSERT [dbo].[HoaDonXuat]  VALUES (N'003',N'NV03', N'2016-01-02', 60000000)
INSERT [dbo].[HoaDonXuat]  VALUES (N'004',N'NV02', N'2015-04-04',5000000)
INSERT [dbo].[HoaDonXuat]  VALUES (N'005',N'NV01', N'2010-04-04', 7500000)

INSERT [dbo].[XuatChiTiet]  VALUES (N'001', N'001', 1,  11000000)
INSERT [dbo].[XuatChiTiet]  VALUES (N'002', N'002', 10, 9000000)
INSERT [dbo].[XuatChiTiet]  VALUES (N'003', N'003', 10, 6000000)
INSERT [dbo].[XuatChiTiet]  VALUES (N'004', N'004',1, 5000000)
INSERT [dbo].[XuatChiTiet]  VALUES (N'005', N'005', 1, 7500000)


