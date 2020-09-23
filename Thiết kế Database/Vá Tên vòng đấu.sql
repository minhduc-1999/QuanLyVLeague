------------------------------TenVongDauKoTrungNhau---------------------------------------------------------------------------
create trigger Tr_VONGDAU_Ten on VONGDAU
for insert,update
as
begin
	declare @MaVongDau varchar(45),@TenVongDau varchar(45),@MaMuaGiai varchar(45),@KT int
	set @KT=0
	select @MaVongDau=MaVongDau, @TenVongDau=TenVongDau,@MaMuaGiai=MaMuaGiai
	from inserted
	select @KT=count(MaVongDau) from VONGDAU where MaMuaGiai=@MaMuaGiai and TenVongDau=@TenVongDau
	if(@KT>=2)
	begin
		print N'Tên vòng đấu bị trùng lặp'
		rollback transaction 
	end
	else
		print N'Thỏa mãn điều kiện tên vòng đấu không trùng lặp'
end
go