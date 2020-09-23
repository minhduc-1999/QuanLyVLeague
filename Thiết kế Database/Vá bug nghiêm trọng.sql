create trigger Tr_PHATTHE_CauThu_ThePhat_insert on PHATTHE
for insert
as
begin
	declare @MaTranDau char(45), @MaCauThu varchar(45), @MaLoaiThe varchar(45), @SoTheDo int, @SoTheVang int
	select @MaTranDau=MaTranDau, @MaCauThu=MaCauThu,@MaLoaiThe=MaLoaiThe
	from inserted
	select @SoTheDo =count(MaPhatThe)
	from PHATTHE
	where MaTranDau=@MaTranDau and MaCauThu=@MaCauThu and MaLoaiThe=(select MaLoaiThe from LOAITHE where TenThe = N'Đỏ')
	select @SoTheVang =count(MaPhatThe)
	from PHATTHE
	where MaTranDau=@MaTranDau and MaCauThu=@MaCauThu and MaLoaiThe=(select MaLoaiThe from LOAITHE where TenThe = N'Vàng')
	if(@MaLoaiThe=NULL)
	begin
		print N'Lỗi: Chưa nhập mã loại thẻ'
		rollback transaction
	end
	if(@SoTheDo>1 or @SoTheVang>2)
	begin
		print N'Lỗi: Số thẻ quá quy định'
		rollback transaction
	end
	else
		print N'Thỏa mãn số thẻ phạt đúng quy định'
end
go
---------------------------------------------------
create trigger Tr_PHATTHE_CauThu_ThePhat_update on PHATTHE
for update
as
begin
	declare @MaTranDau char(45), @MaCauThu varchar(45), @MaLoaiThe varchar(45), @SoTheDo int, @SoTheVang int, @ThoiDiem time, @MaPhatThe varchar(45)
	select @MaTranDau=MaTranDau, @MaCauThu=MaCauThu,@MaLoaiThe=MaLoaiThe, @ThoiDiem=ThoiDiem,@MaPhatThe=MaPhatThe
	from inserted
	select @SoTheDo =count(MaPhatThe)
	from PHATTHE
	where MaTranDau=@MaTranDau and MaCauThu=@MaCauThu and MaLoaiThe= (select MaLoaiThe from LOAITHE where TenThe=N'Đỏ')
	select @SoTheVang =count(MaPhatThe)
	from PHATTHE
	where MaTranDau=@MaTranDau and MaCauThu=@MaCauThu and MaLoaiThe=(select MaLoaiThe from LOAITHE where TenThe=N'Vàng')
	if(@MaLoaiThe=NULL)
	begin
		print N'Lỗi: Chưa nhập mã loại thẻ'
		rollback transaction
	end
	if(@SoTheDo>1 or @SoTheVang>2)
	begin
		print N'Lỗi: Số thẻ quá quy định'
		rollback transaction
	end
	else
		print N'Thỏa mãn số thẻ phạt đúng quy định'
end
go
---------------------------------------------------
create trigger Tr_CHITIETTHAYNGUOI_ThoiDiem_update on CHITIETTHAYNGUOI
for update
as
begin
	declare @ThoiDiemThayNguoi time, @ThoiGianThiDau time, @MaTranDau varchar(45), @MaThayNguoi varchar(45)
	select @ThoiDiemThayNguoi = ThoiDiem, @MaTranDau = MaTranDau, @MaThayNguoi=MaThayNguoi
	from inserted
	select @ThoiGianThiDau = ThoiGianThiDau
	from TRANDAU
	where @MaTranDau=MaTranDau
	if(@ThoiDiemThayNguoi>@ThoiGianThiDau)
	begin
		print N'Lỗi: Quy trình thay người quá thời gian quy định'
		rollback transaction
	end
	else
	begin
		print N'Thỏa mãn điều kiện thời điểm'
	end
end
go
---------------------------------------------------
create trigger Tr_PHATTHE_ThoiDiem_update on PHATTHE
for update
as
begin
	declare @ThoiDiemPhatThe time, @ThoiGianThiDau time, @MaTranDau varchar(45), @MaPhatThe varchar(45)
	select @ThoiDiemPhatThe = ThoiDiem, @MaTranDau = MaTranDau, @MaPhatThe=MaPhatThe
	from inserted
	select @ThoiGianThiDau = ThoiGianThiDau
	from TRANDAU
	where @MaTranDau=MaTranDau
	if(@ThoiDiemPhatThe>@ThoiGianThiDau)
	begin
		print N'Lỗi: Thẻ phạt quá thời gian quy định'
		rollback transaction
	end
	else
	begin
		print N'Thỏa mãn điều kiện thời điểm'
	end
end
go
---------------------------------------------------
create trigger Tr_BANTHANG_ThoiDiem_update on BANTHANG
for update
as
begin
	declare @ThoiDiemBanThang time, @ThoiGianThiDau time, @MaTranDau varchar(45), @MaBanThang varchar(45)
	select @ThoiDiemBanThang = ThoiDiem, @MaTranDau = MaTranDau, @MaBanThang=MaBanThang
	from inserted
	select @ThoiGianThiDau = ThoiGianThiDau
	from TRANDAU
	where @MaTranDau=MaTranDau
	if(@ThoiDiemBanThang>@ThoiGianThiDau)
	begin
		print N'Lỗi: Bàn thắng quá thời gian quy định'
		rollback transaction
	end
	else
	begin
		print N'Thỏa mãn điều kiện thời điểm'
	end
end
go
---------------------------------------------------
create trigger Tr_SanThiDau_TenSan_update on SANTHIDAU
for update
as
begin
	declare @MaSanThiDau varchar(45), @TenSanThiDau nvarchar(45), @MaMuaGiai varchar(45), @MaDoiNha varchar(45), @DonViSoHuu nvarchar(45),@SoSan int
	select @MaSanThiDau=MaSanThiDau,@TenSanThiDau=TenSanThiDau,@MaMuaGiai=MaMuaGiai,@MaDoiNha=MaDoiNha,@DonViSoHuu=DonViSoHuu
	from inserted
	if exists (select * from SANTHIDAU where TenSanThiDau=@TenSanThiDau and MaMuaGiai=@MaMuaGiai)
	select @SoSan=count(MaSanThiDau)
	from SANTHIDAU
	where SANTHIDAU.TenSanThiDau=@TenSanThiDau and SANTHIDAU.MaMuaGiai=@MaMuaGiai
	if (@SoSan>1)
	begin
		print N'Lỗi: Sân thi đấu đã có'
		rollback transaction
	end
	else
	begin
		print N'Thỏa mãn điều kiện sân thi đấu không trùng lặp'
	end
end
go
--------------------------------------------------------------------
create trigger Tr_CAUTHU_tuoi_update on CAUTHU
for update
as
begin
	declare @NgaySinh date, @Tuoi int,@TuoiToiThieu int, @TuoiToiDa int, @TenCauThu nvarchar(45),@MaLoaiCauThu varchar(45), @GhiChu nvarchar(45),@MaDoi varchar(45),@SoBanThang int,@MaCauThu varchar
	select @NgaySinh=NgaySinh,@TenCauThu=TenCauThu,@MaLoaiCauThu=MaLoaiCauThu,@GhiChu=GhiChu,@MaDoi=MaDoi,@SoBanThang=SoBanThang,@MaCauThu=MaCauThu
	from inserted
	select @TuoiToiThieu=TuoiToiThieu, @TuoiToiDa=TuoiToiDa
	from DIEUKIEN
	where MaMuaGiai=(select MaMuaGiai
	from CAUTHU inner join DOIBONG on CAUTHU.MaDoi=DOIBONG.MaDoi
	where CAUTHU.MaCauThu=@MaCauThu)
	set @Tuoi=year(getdate())-year(@NgaySinh)
	if(@Tuoi<@TuoiToiThieu)
	begin
		print N'Lỗi: Tuổi nhỏ hơn tuổi quy định'
		rollback transaction
	end
	if(@Tuoi>@TuoiToiDa)
	begin
		print N'Lỗi: Tuổi lớn hơn tuổi quy định'
		rollback transaction
	end
	if(@Tuoi>=@TuoiToiThieu and @Tuoi<=@TuoiToiDa)
	begin
		print N'Thỏa mãn điều kiện tuổi của cầu thủ'
	end
end
go
----------------------------------------------------------------------------
create trigger Tr_CAUTHU_SoLuong_update on CAUTHU
for update
as
begin
	declare @MaDoi varchar(45), @SoCauThuToiDa int, @SoCauThuToiThieu int, @SoCauThu int, @MaCauThu varchar(45), @TenCauThu nvarchar(45), @NgaySinh date, @MaLoaiCauThu varchar(45),@GhiChu nvarchar(45),@SoBanThang int
	select @MaDoi=MaDoi, @MaCauThu=MaCauThu,@TenCauThu=TenCauThu,@NgaySinh=NgaySinh,@MaLoaiCauThu=MaLoaiCauThu,@GhiChu=GhiChu,@SoBanThang=SoBanThang
	from inserted
	select @SoCauThuToiDa=SoCauThuToiDa,@SoCauThuToiThieu=SoCauThuToiThieu
	from DIEUKIEN
	where MaMuaGiai=(select MaMuaGiai
	from CAUTHU inner join DOIBONG on CAUTHU.MaDoi=DOIBONG.MaDoi
	where CAUTHU.MaCauThu=@MaCauThu)
	select @SoCauThu=count(MaCauThu)
	from CAUTHU
	where MaDoi=@MaDoi
	if(@SoCauThu>@SoCauThuToiDa)
	begin
		print N'Lỗi: Số cầu thủ trong đội vượt mức quy định'
		rollback transaction
	end
	if(@SoCauThu-1<@SoCauThuToiThieu)
	begin
		print N'Lưu ý: Số cầu thủ trong đội không đủ mức quy định'
	end
	if(@SoCauThu<=@SoCauThuToiDa and @SoCauThu>=@SoCauThuToiThieu)
	begin
		print N'Thảo mãn điều kiện số cầu thủ trong đội'
	end
end
go