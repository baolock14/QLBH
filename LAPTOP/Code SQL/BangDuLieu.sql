create database LapTop
go
use LapTop
go

CREATE TABLE [TaiKhoan] (
  [userName] varchar(50) PRIMARY KEY,
  [passWord] varchar(50) not null,
  [typeAcc] varchar(10) not null
)
GO

CREATE TABLE [NhanVien] (
  [MaNV] varchar(10) PRIMARY KEY,
  [tenNV] nvarchar(100) not null,
  [DienThoai] varchar(13) not null,
  [NgaySinh] date not null,
  [GioiTinh] nvarchar(5) not null,
  [DiaChi] nvarchar(100) not null
)
GO


CREATE TABLE [KhachHang] (
  [MaKH] varchar(10) PRIMARY KEY,
  [TenKH] nvarchar(100) not null,
  [DiaChi] nvarchar(100),
  [DienThoai] char(10) not null
)
GO

CREATE TABLE [LoaiSP] (
  [MaLoai] int identity PRIMARY KEY,
  [tenLoai] nvarchar(50) not null
)
GO

CREATE TABLE [SanPham] (
  [MaSP] varchar(10) PRIMARY KEY,
  [TenSP] nvarchar(300) not null,
  [HangSX] nvarchar(100) not null,
  [DonGiaBan] numeric(15,0) not null,
  [BaoHanh] numeric(10,0) not null,
  [SoLuong] numeric(15,0) not null,
  [MaLoai]int not null
)
GO

CREATE TABLE [PhieuNK]
(
	[MaPhieu] varchar(10) Primary Key,
	[MaSP] Varchar(10),
	[NgayNhap] datetime not null,
	[DonGiaNhap] numeric(15,0) not null,
	[SoLuongNhap] Int
)
go
------------------
CREATE TABLE [ChiNhanh] (
  [MaCN] varchar(10) PRIMARY KEY,
  [TenCN] nvarchar(100) not null,
  [DiaChi] nvarchar(100) not null
)
GO

CREATE TABLE [HoaDon] (
  [MaHD] varchar(10) PRIMARY KEY,
  [MaNV] varchar(10) not null,
  [MaKH] varchar(10) not null,
  [NgayBan] datetime not null,
  [GhiChu] nvarchar(100),
  [TinhTrang] nvarchar(100),
  [MaCN] varchar(10) not null
)
GO

CREATE TABLE [ChiTietHoaDon] (
  [MaHD] varchar(10) ,
  [MaSP] varchar(10),
  [SoLuong] numeric(15,0) not null,
  [GiamGia] numeric(15,0),
  PRIMARY KEY ([MaHD], [MaSP])
)
GO

ALTER TABLE [SanPham] ADD FOREIGN KEY ([MaLoai]) REFERENCES [LoaiSP] ([MaLoai])
GO

ALTER TABLE [PhieuNK] ADD FOREIGN KEY ([MaSP]) REFERENCES SanPham([MaSP])
ON DELETE CASCADE
GO

ALTER TABLE chitiethoadon ADD FOREIGN KEY ([MaHD]) REFERENCES hoadon ([MaHD])
ON DELETE CASCADE
go

ALTER TABLE chitiethoadon ADD FOREIGN KEY ([MaSP]) REFERENCES sanpham ([MaSP])
ON DELETE CASCADE
go

ALTER TABLE [HoaDon]   ADD FOREIGN KEY ([MaCN]) REFERENCES [ChiNhanh] ([MaCN])
GO

ALTER TABLE [HoaDon] ADD FOREIGN KEY ([MaNV]) REFERENCES [NhanVien] ([MaNV])
GO

ALTER TABLE [HoaDon] ADD FOREIGN KEY ([MaKH]) REFERENCES [KhachHang] ([MaKH])
GO


-- CÁC TRIGGER

--TRIGGER NHẬP KHO
--1. KHI NHẬP KHO THÌ SỐ LƯỢNG SẢN PHẨM = SỐ LƯỢNG SP HIỆN TẠI + SỐ LƯỢNG SP NHẬP
--2. KHI XÓA PHIẾU NHẬP KHI THÌ SỐ LƯỢNG SẢN PHẨM = SỐ LƯỢNG HIỆN TẠI - SỐ LƯỢNG SP NHẬP
--3. KHI CẬP NHẬT LẠI PHIẾU NHẬP KHO THÌ SỐ LƯỢNG SẢN PHẨM = SỐ LƯỢNG HIỆN TẠI - SỐ LƯỢNG NHẬP CŨ + SỐ LƯỢNG NHẬP MỚI

--1.
CREATE TRIGGER tgNhapKhoSP
ON PhieuNK FOR INSERT
AS
BEGIN
	UPDATE SanPham SET SoLuong = SoLuong + inserted.SoLuongNhap 
	FROM SanPham JOIN inserted ON inserted.MaSP = SanPham.MaSP
END
go

--2.
CREATE TRIGGER tgXoaPNK
ON PhieuNK FOR DELETE
AS
BEGIN
	UPDATE SanPham SET SoLuong = SoLuong - deleted.SoLuongNhap
	FROM SanPham JOIN deleted ON deleted.MaSP = SanPham.MaSP
END
GO

--3.
CREATE TRIGGER tgCapNhatPNK
ON PhieuNK FOR UPDATE
AS
BEGIN
	UPDATE SanPham SET SoLuong = SoLuong - deleted.SoLuongNhap + inserted.SoLuongNhap
	FROM SanPham 
	JOIN deleted ON deleted.MaSP = SanPham.MaSP 
	JOIN inserted ON inserted.MaSP = SanPham.MaSP
END
GO

--TRIGGER THÊM XÓA SỬA HÓA ĐƠN CHI TIẾT
--1. KHI THÊM HÓA ĐƠN CHI TIẾT THÌ SỐ LƯỢNG SẢN PHẨM = SỐ LƯỢNG SP HIỆN TẠI - SỐ LƯỢNG SP BÁN Ở BẢNG INSERTED
--2. KHI XÓA HÓA ĐƠN CHI TIẾT THÌ SỐ LƯỢNG SẢN PHẨM = SỐ LƯỢNG HIỆN TẠI + SỐ LƯỢNG SP BÁN Ở BẢNG DELETED
--3. KHI CẬP NHẬT LẠI HÓA ĐƠN CHI TIẾT THÌ SỐ LƯỢNG SẢN PHẨM = SỐ LƯỢNG HIỆN TẠI - SỐ LƯỢNG Ở BẢNG DELETED + SỐ LƯỢNG MỚI Ở BẢNG INSERTED

--1. 
create trigger tgThemHDCT 
ON ChiTietHoaDon after insert
as
begin
	UPDATE SanPham SET SoLuong = SanPham.SoLuong - inserted.SoLuong
	FROM SanPham JOIN inserted ON inserted.MaSP = SanPham.MaSP
end
go

--2.
go
create trigger tgDeleteHDCT
on ChiTietHoaDon after delete
as
begin
	UPDATE SanPham SET SoLuong = SanPham.SoLuong + deleted.SoLuong
	FROM SanPham JOIN deleted ON deleted.MaSP = SanPham.MaSP
end
go

--3.
CREATE TRIGGER tgUpdateHDCT
ON ChiTietHoaDon FOR UPDATE
AS
BEGIN
	UPDATE SanPham SET SanPham.SoLuong = SanPham.SoLuong + deleted.SoLuong - inserted.SoLuong
	FROM SanPham 
	JOIN deleted ON deleted.MaSP = SanPham.MaSP 
	JOIN inserted ON inserted.MaSP = SanPham.MaSP
END
go

------------------------------------------end trigger-------------------------


	--INSERT DATA
	insert into TaiKhoan 
	values 
	('phuc', '212856012', 1),
	('minh', '484295358', 1),
	('nhu', '556214635', 0),
	('loc', '146104556', 0)
	go

	insert into LoaiSP
	values
	(N'Máy tính xách tay'),
	(N'Máy tính để bàn'),
	(N'Phụ kiện máy tính'),
	(N'Linh kiện máy tính'),
	(N'Thiết bị mạng')
	go

	insert into SanPham
	values
	('SP001', N'Laptop HP Pavilion Gaming 15-ec1054AX 1N1H6PA ( 15.6" Full HD/ 144Hz/AMD Ryzen 5 
			  4600H/8GB/128GB SSD/1TB HDD/NVIDIA GeForce GTX 1650/Windows 10 Home 64-bit/2kg)', N'HP', 19900000, 12, 0, 1),
	('SP002', N'Laptop ASUS 14 D409DA-EK152T (14" FHD/R5-3500U/4GB/256GB SSD/Radeon Vega 8/Win10/1.6kg)', N'ASUS', 11990000, 12, 0, 1),
	('SP003', N'Sạc Laptop Asus 19V-3.42A-65W (Đầu số 4) (4.0mm*1.35mm) (NQ)', N'ASUS', 350000, 12, 0, 3),
	('SP004', N'PC HP ProOne 400 G5 AIO 8GA33PA (20" HD+/i3-9100T/4GB/1TB HDD/UHD 630/Win10)', N'HP', 15900000, 12, 0, 2),
	('SP005', N'Router ToToLink A3002RU-V2', N'TotoLink', 1050000, 24, 0, 5)
	go

	insert into KhachHang
	values
	('KH001', N'Phan Thị Đài', N'Quảng Nam', '0943445621'),
	('KH002', N'Trần Văn Vân', N'Quảng Nam', '0364125345'),
	('KH003', N'Trần Thị Diệu Linh', N'Huế', '0943421536'),
	('KH004', N'Hà Thị Mỹ Hạnh', N'Quảng Nam', '0375412354')
	go

	insert into ChiNhanh
	values
	('CN001', N'Kim Anh Hải Châu', N'32 Phan Đăng Lưu, Đà Nẵng'),
	('CN002', N'Kim Anh Thanh Khê', N'92 Hàm Nghi, Đà Nẵng'),
	('CN003', N'Kim Anh Liên Chiểu', N'481 Tôn Đức Thắng, Đà Nẵng'),
	('CN004', N'Kim Anh Hà Nội', N'87 Trần Đại Nghĩa, Hà Nội')
	go

	insert into NhanVien 
	values
	('NV001', N'Nguyễn Thị Tố Như', '0399817941', '2000/12/25', N'Nữ', N'Quảng Bình'),
	('NV002', N'Nguyễn Công Phúc', '0943974645', '2000/02/10', N'Nam', N'Quảng Nam'),
	('NV003', N'Trương Công Minh', '0372342434', '2000/12/12', N'NaM', N'Quảng Ngãi'),
	('NV004', N'Đinh Bảo Lộc', '0974033171', '2000/05/18', N'Nam', N'Nghệ An')
	go

	insert into HoaDon
	(MaHD, MaNV, MaKH, NgayBan, GhiChu, TinhTrang, MaCN)
	values
	('HD001', 'NV001', 'KH001', '2020/11/26', N'N/A', N'N/A', 'CN001'),
	('HD002', 'NV001', 'KH002', '2020/10/26', N'N/A', N'N/A', 'CN001'),
	('HD003', 'NV002', 'KH003', '2020/9/26', N'N/A', N'N/A', 'CN002'),
	('HD004', 'NV002', 'KH004', '2020/8/20', N'N/A', N'N/A', 'CN002')
	go

	insert into ChiTietHoaDon
	values 
	('HD001', 'SP001', 1, 500000),
	('HD002', 'SP002', 1, 400000),
	('HD003', 'SP003', 1, 100000),
	('HD003', 'SP004', 1, 100000)
	GO
	insert into PhieuNK 
	values
	('NK001', 'SP001', '2020/05/25', 16000000, 10),
	('NK002', 'SP002', '2020/06/25', 9000000, 10),
	('NK003', 'SP003', '2020/07/25', 150000, 10),
	('NK004', 'SP004', '2020/08/25', 12000000, 10),
	('NK005', 'SP005', '2020/05/25', 850000, 10)
	go
------------------------------------TÀI KHOẢN--------------------------------------------------

--SP selectAll tài khoản
create proc selectAllTK
as
begin
	select * from TaiKhoan
end
go

--SP xóa tài khoản
create proc USP_DeleteTAcc (@userName varchar(50))
as
begin
	Delete From TaiKhoan where userName = @userName
end
go


-- Hàm Trường hợp trùng tên tài khoản
create function fGetUserName(@userName nvarchar(50))
returns bit
as
begin
	declare @count int
	select @count = COUNT(userName) from TaiKhoan where userName = @userName

	if @count > 0
		return 1
	return 0
end
go

-- SP Thêm tài khoản
create proc USP_ThemAcc
(@userName varchar(50), @passWord varchar(50), @TypeAcc varchar(10))
as
begin
	if (dbo.fGetUserName(@userName) = 1)
	begin
		return
	end
	else 
	begin
		Insert Into TaiKhoan
		(userName, passWord, typeAcc)
		Values
			(@userName, @passWord, @TypeAcc)
	end
end
go

-- SP Thay đổi password
create proc USP_UpdateAcc
(@userName varchar(50), @passWord varchar(50), @TypeAcc varchar(10))
As
Begin
	Update TaiKhoan set passWord = @passWord, typeAcc = @TypeAcc where userName = @userName
End
Go


-----------------------CHI NHÁNH-------------------------------------

-- SP select toàn bộ chi nhanh
create proc USP_SelectAllChiNhanh
as 
begin
	select * from ChiNhanh
end
go

--SP xóa chi nhánh
create proc USP_DeleteCNhanh (@MaCN varchar(10))
as
begin
	Delete From ChiNhanh where MaCN = @MaCN
end
go


-- Hàm Trường hợp trùng tên và địa chỉ chi nhánh (or)
create function fGetCN(@TenCN nvarchar(100), @DiaChi nvarchar(100))
returns bit
as
begin
	declare @count int
	select @count = COUNT(MaCN) from ChiNhanh where TenCN = @TenCN or DiaChi = @DiaChi

	if @count > 0
		return 1
	return 0
end
go


-- Tự tăng Mã Chi Nhánh
create function fGetNewMaCN ()
returns varchar(10)
as
begin
	declare @iCount int, @MaCNCrr varchar(10), @MaCN_new varchar(10)
	select @iCount = COUNT(MaCN) from ChiNhanh 
	if (@iCount <= 0) 
	begin
		set @MaCN_new = 'CN' + '001'
	end
	else
	begin
		select @MaCN_new = MAX(RIGHT(MaCN, 3)) + 1 from ChiNhanh
		set @MaCN_new = 'CN' + RIGHT(REPLICATE('0', 2) + @MaCN_new, 3)
	end
	return @MaCN_new
end
go

-- SP Thêm chi nhanh
create proc USP_ThemCN
(@TenCN nvarchar(100), @DiaChi nvarchar(100))
as
begin
	if (dbo.fGetCN(@TenCN, @DiaChi) = 1)
	begin
		return
	end
	else 
	begin
		Insert Into ChiNhanh
		(MaCN, TenCN, DiaChi)
		Values
			(dbo.fGetNewMaCN(), @TenCN, @DiaChi)
	end
end
go

-- SP Sửa  chi nhánh
create proc USP_UpdateCN
(@MaCN varchar(10), @TenCN nvarchar(100), @DiaChi nvarchar(100))
As
Begin
	Update ChiNhanh set TenCN = @TenCN, DiaChi = @DiaChi where MaCN = @MaCN
End
Go
-- SP tìm kiếm chi nhánh
create proc USP_TimKiemCN (@TieuChi nvarchar(100), @Text nvarchar(100))
as
begin
	if (@TieuChi = N'Mã chi nhánh') 
	begin
		select * from ChiNhanh where MaCN like CONCAT('%', @Text ,'%')
	end 
	else if (@TieuChi = N'Tên chi nhánh') 
	begin
		select * from ChiNhanh where TenCN like CONCAT('%', @Text ,'%')
	end 
end
go


-------------------------SẢN PHẨM--------------------------------

--Select all LoaiSp
create proc USP_SelectAllLoaiSP
as
begin
	select * from LoaiSP
end
go

--SP xóa sản phẩm
create proc USP_DeleteSP (@MaSP varchar(10))
as
begin
	Delete From SanPham where MaSP = @MaSP
end
go

-- Hàm Trường hợp trùng tên sp và hãng sản xuất
create function fGetSP(@TenSP nvarchar(50), @HangSX varchar(15))
returns bit
as
begin
	declare @count int
	select @count = COUNT(MaSP) from SanPham where TenSP = @TenSP and HangSX = @HangSX

	if @count > 0
		return 1
	return 0
end
go

-- Tự tăng Mã sản phẩm
create function fGetNewMaSP ()
returns varchar(10)
as
begin
	declare @iCount int, @MaSPCrr varchar(10), @MaSP_new varchar(10)
	select @iCount = COUNT(MaSP) from SanPham 
	if (@iCount <= 0) 
	begin
		set @MaSP_new = 'SP' + '001'
	end
	else
	begin
		select @MaSP_new = MAX(RIGHT(MaSP, 3)) + 1 from SanPham
		set @MaSP_new = 'SP' + RIGHT(REPLICATE('0', 2) + @MaSP_new, 3)
	end
	return @MaSP_new
end
go

-- SP Thêm sản phẩm mới

create proc USP_ThemSP 
(@tenSP nvarchar(100), @HangSX nvarchar(100),@DonGiaBan numeric(15,0), @MaLoai int, @BaoHanh numeric(10,0))
as
begin
	if (dbo.fGetSP(@tenSP, @HangSX) = 1)
	begin
		return
	end
	else 
	begin
		Insert Into SanPham 
		(MaSP, TenSP, HangSX, SoLuong, DonGiaBan, MaLoai, BaoHanh)
		Values
			(dbo.fGetNewMaSP(), @tenSP, @HangSX, 0, @DonGiaBan, @MaLoai, @BaoHanh)
	end
end
go

-- SP Sửa sản phẩm
create proc USP_UpdateSP
(@MaSP varchar(10), @tenSP nvarchar(100), @HangSX nvarchar(100),@DonGiaBan numeric(15,0), @MaLoai varchar(10), @BaoHanh numeric(10,0))
As
Begin
	Update SanPham 
	set  TenSP = @tenSP, HangSX = @HangSX, MaLoai = @MaLoai, DonGiaBan = @DonGiaBan, BaoHanh = @BaoHanh
	where MaSP = @MaSP
End
Go

--SP Tìm kiếm sản phẩm
create proc USP_TimKiemSP (@TieuChi nvarchar(100), @Text nvarchar(100))
as
begin
	if (@TieuChi = N'Tên sản phẩm') 
	begin
		select * from SanPham where TenSP like CONCAT('%', @Text ,'%')
	end 
	else if (@TieuChi = N'Mã sản phẩm') 
	begin
		select * from SanPham where MaSP like CONCAT('%', @Text ,'%')
	end 
	else if (@TieuChi = N'Hãng sản xuất') 
	begin
		select * from SanPham where HangSX like CONCAT('%', @Text ,'%')
	end 
end
go

------------------NHÂN VIÊN-------------------------------------
-- SP select toàn bộ bảng nhân viên
create proc USP_SelectAllNhanVien
as 
begin
	select * from NhanVien
end
go

--SP xóa nhân viên
create proc USP_DeleteNV (@MaNV varchar(10))
as
begin
	Delete From NhanVien where MaNV = @MaNV
end
go

-- Hàm Trường hợp trùng tên trùng SDT (Nhớ thông báo cho người dùng khi nhập trùng tên và số điện thoại)
create function fGetNV(@TenNV nvarchar(50), @DienThoai varchar(15))
returns bit
as
begin
	declare @count int
	select @count = COUNT(MaNV) from NhanVien where tenNV = @TenNV and DienThoai = @DienThoai

	if @count > 0
		return 1
	return 0
end
go

-- Tự tăng Mã Nhân viên
create function fGetNewMaNV ()
returns varchar(10)
as
begin
	declare @iCount int, @MaNVCrr varchar(10), @MaNV_new varchar(10)
	select @iCount = COUNT(MaNV) from NhanVien 
	if (@iCount <= 0) 
	begin
		set @MaNV_new = 'NV' + '001'
	end
	else
	begin
		select @MaNV_new = MAX(RIGHT(MaNV, 3)) + 1 from NHANVIEN
		set @MaNV_new = 'NV' + RIGHT(REPLICATE('0', 2) + @MaNV_new, 3)
	end
	return @MaNV_new
end
go

--SP thêm nhân viên mới
create proc USP_ThemNV  
(@tenNV nvarchar(100), @DienThoai varchar(13), @NgaySinh datetime, 
	@GioiTinh nvarchar(5), @DiaChi nvarchar(100))
as
begin
	if (dbo.fGetNV(@tenNV, @DienThoai) = 1)
	begin
		return
	end
	else 
	begin
		Insert Into NhanVien 
		(MaNV, tenNV, DiaChi, GioiTinh, NgaySinh, DienThoai)
		Values
			(dbo.fGetNewMaNV(), @tenNV, @DiaChi, @GioiTinh, @NgaySinh,  @DienThoai)
	end
end
go

-- SP Sửa nhân viên
create proc USP_UpdateNV 
(@maNV varchar(10),  @tenNV nvarchar(100), @dienThoai varchar(13), @ngaySinh date, 
	@gioiTinh nvarchar(5), @diaChi nvarchar(100))
As
Begin
	Update NhanVien set  tenNV = @tenNV, diaChi = @diaChi, dienThoai = @dienThoai, 
						  gioiTinh = @gioiTinh, ngaySinh = @ngaySinh where maNV = @maNV
End
Go

--SP Tìm kiếm nhân viên
create proc USP_TimKiemNV (@TieuChi nvarchar(100), @Text nvarchar(100))
as
begin
	if (@TieuChi = N'Tên nhân viên') 
	begin
		select * from NhanVien where tenNV like CONCAT('%', @Text ,'%')
	end 
	else if (@TieuChi = N'Mã nhân viên') 
	begin
		select * from NhanVien where MaNV like CONCAT('%', @Text ,'%')
	end 
end
go

-----------------------------KHÁCH HÀNG---------------------------------------

-- SP Lấy ra toàn bộ khách hàng
create proc USP_SelectAllKH
as
begin
	select * from KhachHang
end
go

-- SP Xóa Khách hàng
create proc USP_DeleteKH (@MaKH varchar(10))
as
begin
	Delete From KhachHang where MaKH = @MaKH
end
go

---- Hàm Trường hợp trùng tên trùng SDT
create function fGetKH(@TenKH nvarchar(50), @DienThoai varchar(15))
returns bit
as
begin
	declare @count int
	select @count = COUNT(MaKH) from KhachHang where TenKH = @TenKH and DienThoai = @DienThoai

	if @count > 0
		return 1
	return 0
end
go

-- Tự tăng Mã Khách hàng
create function fGetNewMaKH ()
returns varchar(10)
as
begin
	declare @iCount int, @MaKHCrr varchar(10), @MaKH_new varchar(10)
	select @iCount = COUNT(MaKH) from KhachHang 
	if (@iCount <= 0) 
	begin
		set @MaKH_new = 'KH' + '001'
	end
	else
	begin
		select @MaKH_new = MAX(RIGHT(MaKH, 3)) + 1 from KhachHang
		set @MaKH_new = 'KH' + RIGHT(REPLICATE('0', 2) + @MaKH_new, 3)
	end
	return @MaKH_new
end
go

-- SP Thêm Khách hàng
create proc USP_ThemKH  
(@tenKH nvarchar(100), @DiaChi nvarchar(100), @DienThoai varchar(13))
as
begin
	if (dbo.fGetKH(@tenKH, @DienThoai) = 1)
	begin
		return
	end
	else 
	begin
		Insert Into KhachHang 
		(MaKH, TenKH, DiaChi, DienThoai)
		Values
			(dbo.fGetNewMaKH(), @tenKH, @DiaChi,  @DienThoai)
	end
end
go

--Sửa khách hàng
create proc USP_UpdateKH (@MaKH varchar(10), @TenKH nvarchar(100), @DienThoai varchar(13), @DiaChi nvarchar(100))
as
begin
	update KhachHang set TenKH = @TenKH, DienThoai = @DienThoai, DiaChi = @DiaChi
	where MaKH = @MaKH 
end
go

-- SP tìm kiếm khách hàng
create proc USP_TimKiemKH (@TieuChi nvarchar(100), @Text nvarchar(100))
as
begin
	if (@TieuChi = N'Tên khách hàng') 
	begin
		select * from KhachHang where TenKH like CONCAT('%', @Text ,'%')
	end 
	else if (@TieuChi = N'Số điện thoại') 
	begin
		select * from KhachHang where DienThoai like CONCAT('%', @Text ,'%')
	end 
end
go

-----------------------NHẬP KHO-----------------------------------

--select sản phẩm by mã loại
create proc SelectSPbyMaLoai (@MaLoai int)
as
begin
	select MaSP, TenSP, SoLuong from SanPham  where MaLoai = @MaLoai
end
go

-- Select phiếu nhập kho
create proc USP_SelectPhieuNK
as
begin
	select nk.*, TenSP, SoLuongNhap * DonGiaNhap as thanhTien 
	from PhieuNK as nk join SanPham on SanPham.MaSP = nk.MaSP
end
go

--SP xóa Phiếu NK
create proc USP_DeletePNK (@MaPhieu varchar(10))
as
begin
	Delete From PhieuNK where MaPhieu = @MaPhieu
end
go

-- Tự tăng Mã phiếu NK
create function fGetNewMaPNK ()
returns varchar(10)
as
begin
	declare @iCount int, @MaPNKCrr varchar(10), @MaPNK_new varchar(10)
	select @iCount = COUNT(MaPhieu) from PhieuNK 
	if (@iCount <= 0) 
	begin
		set @MaPNK_new = 'NK' + '001'
	end
	else
	begin
		select @MaPNK_new = MAX(RIGHT(MaPhieu, 3)) + 1 from PhieuNK
		set @MaPNK_new = 'NK' + RIGHT(REPLICATE('0', 2) + @MaPNK_new, 3)
	end
	return @MaPNK_new
end
go

-- SP Thêm phiếu NK 
create proc USP_ThemPNK
( @MaSP varchar(10), @NgayNhap datetime,@DonGiaNhap numeric(15,0), @SoLuongNhap int)
as
begin
	begin
		Insert Into PhieuNK 
		(MaPhieu, MaSP, NgayNhap, DonGiaNhap, SoLuongNhap)
		Values
			(dbo.fGetNewMaPNK(), @MaSP, @NgayNhap, @DonGiaNhap, @SoLuongNhap)
	end
end
go

--Sửa phiếu nhập kho
create proc USP_UpdatePNK(@MaPhieu varchar(10), @MaSP varchar(10), @NgayNhap datetime,
							@DonGiaNhap numeric(15,0), @SoLuongNhap int)
As
Begin
	Update PhieuNK 
	set  MaSP = @MaSP, NgayNhap = @NgayNhap, DonGiaNhap = @DonGiaNhap, SoLuongNhap = @SoLuongNhap
	where MaPhieu = @MaPhieu
End
Go

--SP Tìm kiếm phiếu NK
create proc USP_TimKiemPNK (@TieuChi nvarchar(100), @Text nvarchar(100))
as
begin
	if (@TieuChi = N'Mã phiếu') 
	begin
		select nk.*, TenSP, SoLuongNhap * DonGiaNhap as thanhTien 
		from PhieuNK as nk join SanPham on SanPham.MaSP = nk.MaSP
		where MaPhieu like CONCAT('%', @Text ,'%')
	end 
end
go
-----------------------HÓA ĐƠN-----------------------------

-- Select All Hóa đơn
create proc SelectAllHD
as
begin
	select  HoaDon.MaHD, KhachHang.MaKH, NhanVien.MaNV, ChiNhanh.MaCN, NgayBan, GhiChu, TinhTrang, 
				SUM(SanPham.DonGiaBan*ChiTietHoaDon.SoLuong) as TongTien, SUM(GiamGia) As TongGiamGia, 
			 SUM(SanPham.DonGiaBan*ChiTietHoaDon.SoLuong) - SUM(GiamGia) as TongTienPhaiTra
	from HoaDon full outer join ChiTietHoaDon on HoaDon.MaHD = ChiTietHoaDon.MaHD
				full outer join SanPham on SanPham.MaSP = ChiTietHoaDon.MaSP
				join KhachHang on KhachHang.MaKH = HoaDon.MaKH
				join ChiNhanh on ChiNhanh.MaCN = HoaDon.MaCN
				join NhanVien on NhanVien.MaNV = HoaDon.MaNV
	group by HoaDon.MaHD, KhachHang.MaKH, NhanVien.MaNV, ChiNhanh.MaCN, NgayBan, GhiChu, TinhTrang
end
go

--SP xóa Hóa đơn
create proc USP_DeleteHD (@MaHD varchar(10))
as
begin
	Delete From HoaDon where MaHD = @MaHD
end
go

--Tự động tăng Mã HD
create function fGetNewMaHD ()
returns varchar(10)
as
begin
	declare @iCount int, @MaHDCrr varchar(10), @MaHD_new varchar(10)
	select @iCount = COUNT(MaHD) from HoaDon 
	if (@iCount <= 0) 
	begin
		set @MaHD_new = 'HD' + '001'
	end
	else
	begin
		select @MaHD_new = MAX(RIGHT(MaHD, 3)) + 1 from HoaDon
		set @MaHD_new = 'HD' + RIGHT(REPLICATE('0', 2) + @MaHD_new, 3)
	end
	return @MaHD_new
end
go

--Thêm Hóa đơn
create proc USP_ThemHD 
(@MaNV varchar(10), @MaKH varchar(10), @NgayBan datetime,@GhiChu nvarchar(100), @TinhTrang nvarchar(100), 
@MaCN varchar(10))
as
begin
	declare @iCount int
	set @iCount = (select COUNT(MaKH) from KhachHang where MaKH = @MaKH )
	if (@iCount < 1) 
		begin
			return
		end
	set  @iCount = (select COUNT(MaNV) from NhanVien where MaNV = @MaNV )
	if (@iCount < 1) 
		begin
			return
		end
	set  @iCount = (select COUNT(MaCN) from ChiNhanh where MaCN = @MaCN )
	if (@iCount < 1) 
		begin
			return
		end
	Insert Into HoaDon 
	(MaHD, MaNV, MaKH, NgayBan, GhiChu, TinhTrang, MaCN)
	Values
		(dbo.fGetNewMaHD(), @MaNV, @MaKH, @NgayBan, @GhiChu, @TinhTrang , @MaCN)
end
go

--Sửa hóa đơn
create proc USP_UpdateHD
(@MaHD varchar(10), @MaNV varchar(10), @MaKH varchar(10), @NgayBan datetime,@GhiChu nvarchar(100), @TinhTrang nvarchar(100), 
@MaCN varchar(10))
As
Begin
	declare @iCount int
	set @iCount = (select COUNT(MaKH) from KhachHang where MaKH = @MaKH )
	if (@iCount < 1) 
		begin
			return
		end
	set  @iCount = (select COUNT(MaNV) from NhanVien where MaNV = @MaNV )
	if (@iCount < 1) 
		begin
			return
		end
	set  @iCount = (select COUNT(MaCN) from ChiNhanh where MaCN = @MaCN )
	if (@iCount < 1) 
		begin
			return
		end
	Update HoaDon set MaNV = @MaNV, MaKH = @MaKH, MaCN = @MaCN, NgayBan = @NgayBan, GhiChu = @GhiChu, 
	TinhTrang = @TinhTrang
	where MaHD = @MaHD
End
Go

-- SP tìm kiếm hóa đơn
create proc USP_TimKiemHD (@TieuChi nvarchar(100), @Text nvarchar(100))
as
begin
	if (@TieuChi = N'Mã hóa đơn') 
	begin
	select  HoaDon.MaHD, KhachHang.MaKH, NhanVien.MaNV, ChiNhanh.MaCN, NgayBan, GhiChu, TinhTrang, 
			SUM(SanPham.DonGiaBan*ChiTietHoaDon.SoLuong) as TongTien, SUM(GiamGia) As TongGiamGia, 
			SUM(SanPham.DonGiaBan*ChiTietHoaDon.SoLuong) - SUM(GiamGia) as TongTienPhaiTra
	from HoaDon full outer join ChiTietHoaDon on HoaDon.MaHD = ChiTietHoaDon.MaHD
				full outer join SanPham on SanPham.MaSP = ChiTietHoaDon.MaSP
				join KhachHang on KhachHang.MaKH = HoaDon.MaKH
				join ChiNhanh on ChiNhanh.MaCN = HoaDon.MaCN
				join NhanVien on NhanVien.MaNV = HoaDon.MaNV
	where HoaDon.MaHD like CONCAT('%', @Text ,'%')
	group by HoaDon.MaHD, KhachHang.MaKH, NhanVien.MaNV, ChiNhanh.MaCN, NgayBan, GhiChu, TinhTrang
	end 
end
go

------------------------------------CHI TIẾT HÓA ĐƠN-----------------------------

--Xóa CTHD
create proc USP_DeleteCTHD (@MaHD varchar(10), @MaSP varchar(10))
as
begin
	Delete From ChiTietHoaDon where MaHD = @MaHD and MaSP = @MaSP
end
go

-- Select All ChiTietHoaDon
create proc USP_SelectAllCTHD
as
begin
	select cthd.*, sp.TenSP, sp.DonGiaBan, (cthd.SoLuong * DonGiaBan - GiamGia) as ThanhTien from ChiTietHoaDon as cthd join SanPham as sp on sp.MaSP = cthd.MaSP
end
go

-- Hàm Trường hợp trùng MaHD và MaSP
create function fGetCTHD(@MaHD varchar(10), @MaSP varchar(10))
returns bit
as
begin
	declare @count int
	select @count = COUNT(MaHD) from ChiTietHoaDon where MaHD = @MaHD and MaSP = @MaSP

	if @count > 0
		return 1
	return 0
end
go

-- SP Thêm chi tiết hóa đơn
create proc USP_ThemCTHD
(@MaHD varchar(10), @MaSP varchar(10), @SoLuong numeric(10,0), @GiamGia numeric(15,0))
as
begin
	declare @iCount int
	set @iCount = (select COUNT(MaHD) from HoaDon where MaHD = @MaHD )
	if (@iCount < 1) 
		begin
			return
		end
	set @iCount = (select COUNT(MaSP) from SanPham where MaSP = @MaSP )
	if (@iCount < 1) 
		begin
			return
		end
	if (dbo.fGetCTHD(@MaHD, @MaSP) = 1)
	begin
		return
	end
	else 
	begin
		Insert Into ChiTietHoaDon
		(MaHD, MaSP, SoLuong, GiamGia)
		Values
			(@MaHD, @MaSP, @SoLuong, @GiamGia)
	end
end
go

-- SP Sửa Chi Tiết HD
create proc USP_UpdateCTHD
(@MaHD varchar(10), @MaSP varchar(10), @MaSPCrr varchar(10), @SoLuong numeric(10,0), @GiamGia numeric(15,0))
As
Begin
	declare @iCount int
	set @iCount = (select COUNT(MaHD) from ChiTietHoaDon where MaHD = @MaHD and MaSP = @MaSP)
	if (@iCount >= 1) 
		begin
			return
		end
	set @iCount = (select COUNT(MaSP) from SanPham where MaSP = @MaSP )
	if (@iCount < 1) 
		begin
			return
		end
	Update ChiTietHoaDon 
	set  MaHD = @MaHD, MaSP = @MaSP, SoLuong = @SoLuong, GiamGia = @GiamGia
	where  MaHD = @MaHD and MaSP = @MaSPCrr 
End
Go

-- SP tìm kiếm hóa đơn chi tiết
create proc USP_TimKiemCTHD (@TieuChi nvarchar(100), @Text nvarchar(100))
as
begin
	if (@TieuChi = N'Mã hóa đơn') 
	begin
		select cthd.*, sp.TenSP, sp.DonGiaBan, (cthd.SoLuong * DonGiaBan - GiamGia) as ThanhTien 
		from ChiTietHoaDon as cthd join SanPham as sp on sp.MaSP = cthd.MaSP
		where MaHD like CONCAT('%', @Text ,'%')
	end 
	else if (@TieuChi = N'Mã sản phẩm') 
	begin
		select cthd.*, sp.TenSP, sp.DonGiaBan, (cthd.SoLuong * DonGiaBan - GiamGia) as ThanhTien 
		from ChiTietHoaDon as cthd join SanPham as sp on sp.MaSP = cthd.MaSP
		where sp.MaSP like CONCAT('%', @Text ,'%')
	end 
end
go


-- ràng buộc khi thêm hóa đơn
create proc USP_ThemHoaDoCons (@MaKH Varchar(10), @MaNV Varchar(10), @MaCN Varchar(10), @ret nvarchar(100))
as
begin
	declare @iCount int
	set @iCount = (select COUNT(MaKH) from KhachHang where MaKH = @MaKH )
	if (@iCount < 1) 
		begin
			set @ret = N'Mã khách hàng này không tồn tại'
		end
	set  @iCount = (select COUNT(MaNV) from NhanVien where MaNV = @MaNV )
	if (@iCount < 1) 
		begin
			set @ret = N'Mã nhân viên này không tồn tại'
		end
	set  @iCount = (select COUNT(MaCN) from ChiNhanh where MaCN = @MaCN )
	if (@iCount < 1) 
		begin
			set @ret = N'Mã chi nhánh này không tồn tại'
		end
end

-----Mã hoá cột số điện thoại của khách hàng---
----1. Tạo cột để lưu dữ liệu mã hoá
--Alter Table KhachHang
--Add [Encrypted SDT] varbinary(MAX)
--go

----2. Cập nhật dữ liệu được mã hoá vào cột vừa tạo
--Update KhachHang 
--Set [Encrypted SDT] = ENCRYPTBYPASSPHRASE('SDT', CONVERT(varchar(100),DienThoai))
--go

----3. Xoá bỏ cột dữ liệu chưa được mã hoá và truy vấn dữ liệu
--Alter Table KhachHang drop column DienThoai
--go
--Select * From KhachHang

----Giải mã dữ liệu--
--Select MaKH, TenKH, DiaChi,
--		CONVERT(char, CONVERT(varchar(100), DECRYPTBYPASSPHRASE('SDT', [Encrypted SDT]))) as DienThoai
--go

---------- BACKUP DỮ LIỆU --------
---- Ở thời điểm 28/11/2020 16:46:00: thực hiện full backup
--BACKUP DATABASE LapTop TO DISK = 'E:\BACKUP SQL\LapTop_FULL.bak' WITH INIT

---- Thêm 1 bản ghi mới vào bảng KhachHang
--INSERT INTO KhachHang
--VALUES ('KH005', N'Trần Nguyễn Đình Vũ', N'Đà Nẵng', '0771237452')

---- Ở thời điểm 28/11/2020 15:58:00: thực hiện differential backup
--BACKUP DATABASE LapTop TO DISK = 'E:\BACKUP SQL\LapTop_DIFF.bak' WITH INIT, DIFFERENTIAL

---- Thêm 1 bảng ghi mới thứ 2 vào bảng KhachHang
--INSERT INTO KhachHang
--VALUES ('KH006', N'Lương Ngọc Hoàng', N'Đà Nẵng', '0933774562')

---- Thực hiện log backup
--BACKUP LOG LapTop TO DISK = 'E:\BACKUP SQL\LapTop.trn'


------------------ TẠO INDEX ------------------
--CREATE NONCLUSTERED INDEX Index_1 on ChiTietHoaDon(MaHD)

