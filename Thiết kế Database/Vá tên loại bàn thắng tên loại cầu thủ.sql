--------------------------TenLoaiBanThangDuyNhat-------------------------
create trigger Tr_LoaiBanThang_Ten on LOAIBANTHANG
for insert, update
as
begin
	declare @TenLoaiBanThang nvarchar(45),@MaMuaGiai varchar(45),@SoLuong int
	select @TenLoaiBanThang=TenLoaiBanThang,@MaMuaGiai=MaMuaGiai
	from inserted
	select @SoLuong=count(MaLoaiBanThang)
	from LOAIBANTHANG
	where TenLoaiBanThang=@TenLoaiBanThang and MaMuaGiai=@MaMuaGiai
	if (@SoLuong>1)
	begin 
		print N'Lỗi: Tên loại bàn thắng đả tồn tại'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện tên loại bàn thắng không trùng lặp'
end
go
--------------------------TenLoaiCauThuDuyNhat-------------------------
create trigger Tr_LoaiCauThu_Ten on LOAICAUTHU
for insert, update
as
begin
	declare @TenLoaiCauThu nvarchar(45),@MaMuaGiai varchar(45),@SoLuong int
	select @TenLoaiCauThu=TenLoaiCauThu,@MaMuaGiai=MaMuaGiai
	from inserted
	select @SoLuong=count(MaLoaiCauThu)
	from LOAICAUTHU
	where TenLoaiCauThu=@TenLoaiCauThu and MaMuaGiai=@MaMuaGiai
	if (@SoLuong>1)
	begin 
		print N'Lỗi: Tên loại cầu thủ đả tồn tại'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện tên loại cầu thủ không trùng lặp'
end
go