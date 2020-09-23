--------------------------TenDoiBongDuyNhat-------------------------
create trigger Tr_DoiBong_Ten on DOIBONG
for insert, update
as
begin
	declare @MaDoi varchar(45),@TenDoi varchar(45),@MaMuaGiai varchar(45),@SoLuong int
	select @MaDoi=MaDoi,@TenDoi=TenDoi,@MaMuaGiai=MaMuaGiai
	from inserted
	select @SoLuong=count(MaDoi)
	from DOIBONG
	where TenDoi=@TenDoi and MaMuaGiai=@MaMuaGiai
	if (@SoLuong>1)
	begin 
		print N'Lỗi: Tên đội bóng đả tồn tại'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện tên đội bóng không trùng lặp'
end
go