------------------------------PhamLoiSauBanThang---------------------------------------------------------------------------
create trigger Tr_ThePhatNhapSau on PHATTHE
for insert,update 
as
begin
	declare @MaPhatThe varchar(45),@MaCauThu varchar(45),@MaLoaiThe varchar(45), @ThoiDiem time, @MaTranDau varchar(45),@TenThe nvarchar(45),@KTTheVang int
	select @MaPhatThe=MaPhatThe,@MaCauThu=MaCauThu,@MaLoaiThe=MaLoaiThe,@ThoiDiem=ThoiDiem,@MaTranDau=MaTranDau
	from inserted
	select @TenThe= TenThe from LOAITHE where MaLoaiThe=@MaLoaiThe
	if(@TenThe=N'Đỏ')
	begin
		if(exists(select MaBanThang from BANTHANG where MaTranDau=@MaTranDau and ThoiDiem>=@ThoiDiem and MaCauThu=@MaCauThu))
		begin
			print N'Thẻ đỏ của bạn vi phạm bàn thắng đả có trước đó'
			rollback transaction
		end
	end
	else if(@TenThe=N'Vàng')
	begin
		select @KTTheVang=count(MaPhatThe) from PHATTHE where MaTranDau=@MaTranDau and ThoiDiem<=@ThoiDiem and MaLoaiThe=@MaLoaiThe
		if(@KTTheVang>=2 and exists(select MaBanThang from BANTHANG where MaTranDau=@MaTranDau and ThoiDiem>=@ThoiDiem and MaCauThu=@MaCauThu))
		begin
			print N'Thẻ vàng của bạn vi phạm bàn thắng đả có trước đó'
			rollback transaction
		end
	end
end
go
------------------------------ThayNguoiSauBanThang---------------------------------------------------------------------------
create trigger Tr_ThayNguoiNhapSau_insert on CHITIETTHAYNGUOI
for insert
as
begin
	declare @MaThayNguoi varchar(45), @MaCauThuVaoSan varchar(45), @MaCauThuRaSan varchar(45), @ThoiDiem time, @MaTranDau varchar(45)
	select @MaThayNguoi=MaThayNguoi,@MaCauThuRaSan=MaCauThuRaSan,@MaCauThuVaoSan=MaCauThuVaoSan,@ThoiDiem=ThoiDiem,@MaTranDau=MaTranDau
	from inserted
	if(exists(select MaBanThang from BANTHANG where MaTranDau=@MaTranDau and MaCauThu=@MaCauThuRaSan and ThoiDiem>=@ThoiDiem))
	begin
		print N'Chi tiết thay người đả vi phạm bàn thắng được ghi nhận trước đó'
		rollback transaction
	end
end
go
------------------------------ThayNguoiSauBanThang---------------------------------------------------------------------------
create trigger Tr_ThayNguoiNhapSau_update on CHITIETTHAYNGUOI
for update 
as
begin
	declare @MaThayNguoi varchar(45), @MaCauThuVaoSan varchar(45), @MaCauThuRaSan varchar(45), @ThoiDiem time, @MaTranDau varchar(45)
	select @MaThayNguoi=MaThayNguoi,@MaCauThuRaSan=MaCauThuRaSan,@MaCauThuVaoSan=MaCauThuVaoSan,@ThoiDiem=ThoiDiem,@MaTranDau=MaTranDau
	from inserted
	if(exists(select MaBanThang from BANTHANG where MaTranDau=@MaTranDau and MaCauThu=@MaCauThuRaSan and ThoiDiem>=@ThoiDiem))
	begin
		print N'Chi tiết thay người đả vi phạm bàn thắng được ghi nhận trước đó'
		rollback transaction
	end
	else if(exists(select MaBanThang from BANTHANG where MaTranDau=@MaTranDau and MaCauThu=@MaCauThuVaoSan and ThoiDiem<=@ThoiDiem))
	begin
		print N'Chi tiết thay người đả vi phạm bàn thắng được ghi nhận trước đó'
		rollback transaction
	end

	declare @MaThayNguoi2 varchar(45), @MaCauThuVaoSan2 varchar(45), @MaCauThuRaSan2 varchar(45), @ThoiDiem2 time, @MaTranDau2 varchar(45)
	select @MaThayNguoi2=MaThayNguoi,@MaCauThuRaSan2=MaCauThuRaSan,@MaCauThuVaoSan2=MaCauThuVaoSan,@ThoiDiem2=ThoiDiem,@MaTranDau2=MaTranDau
	from deleted
	if(@MaCauThuRaSan2!=@MaCauThuRaSan and exists(select MaCauThu from BANTHANG where MaTranDau=@MaTranDau and MaCauThu=@MaCauThuRaSan2 and ThoiDiem>=@ThoiDiem2))
	begin
		print N'Chi tiết thay người vi phạm bàn thắng được ghi nhận trước đó, cầu thủ ra sân bị xóa đả có bàn thắng'
		rollback transaction
	end
	else if(@MaCauThuVaoSan2!=@MaCauThuVaoSan and exists(select MaCauThu from BANTHANG where MaTranDau=@MaTranDau2 and MaCauThu=@MaCauThuVaoSan2 and ThoiDiem>=@ThoiDiem2))
	begin
		print N'Chi tiết thay người vi phạm bàn thắng được ghi nhận trước đó, cầu thủ vào sân bị xóa đả có bàn thắng'
		rollback transaction
	end
end
go
------------------------------ThayNguoiSauBanThang---------------------------------------------------------------------------
create trigger Tr_ThayNguoiNhapSau_delete on CHITIETTHAYNGUOI
for delete 
as
begin
	declare @MaThayNguoi varchar(45), @MaCauThuVaoSan varchar(45), @MaCauThuRaSan varchar(45), @ThoiDiem time, @MaTranDau varchar(45)
	select @MaThayNguoi=MaThayNguoi,@MaCauThuRaSan=MaCauThuRaSan,@MaCauThuVaoSan=MaCauThuVaoSan,@ThoiDiem=ThoiDiem,@MaTranDau=MaTranDau
	from deleted
	if(exists(select MaBanThang from BANTHANG where MaCauThu=@MaCauThuVaoSan))
	begin
		print N'Không thể xóa chi tiết thay người vì cầu thủ vào sân đả có bàn thắng'
		rollback transaction 
	end
end
go
------------------------------ThayNguoiSauThayNguoi---------------------------------------------------------------------------
create trigger Tr_ThayNguoiNhapSauThayNguoi on CHITIETTHAYNGUOI
for insert,update 
as
begin
	declare @MaThayNguoi varchar(45), @MaCauThuVaoSan varchar(45), @MaCauThuRaSan varchar(45), @ThoiDiem time, @MaTranDau varchar(45)
	select @MaThayNguoi=MaThayNguoi,@MaCauThuRaSan=MaCauThuRaSan,@MaCauThuVaoSan=MaCauThuVaoSan,@ThoiDiem=ThoiDiem,@MaTranDau=MaTranDau
	from inserted
	if(exists(select MaThayNguoi from CHITIETTHAYNGUOI where MaTranDau=@MaTranDau and MaCauThuRaSan=@MaCauThuRaSan and ThoiDiem>=@ThoiDiem and MaThayNguoi!=@MaThayNguoi))
	begin
		print N'Chi tiết thay người đả vi phạm chi tiết thay người được ghi nhận trước đó, cụ thể là cầu thủ ra sân đả được đề cập'
		rollback transaction
	end
	else if(exists(select MaThayNguoi from CHITIETTHAYNGUOI where MaTranDau=@MaTranDau and MaCauThuVaoSan=@MaCauThuVaoSan and ThoiDiem>=@ThoiDiem and MaThayNguoi!=@MaThayNguoi))
	begin
		print N'Chi tiết thay người đả vi phạm chi tiết thay người được ghi nhận trước đó, cụ thể là cầu thủ vào sân đả được đề cập'
		rollback transaction
	end
end
go
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

	select @SoLuongTheVang=count(MaPhatThe) from PHATTHE where MaCauThu=@MaCauThuRaSan and MaLoaiThe=@MaTheVang and ThoiDiem <= @ThoiDiem
	select @SoLuongTheDo=count(MaPhatThe) from PHATTHE where MaCauThu=@MaCauThuRaSan and MaLoaiThe=@MaTheDo and ThoiDiem <= @ThoiDiem
	if(@SoLuongTheDo>=1 or @SoLuongTheVang>=2)
	begin
		print N'Chi tiết thay người vi phạm quy chế phạt thẻ đả có'
		rollback transaction 
	end

	select @SoLuongTheVang=count(MaPhatThe) from PHATTHE where MaCauThu=@MaCauThuVaoSan and MaLoaiThe=@MaTheVang and ThoiDiem <= @ThoiDiem
	select @SoLuongTheDo=count(MaPhatThe) from PHATTHE where MaCauThu=@MaCauThuVaoSan and MaLoaiThe=@MaTheDo and ThoiDiem <= @ThoiDiem
	if(@SoLuongTheDo>=1 or @SoLuongTheVang>=2)
	begin
		print N'Chi tiết thay người vi phạm quy chế phạt thẻ đả có'
		rollback transaction 
	end
end
go
------------------------------SuaDoiHinhThamGia---------------------------------------------------------------------------
create trigger Tr_SuaChuaDoiHinhThamGia on DANHSACHTHAMGIA 
for delete,update
as
begin
	declare @MaTranDau varchar(45), @MaCauThu varchar(45)
	select @MaTranDau=MaTranDau, @MaCauThu=MaCauThu
	from deleted

	if(exists(select MaBanThang from BANTHANG where MaTranDau=@MaTranDau and MaCauThu=@MaCauThu) )
	begin
		print N'Không thể xóa hay cập nhật cầu thủ vì cầu thủ đả có bàn thắng '
		rollback transaction 
	end

	if(exists(select MaPhatThe from PHATTHE where MaTranDau=@MaTranDau and MaCauThu=@MaCauThu) )
	begin
		print N'Không thể xóa hay cập nhật cầu thủ vì cầu thủ đả có thẻ phạt '
		rollback transaction 
	end

	if(exists(select MaThayNguoi from CHITIETTHAYNGUOI where MaTranDau=@MaTranDau and (MaCauThuRaSan=@MaCauThu or MaCauThuVaoSan =@MaCauThu)) )
	begin
		print N'Không thể xóa hay cập nhật cầu thủ vì cầu thủ đả có tình tiết thay người '
		rollback transaction 
	end
end
go