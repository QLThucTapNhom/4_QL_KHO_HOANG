


use QLKho

-------------------================================xuat Hoa Don ===============================

-- Xóa Hóa dơn
create Trigger Delete_Xuat on HoaDonXuat instead of Delete
	as
	Declare @maxuat int
	begin
		select @maxuat=IdXuat from deleted
		update SanPham
	
		set SoLuongTon=SoLuongTon + (select SoLuong from XuatChiTiet a where IdXuat=@maxuat and SanPham.SanPhamID=a.SanPhamID) from SanPham
		where SanPhamID in (select SanPhamID from XuatChiTiet where IdXuat=@maxuat)
		delete from XuatChiTiet where IdXuat=@maxuat
		delete from HoaDonXuat where IdXuat=@maxuat
		
	end
	

	Drop trigger Delete_HD

	delete HoaDonXuat where IdXuat=N'006' /*Xóa Hóa Đơn*/

	--------------------
	--4. Xóa 1 Chi Tiết Hóa đơn 
	/*Xóa 1 chi tiết Hóa đơn ta cần trả lại hàng tồn kho và giảm giá tiền trong Hóa đơn*/

	create Trigger Delete_CTXuat on XuatChiTiet instead of Delete
	as
	Declare @maxuat int
	Declare @masp int
	begin
		select @maxuat = IdXuat from deleted
		select @masp = SanPhamID from deleted

		delete from XuatChiTiet where IdXuat=@maxuat and SanPhamID = @masp
		update SanPham
		set SoLuongTon=SoLuongTon + (select SoLuong from XuatChiTiet a where IdXuat=@maxuat and SanPham.SanPhamID=a.SanPhamID) from SanPham
		where SanPhamID in (select SanPhamID from XuatChiTiet where IdXuat=@maxuat)

		update HoaDonXuat
		set Tong=Tong - (select DonGia*SoLuong from XuatChiTiet where @maxuat = IdXuat and SanPhamID= XuatChiTiet.SanPhamID) from HoaDonXuat
		where IdXuat in (select IdXuat from XuatChiTiet where @maxuat = IdXuat and SanPhamID=@masp)
		
	end
	
	delete XuatChiTiet where IdXuat=10 and SanPhamID=1
	drop trigger Delete_CTHD

	----------------------------------

	
--2.Tạo Trigger  thêm mới 1 Hóa đơn Sản Phẩm
/*Khi muốn thêm 1 hóa đơn thì ta phải bắt đầu thêm từ hóa đơn chi tiết khi làm xong các Hóa đơn Chi Tiết thì mới thêm dữ liệu vào Hóa đơn được*/
/* Tạo trigger để thêm chi tiết hóa đơn bán hàng 
	Khi thêm một chi tiết hóa đơn bán hàng ta cần kiểm tra xem nó đã tồn tại chưa
	Nếu chưa tồn tại ta cần kiểm tra xem số lượng cần bán ra có lớn hơn lượng còn lại trong kho không
	Nếu đủ để bán cho khách hàng lúc này ta cần update lấy giá bán , thời gian bảo hành của sản phẩm
	sau đó update lượng hàng tồn của sản phẩm
	Cuối cùng update lại tổng tiền của hóa đơn bán hàng đó.
*/



	
		create trigger Insert_CTHoaDon on XuatChiTiet instead of Insert
	as
	declare @soluong int,@masp char(10),@soluongton int,@mahd char(10),@Tongtien float
	begin
		select @masp=SanPhamID from inserted
		select @soluong=SoLuong from inserted
		select @mahd=IdXuat from inserted
		select @soluongton=SoLuongTon from SanPham where SanPhamID=@masp
		select @Tongtien=Tong from HoaDonXuat where IdXuat=@mahd
		if exists( select IdXuat,SanPhamID
					from XuatChiTiet
					where IdXuat=@mahd and SanPhamID=@masp)
					begin
					print N'Chi tiết hóa đơn này đã tồn tại'
					end
		else
		begin
		if (@soluong > @soluongton)
		begin
		print N'Lượng hàng yêu cầu bán lớn hơn lượng hàng còn trong kho'
		end
		else
		begin
			insert into XuatChiTiet(SanPhamID,IdXuat,SoLuong)
			values (@masp,@mahd,@soluong)
			update SanPham
			set SoLuongTon=SoLuongTon-@soluong
			where SanPhamID=@masp
			update XuatChiTiet
			set DonGia=(select DonGiaSanPham from SanPham where SanPhamID=@masp)
			where SanPhamID=@masp and @mahd=IdXuat
			if(@Tongtien = null)
			begin
				update HoaDonXuat
				set Tong=(select DonGia*SoLuong from XuatChiTiet where SanPhamID=@masp and IdXuat=@mahd)
				where IdXuat=@mahd
			end
			else
			begin
				update HoaDonXuat
				set Tong=Tong + (select DonGia*SoLuong from XuatChiTiet where SanPhamID=@masp and IdXuat=@mahd)
				where IdXuat=@mahd
			end
		end
		end
	end
	-----


	/*Thêm Hóa Đơn*/
	insert into HoaDonXuat(IdXuat,NgayHD,NhanVienID)
	values(N'007','2020/02/10',N'NV01')
	insert into XuatChiTiet(IdXuat,SanPhamID,SoLuong)
	values (N'007',N'002',11)

	drop trigger Insert_CTHoaDon/*Xóa Trigger */



	-------------------================================Nhap Hoa Don ===============================


	
-- Xóa Hóa dơn
create Trigger Delete_Nhap on HoaDonNhap instead of Delete
	as
	Declare @manhap int
	begin
		select @manhap=IdNhap from deleted
		update SanPham
	
		set SoLuongTon=SoLuongTon + (select SoLuong from NhapChiTiet a where IdNhap=@manhap and SanPham.SanPhamID=a.SanPhamID) from SanPham
		where SanPhamID in (select SanPhamID from NhapChiTiet where IdNhap=@manhap)
		delete from NhapChiTiet where IdNhap=@manhap
		delete from HoaDonNhap where IdNhap=@manhap
		
	end
	

	Drop trigger Delete_Nhap

	delete HoaDonNhap where IdNhap=N'006' /*Xóa Hóa Đơn*/

	--------------------
	--4. Xóa 1 Chi Tiết Hóa đơn 
	/*Xóa 1 chi tiết Hóa đơn ta cần trả lại hàng tồn kho và giảm giá tiền trong Hóa đơn*/

	create Trigger Delete_CTNhap on NhapChiTiet instead of Delete
	as
	Declare @manhap int
	Declare @masp int
	begin
		select @manhap = IdNhap from deleted
		select @masp = SanPhamID from deleted

		delete from NhapChiTiet where IdNhap=@manhap and SanPhamID = @masp
		update SanPham
		set SoLuongTon=SoLuongTon + (select SoLuong from NhapChiTiet a where IdNhap=@manhap and SanPham.SanPhamID=a.SanPhamID) from SanPham
		where SanPhamID in (select SanPhamID from NhapChiTiet where IdNhap=@manhap)

		update HoaDonNhap
		set Tong=Tong - (select DonGia*SoLuong from NhapChiTiet where @manhap = IdNhap and SanPhamID= NhapChiTiet.SanPhamID) from HoaDonNhap
		where IdNhap in (select IdNhap from NhapChiTiet where @manhap = IdNhap and SanPhamID=@masp)
		
	end
	
	delete NhapChiTiet where IdNhap=N'' and SanPhamID=N''
	drop trigger Delete_CTNhap


	---------------tạo Hoa Don

	
		create trigger Insert_CTHoaDonNhap on NhapChiTiet instead of Insert
	as
	declare @soluong int,@masp char(10),@soluongton int,@mahd char(10),@Tongtien float
	begin
		select @masp=SanPhamID from inserted
		select @soluong=SoLuong from inserted
		select @mahd=IdNhap from inserted
		select @soluongton=SoLuongTon from SanPham where SanPhamID=@masp
		select @Tongtien=Tong from HoaDonNhap where IdNhap=@mahd
		if exists( select IdNhap,SanPhamID
					from NhapChiTiet
					where IdNhap=@mahd and SanPhamID=@masp)
					begin
					print N'Chi tiết hóa đơn này đã tồn tại'
					end
		
		else
		begin
			insert into NhapChiTiet(SanPhamID,IdNhap,SoLuong)
			values (@masp,@mahd,@soluong)
			update SanPham
			set SoLuongTon=SoLuongTon-@soluong
			where SanPhamID=@masp
			update NhapChiTiet
			set DonGia=(select DonGiaSanPham from SanPham where SanPhamID=@masp)
			where SanPhamID=@masp and @mahd=IdNhap
			if(@Tongtien = null)
			begin
				update HoaDonNhap
				set Tong=(select DonGia*SoLuong from NhapChiTiet where SanPhamID=@masp and IdNhap=@mahd)
				where IdNhap=@mahd
			end
			else
			begin
				update HoaDonNhap
				set Tong=Tong + (select DonGia*SoLuong from NhapChiTiet where SanPhamID=@masp and IdNhap=@mahd)
				where IdNhap=@mahd
			end
		end
		
	end
	-----


	/*Thêm Hóa Đơn*/
	insert into HoaDonNhap(IdNhap,NgayHD,NhanVienID)
	values(N'007','2020/02/10',N'NV01')
	insert into NhapChiTiet (IdNhap,SanPhamID,SoLuong)
	values (N'007',N'002',11)

	drop trigger Insert_CTHoaDonNhap/*Xóa Trigger */


	----------------------------------
	/*Tạo Report Xuất Hóa Don*/

	

	create proc XuatHoadon (@MaHD nvarchar(128) )
	as
	begin
	select KhachHang.TenKhachHang,KhachHang.DiaChi,KhachHang.SoDienThoai,SanPham.TenSanPham,SanPham.ThoiGianBaoHanh,HoaDonXuat.IdXuat,HoaDonXuat.NgayHD,HoaDonXuat.Tong,
	XuatChiTiet.DonGia,XuatChiTiet.SoLuong
	from HoaDonXuat,XuatChiTiet,SanPham,KhachHang
	where HoaDonXuat.IdXuat=XuatChiTiet.IdXuat and SanPham.SanPhamID=XuatChiTiet.SanPhamID and KhachHang.KhachHangID= HoaDonXuat.KhachHangID and HoaDonXuat.IdXuat=@MaHD
	
	end

	exec XuatHoadon N'001'
	--drop procedure xuatHoadon

--proc xoa NCC
CREATE PROC DEL_NCC @MaNCC NCHAR(20) AS
BEGIN
  
 UPDATE dbo.SanPham SET NhaCungCapID=NULL WHERE NhaCungCapID=@MaNCC
  DELETE FROM dbo.NhaCungCap WHERE NhaCungCapID=@MaNCC
   
END