--------------------------TenMuaGiaiDuyNhat-------------------------
create trigger Tr_MuaGiai_Ten on MUAGIAI
for insert, update
as
begin
	declare @TenMuaGiai varchar(45), @MaMuaGiai varchar(45),@SoLuong int
	select @TenMuaGiai=TenMuaGiai,@MaMuaGiai=MaMuaGiai
	from inserted
	select @SoLuong=count(MaMuaGiai)
	from MUAGIAI
	where TenMuaGiai=@TenMuaGiai
	if (@SoLuong>1)
	begin 
		print N'Lỗi: Tên mùa giải đã tồn tại'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện mùa giải không trùng lặp'
end
go