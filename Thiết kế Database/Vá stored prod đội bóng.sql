--------------------------------------------------------------------------------------
create procedure SoCauThuToiThieu @MaDoi varchar(45)
as
begin
	declare @SoCauThuToiThieu int, @SoCauThu int
	select @SoCauThuToiThieu=SoCauThuToiThieu
	from DIEUKIEN
	where DIEUKIEN.MaMuaGiai=(select MaMuaGiai from DOIBONG where MaDoi=@MaDoi)
	select @SoCauThu=count(MaCauThu)
	from CAUTHU
	where MaDoi=@MaDoi
	if(@SoCauThu>=@SoCauThuToiThieu)
		print N'Thỏa điều kiện số cầu thủ tối thiểu'
	else
	begin
		print N'Không thỏa điều kiện số cầu thủ tối thiểu, dử liệu không được phép nhập, đội bóng bị xóa dử liệu'
		update SANTHIDAU
		set MaDoiNha= NULL
		where MaDoiNha=@MaDoi
		delete
		from CAUTHU
		where MaDoi=@MaDoi
		delete
		from DOIBONG
		where MaDoi=@MaDoi
		delete
		from KETQUADOIBONG
		where MaDoi=@MaDoi
	end
end
go