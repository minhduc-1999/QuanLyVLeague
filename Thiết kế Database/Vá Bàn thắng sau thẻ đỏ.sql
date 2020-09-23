-------------------------Sửa lại--------------------------
------------------------------ThayNguoiSauPhamLoi---------------------------------------------------------------------------
create trigger Tr_ThayNguoiNhapSauPhamLoi on CHITIETTHAYNGUOI
for insert,update 
as
begin
	declare @MaThayNguoi varchar(45), @MaCauThuVaoSan varchar(45), @MaCauThuRaSan varchar(45), @ThoiDiem time, @MaTranDau varchar(45),@SoLuongTheVang int, @SoLuongTheDo int, @MaTheDo varchar(45), @MaTheVang varchar(45)
	select @MaThayNguoi=MaThayNguoi,@MaCauThuRaSan=MaCauThuRaSan,@MaCauThuVaoSan=MaCauThuVaoSan,@ThoiDiem=ThoiDiem,@MaTranDau=MaTranDau
	from inserted

	select @MaTheDo= MaLoaiThe
	from LOAITHE
	where TenThe=N'Đỏ'

	select @MaTheDo= MaLoaiThe
	from LOAITHE
	where TenThe=N'Vàng'

	select @SoLuongTheVang=count(MaPhatThe) from PHATTHE where MaCauThu=@MaCauThuRaSan and MaLoaiThe=@MaTheVang and ThoiDiem <= @ThoiDiem and MaTranDau=@MaTranDau
	select @SoLuongTheDo=count(MaPhatThe) from PHATTHE where MaCauThu=@MaCauThuRaSan and MaLoaiThe=@MaTheDo and ThoiDiem <= @ThoiDiem and MaTranDau=@MaTranDau
	if(@SoLuongTheDo>=1 or @SoLuongTheVang>=2)
	begin
		print N'Chi tiết thay người vi phạm quy chế phạt thẻ đả có'
		rollback transaction 
	end

	select @SoLuongTheVang=count(MaPhatThe) from PHATTHE where MaCauThu=@MaCauThuVaoSan and MaLoaiThe=@MaTheVang and ThoiDiem <= @ThoiDiem and MaTranDau=@MaTranDau
	select @SoLuongTheDo=count(MaPhatThe) from PHATTHE where MaCauThu=@MaCauThuVaoSan and MaLoaiThe=@MaTheDo and ThoiDiem <= @ThoiDiem and MaTranDau=@MaTranDau
	if(@SoLuongTheDo>=1 or @SoLuongTheVang>=2)
	begin
		print N'Chi tiết thay người vi phạm quy chế phạt thẻ đả có'
		rollback transaction 
	end
end
go
------DieuKienDieuKien--------------
alter table DIEUKIEN
add constraint Tr_DIEUKIEN check(TuoitoiThieu>0 and TuoiToiDa>0 and SoCauThuToiThieu>0 and SoCauThuToiDa>0 and SoCauThuNuocNgoaiToiDa>=0 and SoLanThayNguoiToiDa>=0 and TuoiToiDa >= TuoiToiThieu and SoCauThuToiDa >= SoCauthuToiThieu);
go
----------------------------thêm mới-----------------------------------------------------------
------------------------------GhiBanSauPhatThe---------------------------------------------------------------------------
create trigger Tr_GhiBanSauPhatThe on BANTHANG
for insert,update 
as
begin
	declare @MaBanThang varchar(45),@MaCauThu varchar(45),@ThoiDiem time,@MaTranDau varchar(45),@SoLuongTheVang int, @SoLuongTheDo int, @MaTheDo varchar(45), @MaTheVang varchar(45)
	select @MaBanThang=MaBanThang, @MaCauThu=MaCauThu,@ThoiDiem=ThoiDiem, @MaTranDau=MaTranDau
	from inserted

	select @MaTheDo= MaLoaiThe
	from LOAITHE
	where TenThe=N'Đỏ'

	select @MaTheDo= MaLoaiThe
	from LOAITHE
	where TenThe=N'Vàng'

	select @SoLuongTheVang=count(MaPhatThe) from PHATTHE where MaCauThu=@MaCauThu and MaLoaiThe=@MaTheVang and ThoiDiem <= @ThoiDiem and MaTranDau=@MaTranDau
	select @SoLuongTheDo=count(MaPhatThe) from PHATTHE where MaCauThu=@MaCauThu and MaLoaiThe=@MaTheDo and ThoiDiem <= @ThoiDiem and MaTranDau=@MaTranDau
	if(@SoLuongTheDo>=1 or @SoLuongTheVang>=2)
	begin
		print N'Bàn thắng vi phạm quy chế phạt thẻ đả có'
		rollback transaction 
	end
end
go