alter table CAUTHU
add SoAo int;
------------------------------SoAoCauThuKhacNhau---------------------------------------------------------------------------
create trigger Tr_CAUTHU_SoAo on CAUTHU
for insert,update 
as
begin
	declare @MaCauThu varchar(45),@MaDoi varchar(45),@SoAo varchar(45),@KT int
	select @MaCauThu=MaCauThu,@MaDoi=MaDoi,@SoAo=SoAo
	from inserted
	select @KT=count(MaCauThu) from CAUTHU where MaDoi=@MaDoi and SoAo=@SoAo
	if(@KT>1)
	begin
		print N'Số áo cầu thủ đã tồn tại trong đội bóng'
		rollback transaction 
	end
	else
		print N'Thỏa mãn điều kiện số áo cầu thủ không trùng lắp'
end
go