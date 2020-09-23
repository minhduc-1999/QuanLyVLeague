------------------------------SoCauThuChinhThucKhongQua11Nguoi---------------------------------------------------------------------------
create trigger Tr_SoCauThuTrenSan on DANHSACHTHAMGIA
for insert,update 
as
begin
	declare @MaTranDau varchar(45),@SoLuong int,@MaCauThu varchar(45)
	select @MaTranDau=MaTranDau,@MaCauThu=MaCauThu
	from inserted
	select @SoLuong=count(CAUTHU.MaCauThu) from DANHSACHTHAMGIA inner join CAUTHU on DANHSACHTHAMGIA.MaCauThu=CAUTHU.MaCauThu where DANHSACHTHAMGIA.CauThuChinhThuc=1 and MaDoi=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu) and MaTranDau=@MaTranDau
	if(@SoLuong>11)
	begin
		print N'Số cầu thủ chính thức quá 11 người'
		rollback transaction
	end
	else 
		print N'Thỏa mản điều kiện số cầu thủ thi đấu không quá 11 người'
end
go