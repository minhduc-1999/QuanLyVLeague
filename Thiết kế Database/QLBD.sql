create database QLBD
go
use QLBD
-------------TaoBAng-----------------------------
go
create table CAUTHU(
	MaCauThu varchar(45),
	TenCauThu nvarchar(45),
	SoAo tinyint,
	NgaySinh date,
	NgayRoiDi date,
	MaLoaiCauThu varchar(45),
	GhiChu nvarchar(45),
	MaDoi varchar(45),
	SoBanThang int,
	primary key(MaCauThu),
)
go
create table LOAICAUTHU(
	MaLoaiCauThu varchar(45),
	TenLoaiCauThu nvarchar(45),
	CauThuNuocNgoai bit,
	MaMuaGiai varchar(45),
	primary key (MaLoaiCauThu)
)
go
create table DOIBONG(
	MaDoi varchar(45),
	MaMuaGiai varchar(45),
	TenDoi nvarchar(45),
	primary key (MaDoi)
)
go
create table TRANDAU(
	MaTranDau varchar(45),
	MaMuaGiai varchar(45),
	DoiChuNha varchar(45),
	DoiKhach varchar(45),
	NgayThiDau date,
	NgayThiDauChinh date,
	GioThiDau time,
	GioThiDauChinh time,
	MaSanThiDau varchar(45),
	MaSanThiDauChinh varchar(45),
	SoBanThangDoiNha int,
	SoBanThangDoiKhach int,
	ThoiGianThiDau time,
	MaVongDau varchar(45),
	primary key (MaTranDau)
)
go
create table BANTHANG(
	MaBanThang varchar(45),
	MaCauThu varchar(45),
	MaLoaiBanThang varchar(45),
	ThoiDiem time,
	MaTranDau varchar(45),
	primary key (MaBanThang)
)
go
create table LOAIBANTHANG(
	MaLoaiBanThang varchar(45),
	MaMuaGiai varchar(45),
	TenLoaiBanThang nvarchar(45),
	TinhBanChoCauThu bit,
	primary key(MaLoaiBanThang)
)
go
create table DIEUKIEN(
	MaMuaGiai varchar(45),
	TuoiToiThieu int,
	TuoiToiDa int,
	SoCauThuToiThieu int,
	SoCauThuToiDa int,
	SoCauThuNuocNgoaiToiDa int,
	SoLanThayNguoiToiDa int,
	DiemSoThang int,
	DiemSoThua int,
	DiemSoHoa int,
	primary key(MaMuaGiai)
)
go
create table SANTHIDAU(
	MaSanThiDau varchar (45),
	TenSanThiDau nvarchar(45),
	MaMuaGiai varchar(45),
	DonViSoHuu nvarchar(45),
	MaDoiNha varchar(45),
	primary key(MaSanThiDau)
)
go
create table MUAGIAI(
	MaMuaGiai varchar(45),
	TenMuaGiai nvarchar(45),
	TrangThai int,
	primary key(MaMuaGiai)
)
go
create table BANGXEPHANG(
	MaDoi varchar(45),
	Ngay date,
	Thang int,
	Thua int,
	Hoa int,
	HieuSo int,
	Diem int,
	SoBanThangSanKhach int,
	XepHang int,
	primary key(MaDoi,Ngay)
)
go
create table DANHSACHTHAMGIA(
	MaTranDau varchar(45),
	MaCauThu varchar(45),
	CauThuDuBi bit,
	CauThuChinhThuc bit,
	primary key(MaTranDau,MaCauThu)
)
create table KETQUADOIBONG(
	MaDoi varchar(45),
	Thang int,
	Thua int,
	Hoa int,
	HieuSo int,
	Diem int,
	SoBanThangSanKhach int,
	primary key(MaDoi)
)
go
create table THUTUUUTIEN(
	ChiSoUuTien int,
	MaMuaGiai varchar(45),
	TenLoaiUuTien nvarchar(45),
	primary key(ChiSoUuTien,MaMuaGiai)
)
go
create table PHATTHE(
	MaPhatThe varchar(45),
	MaCauThu varchar(45),
	MaLoaiThe varchar(45),
	ThoiDiem time,
	MaTranDau varchar(45),
	primary key(MaPhatThe)
)
create table LOAITHE(
	MaLoaiThe varchar(45),
	TenThe nvarchar(45),
	primary key(MaLoaiThe),
)
go
create table VONGDAU(
	MaVongDau varchar(45),
	TenVongDau nvarchar(45),
	MaMuaGiai varchar(45),
	primary key(MaVongDau)
)
go
create table CHITIETTHAYNGUOI(
	MaThayNguoi varchar(45),
	MaCauThuVaoSan varchar(45),
	MaCauThuRaSan varchar(45),
	ThoiDiem time,
	MaTranDau varchar(45),
	primary key(MaThayNguoi)
)
--------taokhoangoai--------------------------
alter table DOIBONG
add constraint FK_DOIBONG_MaMuaGiai
foreign key (MaMuaGiai) references MUAGIAI(MaMuaGiai);
go
alter table CAUTHU
add constraint FK_CAUTHU_MaLoaiCauThu
foreign key (MaLoaiCauThu) references LOAICAUTHU(MaLoaiCauThu);
go
alter table CAUTHU
add constraint FK_CAUTHU_MaDoi
foreign key (MaDoi) references DOIBONG(MaDoi);
go
alter table LOAICAUTHU
add constraint FK_LOAICAUTHU_MaMuaGiai
foreign key (MaMuaGiai) references MUAGIAI(MaMuaGiai);
go
alter table TRANDAU
add constraint FK_TRANDAU_Doi
foreign key (DoiChuNha) references DOIBONG(MaDoi);
go
alter table TRANDAU
add constraint FK_TRANDAU2_Doi
foreign key (DoiKhach) references DOIBONG(MaDoi);
go
alter table TRANDAU
add constraint FK_TRANDAU_MaSanThiDau
foreign key (MaSanThiDau) references SanThiDau(MaSanThiDau);
go
alter table TRANDAU
add constraint FK_TRANDAU_MaSanThiDauChinh
foreign key (MaSanThiDauChinh) references SanThiDau(MaSanThiDau);
go
alter table TRANDAU
add constraint FK_TRANDAU_MaMuaGiai
foreign key (MaMuaGiai) references MUAGIAI(MaMuaGiai);
go
alter table TRANDAU
add constraint FK_TRANDAU_MaVongDau
foreign key (MaVongDau) references VONGDAU(MaVongDau);
go
alter table BANTHANG
add constraint FK_BANTHANG_LoaiBanThang
foreign key (MaLoaiBanThang) references LOAIBANTHANG(MaLoaiBanThang);
go
alter table BANTHANG
add constraint FK_BANTHANG_MaCauThu
foreign key (MaCauThu) references CAUTHU(MaCauThu);
go
alter table BANTHANG
add constraint FK_BANTHANG_MaTranDau
foreign key (MaTranDau) references TRANDAU(MaTranDau);
go
alter table LOAIBANTHANG
add constraint FK_LOAIBANTHANG_MaMuaGiai
foreign key (MaMuaGiai) references MUAGIAI(MaMuaGiai);
go
alter table DIEUKIEN
add constraint FK_DIEUKIEN_MaMuaGiai
foreign key (MaMuaGiai) references MUAGIAI(MaMuaGiai);
go
alter table SANTHIDAU
add constraint FK_SANTHIDAU_MaMuaGiai
foreign key (MaMuaGiai) references MUAGIAI(MaMuaGiai);
go
alter table SANTHIDAU
add constraint FK_SANTHIDAU_MaDoiNha
foreign key (MaDoiNha) references DOIBONG(MaDoi);
go
alter table KETQUADOIBONG
add constraint FK_KETQUADOIBONG_MaDoi
foreign key (MaDoi) references DOIBONG(MaDoi);
go
alter table THUTUUUTIEN
add constraint FK_THUTUUUTIEN_MaMuaGiai
foreign key (MaMuaGiai) references MUAGIAI(MaMuaGiai);
go
alter table DANHSACHTHAMGIA
add constraint FK_DANHSACHTHAMGIA_MaTranDau
foreign key (MaTranDau) references TRANDAU(MaTranDau);
go
alter table DANHSACHTHAMGIA
add constraint FK_DANHSACHTHAMGIA_MaCauThu
foreign key (MaCauThu) references CAUTHU(MaCauThu);
go
alter table VONGDAU
add constraint FK_VONGDAU_MaMuaGiai
foreign key (MaMuaGiai) references MUAGIAI(MaMuaGiai);
go
alter table PHATTHE
add constraint FK_PHATTHE_MaCauThu
foreign key (MaCauThu) references CAUTHU(MaCauThu);
go
alter table PHATTHE
add constraint FK_PHATTHE_MaTranDau
foreign key (MaTranDau) references TRANDAU(MaTranDau);
go
alter table PHATTHE
add constraint FK_PHATTHE_MaLoaiThe
foreign key (MaLoaiThe) references LoaiThe(MaLoaiThe);
go
alter table CHITIETTHAYNGUOI
add constraint FK_CHITIETTHAYNGUOI_MaCauThuVaoSan
foreign key (MaCauThuVaoSan) references CAUTHU(MaCauThu);
go
alter table CHITIETTHAYNGUOI
add constraint FK_CHITIETTHAYNGUOI_MaCauThuRaSan
foreign key (MaCauThuRaSan) references CAUTHU(MaCauThu);
go
alter table CHITIETTHAYNGUOI
add constraint FK_CHITIETTHAYNGUOI_MaTranDau
foreign key (MaTranDau) references TRANDAU(MaTranDau);
go
alter table BANGXEPHANG
add constraint FK_BANGXEPHANG_MaDoi
foreign key (MaDoi) references DOIBONG(MaDoi);
go
----DieuKienCauThu----
alter table CAUTHU
add constraint Tr_CAUTHU check(SoBanThang>=0);
go
----Dieukiendiem-----
alter table DIEUKIEN
add constraint Tr_DIEUKIEN_Diem check(DiemSoThang>DiemSoHoa and DiemSoHoa>DiemSoThua);
go
----DieuKienDau------------
alter table TRANDAU
add constraint Tr_TRANDAU_Doi check(DoiChuNha != DoiKhach);
--go
--alter table TRANDAU
--add constraint Tr_TRANDAU_SoBanThang check(SoBanThangDoiNha >=0 and SoBanThangDoiKhach >=0);
--go
------DieuKienDieuKien--------------
alter table DIEUKIEN
add constraint Tr_DIEUKIEN check(TuoitoiThieu>0 and TuoiToiDa>0 and SoCauThuToiThieu>0 and SoCauThuToiDa>0 and SoCauThuNuocNgoaiToiDa>=0 and SoLanThayNguoiToiDa>=0 and TuoiToiDa >= TuoiToiThieu and SoCauThuToiDa >= SoCauthuToiThieu);
go
------DieuKienTHUTUUUTIEN
alter table THUTUUUTIEN
add constraint Tr_THUTUUUTIEN check(ChiSoUuTien>0);
go
-------DieuKienBangXepHang---------
alter table BANGXEPHANG
add constraint Tr_BANGXEPHANG check(Thang>=0 and Thua>=0 and Hoa>=0 and Diem>=0 and XepHang>0 and SoBanThangSanKhach>=0);
go
----------DieuKienKetQuaDoiBong----------
alter table KETQUADOIBONG
add constraint Tr_KetQuaDoiBong check(Thang>=0 and Thua>=0 and Hoa>=0 and Diem>=0 and SoBanThangSanKhach>=0);
go
----------DieuKienCauThuDuBiKhacCauThuChinhThuc----------
alter table DANHSACHTHAMGIA 
add constraint Tr_DanhSachThamGia  check(CauThuDuBi != CauThuChinhThuc);
go
----------trigger BANTHANG-ThoiDiem--------------
create trigger Tr_BANTHANG_ThoiDiem_insert on BANTHANG
for insert
as
begin
	declare @ThoiDiemBanThang time, @ThoiGianThiDau time, @MaTranDau varchar(45)
	select @ThoiDiemBanThang = ThoiDiem, @MaTranDau = MaTranDau
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
----------trigger PHATTHE-ThoiDiem--------------
create trigger Tr_PHATTHE_ThoiDiem_insert on PHATTHE
for insert
as
begin
	declare @ThoiDiemPhatThe time, @ThoiGianThiDau time, @MaTranDau varchar(45)
	select @ThoiDiemPhatThe = ThoiDiem, @MaTranDau = MaTranDau
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
----------trigger CHITIETTHAYNGUOI-ThoiDiem--------------
create trigger Tr_CHITIETTHAYNGUOI_ThoiDiem_insert on CHITIETTHAYNGUOI
for insert
as
begin
	declare @ThoiDiemThayNguoi time, @ThoiGianThiDau time, @MaTranDau varchar(45)
	select @ThoiDiemThayNguoi = ThoiDiem, @MaTranDau = MaTranDau
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
-------------------------CauThuCoSoTheVangQuyDinh--------------------------
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
--------------------------TenSanDuyNhat-------------------------
create trigger Tr_SanThiDau_TenSan_insert on SANTHIDAU
for insert
as
begin
	declare @MaSanThiDau varchar(45), @TenSanThiDau nvarchar(45), @MaMuaGiai varchar(45),@SoSan int
	select @MaSanThiDau=MaSanThiDau,@TenSanThiDau=TenSanThiDau,@MaMuaGiai=MaMuaGiai
	from inserted
	select @SoSan=count(MaSanThiDau)
	from SANTHIDAU
	where SANTHIDAU.TenSanThiDau=@TenSanThiDau and SANTHIDAU.MaMuaGiai=@MaMuaGiai
	if (@SoSan>1)
	begin 
		print N'Lỗi: Sân thi đấu đã có'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện sân thi đấu không trùng lặp'
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
--------------------------TuoiCauThu-------------------------
create trigger Tr_CAUTHU_tuoi_insert on CAUTHU
for insert
as
begin
	declare @NgaySinh date, @Tuoi int,@TuoiToiThieu int, @TuoiToiDa int,@MaCauThu varchar(45)
	select @NgaySinh=NgaySinh,@MaCauThu=MaCauThu
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
		print N'Thỏa mãn điều kiện tuổi của cầu thủ'
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
--------------------------SoCauThuDieuKien-------------------------
create trigger Tr_CAUTHU_SoLuong_insert on CAUTHU
for insert
as
begin
	declare @MaDoi varchar(45), @SoCauThuToiDa int, @SoCauThuToiThieu int, @SoCauThu int,@MaCauThu varchar(45)
	select @MaDoi=MaDoi,@MaCauThu=MaCauThu
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
	if(@SoCauThu<@SoCauThuToiThieu)
	begin
		print N'Lưu ý: Số cầu thủ trong đội không đủ mức quy định'
	end
	if(@SoCauThu<=@SoCauThuToiDa and @SoCauThu>=@SoCauThuToiThieu)
		print N'Thảo mãn điều kiện số cầu thủ trong đội'
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
-----------------------------------------SoCauThuNuocNgoaiToiDa-----------------------------------
create trigger Tr_CAUTHU_NuocNgoai_insert on CAUTHU
for insert
as
begin
	declare @MaLoaiCauThu varchar(45), @MaDoi varchar(45),@SoCauThuNuocNgoaiToiDa int,@MaCauThu varchar(45),@SoCauThuNuocNgoai int
	select @MaLoaiCauThu=MaCauThu, @MaDoi=MaDoi, @MaCauThu=MaCauThu
	from inserted
	select @SoCauThuNuocNgoaiToiDa=SoCauThuNuocNgoaiToiDa
	from DIEUKIEN
	where MaMuaGiai=(select MaMuaGiai
	from CAUTHU inner join DOIBONG on CAUTHU.MaDoi=DOIBONG.MaDoi
	where CAUTHU.MaCauThu=@MaCauThu)
	select @SoCauThuNuocNgoai=count(distinct(MaCauThu))
	from CAUTHU inner join LOAICAUTHU on CAUTHU.MaLoaiCauThu=LOAICAUTHU.MaLoaiCauThu 
	where LOAICAUTHU.CauThuNuocNgoai=1 and MaDoi=@MaDoi
	if(@SoCauThuNuocNgoai>@SoCauThuNuocNgoaiToiDa)
	begin
		print N'Lỗi: Số cầu thủ nước ngoài vượt mức quy định'
		rollback transaction
	end
	else
	begin
		print N'Thỏa mãn điều kiện số cầu thủ nước ngoài'
	end
end
go
-------------------------------------------------------------------------------------------------------
create trigger Tr_CAUTHU_NuocNgoai_update on CAUTHU
for update
as
begin
	declare @MaLoaiCauThu varchar(45), @MaDoi varchar(45),@SoCauThuNuocNgoaiToiDa int,@MaCauThu varchar(45),@SoCauThuNuocNgoai int
	select @MaLoaiCauThu=MaCauThu, @MaDoi=MaDoi, @MaCauThu=MaCauThu
	from inserted
	select @SoCauThuNuocNgoaiToiDa=SoCauThuNuocNgoaiToiDa
	from DIEUKIEN
	where MaMuaGiai=(select MaMuaGiai
	from CAUTHU inner join DOIBONG on CAUTHU.MaDoi=DOIBONG.MaDoi
	where CAUTHU.MaCauThu=@MaCauThu)
	select @SoCauThuNuocNgoai=count(distinct(MaCauThu))
	from CAUTHU inner join LOAICAUTHU on CAUTHU.MaLoaiCauThu=LOAICAUTHU.MaLoaiCauThu
	where LOAICAUTHU.CauThuNuocNgoai=1 and MaDoi=@MaDoi
	if(@SoCauThuNuocNgoai>@SoCauThuNuocNgoaiToiDa)
	begin
		print N'Lỗi: Số cầu thủ nước ngoài vượt mức quy định'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện số cầu thủ nước ngoài'
end
go
-----------------------------------------SoLanThayNguoiToiDa-----------------------------------
create trigger Tr_CHITIETTHAYNGUOI_ThayNguoiToiDa_insert on CHITIETTHAYNGUOI
for insert
as
begin
	declare @MaTranDau varchar(45),@MaCauThuRaSan varchar(45), @MaCauThuVaoSan varchar(45), @ThayNguoiToiDa int,@ThayNguoi int,@MaThayNguoi varchar(45),@MaDoi varchar(45)
	select @MaTranDau=MaTranDau, @MaCauThuRaSan=MaCauThuRaSan, @MaCauThuVaoSan=MaCauThuVaoSan,@MaThayNguoi=MaThayNguoi
	from inserted
	select @ThayNguoiToiDa=SoLanThayNguoiToiDa
	from DIEUKIEN
	where MaMuaGiai=(select MaMuaGiai
		from CAUTHU inner join DOIBONG on CAUTHU.MaDoi=DOIBONG.MaDoi
		where CAUTHU.MaCauThu=@MaCauThuVaoSan)
	select @MaDoi = MaDoi 
	from CHITIETTHAYNGUOI inner join CAUTHU on CHITIETTHAYNGUOI.MaCauThuRaSan=CAUTHU.MaCauThu
	where CAUTHU.MaCauThu=@MaCauThuRaSan
	select @ThayNguoi=count(MaThayNguoi) from
	(
	select MaThayNguoi
	from CHITIETTHAYNGUOI
	where MaTranDau=@MaTranDau 
	INTERSECT 
	select MaThayNguoi
	from CHITIETTHAYNGUOI inner join CAUTHU on CHITIETTHAYNGUOI.MaCauThuRaSan=CAUTHU.MaCauThu
	where CAUTHU.MaDoi=@MaDoi
	) t
	if((select distinct(MaDoi) from CHITIETTHAYNGUOI join CAUTHU on CHITIETTHAYNGUOI.MaCauThuRaSan=CAUTHU.MaCauThu where CAUTHU.MaCauThu=@MaCauThuRaSan) != (select distinct(MaDoi) from CHITIETTHAYNGUOI join CAUTHU on CHITIETTHAYNGUOI.MaCauThuVaoSan=CAUTHU.MaCauThu where CAUTHU.MaCauThu=@MaCauThuVaoSan))
	begin
		print N'Lỗi: Hai cầu thủ không cùng đội bóng'
		rollback transaction
		return
	end
	else if(@ThayNguoi>@ThayNguoiToiDa)
	begin
		print N'Lỗi: Thay người quá quy định'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện số lần thay người tối đa'
end
go
-------------------------------------------------------------------------------------------------------
create trigger Tr_CHITIETTHAYNGUOI_ThayNguoiToiDa_update on CHITIETTHAYNGUOI
for update
as
begin
	declare @MaTranDau varchar(45),@MaCauThuRaSan varchar(45), @MaCauThuVaoSan varchar(45), @ThayNguoiToiDa int,@ThayNguoi int,@MaThayNguoi varchar(45),@MaDoi varchar(45)
	select @MaTranDau=MaTranDau, @MaCauThuRaSan=MaCauThuRaSan, @MaCauThuVaoSan=MaCauThuVaoSan,@MaThayNguoi=MaThayNguoi
	from inserted
	select @ThayNguoiToiDa=SoLanThayNguoiToiDa
	from DIEUKIEN
	where MaMuaGiai=(select MaMuaGiai
		from CAUTHU inner join DOIBONG on CAUTHU.MaDoi=DOIBONG.MaDoi
		where CAUTHU.MaCauThu=@MaCauThuVaoSan)
	select @MaDoi = MaDoi 
	from CHITIETTHAYNGUOI inner join CAUTHU on CHITIETTHAYNGUOI.MaCauThuRaSan=CAUTHU.MaCauThu
	where CAUTHU.MaCauThu=@MaCauThuRaSan
	select @ThayNguoi=count(MaThayNguoi) from
	(
	select MaThayNguoi
	from CHITIETTHAYNGUOI
	where MaTranDau=@MaTranDau 
	INTERSECT 
	select MaThayNguoi
	from CHITIETTHAYNGUOI inner join CAUTHU on CHITIETTHAYNGUOI.MaCauThuRaSan=CAUTHU.MaCauThu
	where CAUTHU.MaDoi=@MaDoi
	) t
	if((select distinct(MaDoi) from CHITIETTHAYNGUOI join CAUTHU on CHITIETTHAYNGUOI.MaCauThuRaSan=CAUTHU.MaCauThu where CAUTHU.MaCauThu=@MaCauThuRaSan) != (select distinct(MaDoi) from CHITIETTHAYNGUOI join CAUTHU on CHITIETTHAYNGUOI.MaCauThuVaoSan=CAUTHU.MaCauThu where CAUTHU.MaCauThu=@MaCauThuVaoSan))
	begin
		print N'Lỗi: Hai cầu thủ không cùng đội bóng'
		rollback transaction
		return
	end
	else if(@ThayNguoi>@ThayNguoiToiDa)
	begin
		print N'Lỗi: Thay người quá quy định'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện số lần thay người tối đa'
end
go
----------------------------------ThayNguoiPhaiONgoaiSan---------------------------------------------------------------------
create trigger Tr_CHITIETTHAYNGUOI_ThayNguoiNgoaiSan_insert on CHITIETTHAYNGUOI
for insert
as
begin
	declare @MaThayNguoi varchar(45), @MaCauThuVaoSan varchar(45), @MaCauThuRaSan varchar(45), @MaTranDau varchar(45), @ThoiDiem time,@KTRaSan varchar(45)
	select @MaThayNguoi=MaThayNguoi,@MaCauThuRaSan=MaCauThuRaSan,@MaCauThuVaoSan=MaCauThuVaoSan,@MaTranDau=MaTranDau, @ThoiDiem=ThoiDiem
	from inserted
	select @KTRaSan=MaCauThu from DANHSACHTHAMGIA where  MaCauThu=@MaCauThuRaSan and MaCauThu in
		(((select MaCauThu from DANHSACHTHAMGIA where CauThuChinhThuc=1 and MaTranDau=@MaTranDau)
		union
		(select MaCauThuVaoSan from CHITIETTHAYNGUOI where MaTranDau=@MaTranDau and ThoiDiem<@ThoiDiem))
		except
		(select MaCauThuRaSan from CHITIETTHAYNGUOI where MaTranDau=@MaTranDau and ThoiDiem<@ThoiDiem))
	if(@KTRaSan is NULL)
	begin
		print N'Lỗi: Cầu thủ ra sân không có mặt trên sân'
		rollback transaction
	end
	else if ((select CauThuDuBi from DANHSACHTHAMGIA where MaTranDau=@MaTranDau and MaCauThu=@MaCauThuVaoSan)!=1)
	begin
		print N'Lỗi: Cầu thủ vào sân không đúng quy định'
		rollback transaction
	end
	else if (not exists(select MaCauThu from DANHSACHTHAMGIA where MaTranDau=@MaTranDau and MaCauThu=@MaCauThuVaoSan))
	begin
		print N'Lỗi: Cầu thủ vào sân không nằm trong danh sách trận đấu'
		rollback transaction
	end
	else if (not exists(select MaCauThu from DANHSACHTHAMGIA where MaTranDau=@MaTranDau and MaCauThu=@MaCauThuRaSan))
	begin
		print N'Lỗi: Cầu thủ ra sân không nằm trong danh sách trận đấu'
		rollback transaction
	end
	else
	begin
		print N'Thỏa mãn điều kiện thay người'
	end
end
go
-----------------------------------------------------------------------------------------------------------------
create trigger Tr_CHITIETTHAYNGUOI_ThayNguoiNgoaiSan_update on CHITIETTHAYNGUOI
for update
as
begin
	declare @MaThayNguoi varchar(45), @MaCauThuVaoSan varchar(45), @MaCauThuRaSan varchar(45), @MaTranDau varchar(45), @ThoiDiem time,@KTRaSan varchar(45)
	select @MaThayNguoi=MaThayNguoi,@MaCauThuRaSan=MaCauThuRaSan,@MaCauThuVaoSan=MaCauThuVaoSan,@MaTranDau=MaTranDau, @ThoiDiem=ThoiDiem
	from inserted
	select @KTRaSan=MaCauThu from DANHSACHTHAMGIA where  MaCauThu=@MaCauThuRaSan and MaCauThu in
		(((select MaCauThu from DANHSACHTHAMGIA where CauThuChinhThuc=1 and MaTranDau=@MaTranDau)
		union
		(select MaCauThuVaoSan from CHITIETTHAYNGUOI where MaTranDau=@MaTranDau and ThoiDiem<@ThoiDiem))
		except
		(select MaCauThuRaSan from CHITIETTHAYNGUOI where MaTranDau=@MaTranDau and ThoiDiem<@ThoiDiem))
	if(@KTRaSan is NULL)
	begin
		print N'Lỗi: Cầu thủ ra sân không có mặt trên sân'
		rollback transaction
	end
	else if ((select CauThuDuBi from DANHSACHTHAMGIA where MaTranDau=@MaTranDau and MaCauThu=@MaCauThuVaoSan)!=1)
	begin
		print N'Lỗi: Cầu thủ vào sân không đúng quy định'
		rollback transaction
	end
	else if (not exists(select MaCauThu from DANHSACHTHAMGIA where MaTranDau=@MaTranDau and MaCauThu=@MaCauThuVaoSan))
	begin
		print N'Lỗi: Cầu thủ vào sân không nằm trong danh sách trận đấu'
		rollback transaction
	end
	else if (not exists(select MaCauThu from DANHSACHTHAMGIA where MaTranDau=@MaTranDau and MaCauThu=@MaCauThuRaSan))
	begin
		print N'Lỗi: Cầu thủ ra sân không nằm trong danh sách trận đấu'
		rollback transaction
	end
	else
	begin
		print N'Thỏa mãn điều kiện thay người'
	end
end
go
---------------------------CauThuTrongDanhSachThiDauPhaiThuocDoiBong--------------------------------------------------------------------------------------
create trigger Tr_DANHSACHTHAMGIA_CauThuTrongDoiBong_insert on DANHSACHTHAMGIA
for insert
as
begin
	declare @MaTranDau varchar(45), @MaCauThu varchar(45), @CauThuDuBi bit, @CauThuChinhThuc bit, @MaDoi varchar(45)
	select @MaTranDau=MaTranDau, @MaCauThu=MaCauThu, @CauThuDuBi=CauThuDuBi,@CauThuChinhThuc=CauThuChinhThuc
	from inserted
	select @MaDoi=MaDoi
	from CAUTHU
	where MaCauThu=@MaCauThu
	if((@MaDoi != (select DoiChuNha from TRANDAU where MaTranDau=@MaTranDau))and(@MaDoi != (select DoiKhach from TRANDAU where MaTranDau=@MaTranDau)))
	begin
		print N'Cầu thủ không nằm trong đội bóng'
		rollback transaction
	end
	else 
	begin
		print N'Thỏa mãn điều kiện cầu thủ nằm trong đội bóng'
	end
end
go
---------------------------------------------------------------------------------------------------------------
create trigger Tr_DANHSACHTHAMGIA_CauThuTrongDoiBong_update on DANHSACHTHAMGIA
for update
as
begin
	declare @MaTranDau varchar(45), @MaCauThu varchar(45), @CauThuDuBi bit, @CauThuChinhThuc bit, @MaDoi varchar(45)
	select @MaTranDau=MaTranDau, @MaCauThu=MaCauThu, @CauThuDuBi=CauThuDuBi,@CauThuChinhThuc=CauThuChinhThuc
	from inserted
	select @MaDoi=MaDoi
	from CAUTHU
	where MaCauThu=@MaCauThu
	if((@MaDoi != (select DoiChuNha from TRANDAU where MaTranDau=@MaTranDau))and(@MaDoi != (select DoiKhach from TRANDAU where MaTranDau=@MaTranDau)))
	begin
		print N'Cầu thủ không nằm trong đội bóng'
		rollback transaction
	end
	else 
	begin
		print N'Thỏa mãn điều kiện cầu thủ nằm trong đội bóng'
	end
end
go
-----------------------------------GhiBanlonHonThoiGianthayVao----------------------------------------------------------------------------
create trigger Tr_BANTHANG_thoiGianGhiBan_insert on BANTHANG
for insert
as
begin
	declare @MaBanThang varchar(45), @MaCauThu varchar(45),@ThoiDiem time, @MaTranDau varchar(45), @LoaiCauThu int,@KTRaSan varchar(45)
	select @MaBanThang=MaBanThang,@MaCauThu=MaCauThu,@ThoiDiem=ThoiDiem,@MaTranDau=MaTranDau
	from inserted
	select @LoaiCauThu=CauThuDuBi
	from DANHSACHTHAMGIA
	where MaCauThu=@MaCauThu
	select @KTRaSan=MaCauThu from DANHSACHTHAMGIA where  MaCauThu=@MaCauThu and MaCauThu in
		(((select MaCauThu from DANHSACHTHAMGIA where CauThuChinhThuc=1 and MaTranDau=@MaTranDau)
		union
		(select MaCauThuVaoSan from CHITIETTHAYNGUOI where MaTranDau=@MaTranDau and ThoiDiem<@ThoiDiem))
		except
		(select MaCauThuRaSan from CHITIETTHAYNGUOI where MaTranDau=@MaTranDau and ThoiDiem<@ThoiDiem))
	if(@KTRaSan is NULL)
	begin
		print N'Lỗi: Cầu thủ ghi bàn không có mặt trên sân'
		rollback transaction
	end
	else if(@LoaiCauThu is NULL)
	begin
		print N'Lỗi: Cầu thủ không có trong danh sách trận đấu'
		rollback transaction
	end
	else if(@LoaiCauThu=1 and @ThoiDiem<(select ThoiDiem from CHITIETTHAYNGUOI where MaCauThuVaoSan=@MaCauThu))
	begin
		print N'Lỗi: Cầu thủ dự bị ghi bàn sai thời gian quy định'
		rollback transaction
	end
	else if(@LoaiCauThu=0 and @ThoiDiem>(select ThoiDiem from CHITIETTHAYNGUOI where MaCauThuRaSan=@MaCauThu))
	begin
		print N'Lỗi: Cầu thủ chính thức ghi bàn sai thời gian quy định'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện ghi bàn với thời gian bắt buộc'

end
go
------------------------------------------------------------------------------------------------------------
create trigger Tr_BANTHANG_thoiGianGhiBan_update on BANTHANG
for update
as
begin
	declare @MaBanThang varchar(45), @MaCauThu varchar(45),@ThoiDiem time, @MaTranDau varchar(45), @LoaiCauThu int,@KTRaSan varchar(45)
	select @MaBanThang=MaBanThang,@MaCauThu=MaCauThu,@ThoiDiem=ThoiDiem,@MaTranDau=MaTranDau
	from inserted
	select @LoaiCauThu=CauThuDuBi
	from DANHSACHTHAMGIA
	where MaCauThu=@MaCauThu
	select @KTRaSan=MaCauThu from DANHSACHTHAMGIA where  MaCauThu=@MaCauThu and MaCauThu in
		(((select MaCauThu from DANHSACHTHAMGIA where CauThuChinhThuc=1 and MaTranDau=@MaTranDau)
		union
		(select MaCauThuVaoSan from CHITIETTHAYNGUOI where MaTranDau=@MaTranDau and ThoiDiem<@ThoiDiem))
		except
		(select MaCauThuRaSan from CHITIETTHAYNGUOI where MaTranDau=@MaTranDau and ThoiDiem<@ThoiDiem))
	if(@KTRaSan is NULL)
	begin
		print N'Lỗi: Cầu thủ ghi bàn không có mặt trên sân'
		rollback transaction
	end
	if(@LoaiCauThu is NULL)
	begin
		print N'Lỗi: Cầu thủ không có trong danh sách trận đấu'
		rollback transaction
	end
	else if(@LoaiCauThu=1 and @ThoiDiem<(select ThoiDiem from CHITIETTHAYNGUOI where MaCauThuVaoSan=@MaCauThu))
	begin
		print N'Lỗi: Cầu thủ dự bị ghi bàn sai thời gian quy định'
		rollback transaction
	end
	else if(@LoaiCauThu=0 and @ThoiDiem>(select ThoiDiem from CHITIETTHAYNGUOI where MaCauThuRaSan=@MaCauThu))
	begin
		print N'Lỗi: Cầu thủ chính thức ghi bàn sai thời gian quy định'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện ghi bàn với thời gian bắt buộc'

end
go
-------------------------------TySoTranDau-----------------------------------------------------------------------------
create trigger Tr_BANTHANG_TySo_insert on BANTHANG
for insert
as
begin
	declare @MaBanThang varchar(45),@MaCauThu varchar(45),@MaLoaiBanThang varchar(45), @MaTranDau varchar(45),@ThoiDiem time
	select @MaBanThang=MaBanThang,@MaCauThu=MaCauThu,@MaLoaiBanThang=MaLoaiBanThang,@MaTranDau=MaTranDau,@ThoiDiem=ThoiDiem
	from inserted
	update TRANDAU
	set SoBanThangDoiKhach=0
	where MaTranDau=@MaTranDau and SoBanThangDoiKhach is null
	update TRANDAU
	set  SoBanThangDoiNha=0
	where MaTranDau=@MaTranDau and SoBanThangDoiNha is null
	if((select TinhBanChoCauThu from LOAIBANTHANG where MaLoaiBanThang=@MaLoaiBanThang)=1)
    begin
		if((select DoiChuNha from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiNha=SoBanThangDoiNha+1
			where MaTranDau=@MaTranDau
		end
		else if((select DoiKhach from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiKhach=SoBanThangDoiKhach+1
			where MaTranDau=@MaTranDau
		end
		else
		begin
			print N'Lỗi: Cầu thủ không có trong đội bóng'
			rollback transaction
		end
	end
	else
	begin
		if((select DoiChuNha from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiKhach=SoBanThangDoiKhach+1
			where MaTranDau=@MaTranDau
		end
		else if((select DoiKhach from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiNha=SoBanThangDoiNha+1
			where MaTranDau=@MaTranDau
		end
		else
		begin
			print N'Lỗi: Cầu thủ không có trong đội bóng'
			rollback transaction
		end
	end
end
go
------------------------------------------------------------------------------------------------------------
create trigger Tr_BANTHANG_TySo_deleted on BANTHANG
for delete
as
begin
	declare @MaBanThang varchar(45),@MaCauThu varchar(45),@MaLoaiBanThang varchar(45), @MaTranDau varchar(45),@ThoiDiem time
	select @MaBanThang=MaBanThang,@MaCauThu=MaCauThu,@MaLoaiBanThang=MaLoaiBanThang,@MaTranDau=MaTranDau,@ThoiDiem=ThoiDiem
	from deleted
	update TRANDAU
	set SoBanThangDoiKhach=0
	where MaTranDau=@MaTranDau and SoBanThangDoiKhach is null
	update TRANDAU
	set  SoBanThangDoiNha=0
	where MaTranDau=@MaTranDau and SoBanThangDoiNha is null
	if((select TinhBanChoCauThu from LOAIBANTHANG where MaLoaiBanThang=@MaLoaiBanThang)=1)
    begin
		if((select DoiChuNha from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiNha=SoBanThangDoiNha-1
			where MaTranDau=@MaTranDau
		end
		else if((select DoiKhach from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiKhach=SoBanThangDoiKhach-1
			where MaTranDau=@MaTranDau
		end
		else
		begin
			print N'Lỗi: Cầu thủ không có trong đội bóng'
			rollback transaction
		end
	end
	else
	begin
		if((select DoiChuNha from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiKhach=SoBanThangDoiKhach-1
			where MaTranDau=@MaTranDau
		end
		else if((select DoiKhach from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiNha=SoBanThangDoiNha-1
			where MaTranDau=@MaTranDau
		end
		else
		begin
			print N'Lỗi: Cầu thủ không có trong đội bóng'
			rollback transaction
		end
	end
end
go
------------------------------------------------------------------------------------------------------------
create trigger Tr_BANTHANG_TySo_update on BANTHANG
for update
as
begin
	declare @MaBanThang varchar(45),@MaCauThu varchar(45),@MaLoaiBanThang varchar(45), @MaTranDau varchar(45),@ThoiDiem time
	select @MaBanThang=MaBanThang,@MaCauThu=MaCauThu,@MaLoaiBanThang=MaLoaiBanThang,@MaTranDau=MaTranDau,@ThoiDiem=ThoiDiem
	from inserted
	update TRANDAU
	set SoBanThangDoiKhach=0
	where MaTranDau=@MaTranDau and SoBanThangDoiKhach is null
	update TRANDAU
	set  SoBanThangDoiNha=0
	where MaTranDau=@MaTranDau and SoBanThangDoiNha is null
	if((select TinhBanChoCauThu from LOAIBANTHANG where MaLoaiBanThang=@MaLoaiBanThang)=1)
    begin
		if((select DoiChuNha from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiNha=SoBanThangDoiNha+1
			where MaTranDau=@MaTranDau
		end
		else if((select DoiKhach from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiKhach=SoBanThangDoiKhach+1
			where MaTranDau=@MaTranDau
		end
		else
		begin
			print N'Lỗi: Cầu thủ không có trong đội bóng'
			rollback transaction
		end
	end
	else
	begin
		if((select DoiChuNha from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiKhach=SoBanThangDoiKhach+1
			where MaTranDau=@MaTranDau
		end
		else if((select DoiKhach from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiNha=SoBanThangDoiNha+1
			where MaTranDau=@MaTranDau
		end
		else
		begin
			print N'Lỗi: Cầu thủ không có trong đội bóng'
			rollback transaction
		end
	end

	select @MaBanThang=MaBanThang,@MaCauThu=MaCauThu,@MaLoaiBanThang=MaLoaiBanThang,@MaTranDau=MaTranDau,@ThoiDiem=ThoiDiem
	from deleted
	update TRANDAU
	set SoBanThangDoiKhach=0
	where MaTranDau=@MaTranDau and SoBanThangDoiKhach is null
	update TRANDAU
	set  SoBanThangDoiNha=0
	where MaTranDau=@MaTranDau and SoBanThangDoiNha is null
	if((select TinhBanChoCauThu from LOAIBANTHANG where MaLoaiBanThang=@MaLoaiBanThang)=1)
    begin
		if((select DoiChuNha from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiNha=SoBanThangDoiNha-1
			where MaTranDau=@MaTranDau
		end
		else if((select DoiKhach from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiKhach=SoBanThangDoiKhach-1
			where MaTranDau=@MaTranDau
		end
		else
		begin
			print N'Lỗi: Cầu thủ không có trong đội bóng'
			rollback transaction
		end
	end
	else
	begin
		if((select DoiChuNha from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiKhach=SoBanThangDoiKhach-1
			where MaTranDau=@MaTranDau
		end
		else if((select DoiKhach from TRANDAU where MaTranDau=@MaTranDau)=(select MaDoi from CAUTHU where MaCauThu=@MaCauThu))
		begin
			update TRANDAU
			set SoBanThangDoiNha=SoBanThangDoiNha-1
			where MaTranDau=@MaTranDau
		end
		else
		begin
			print N'Lỗi: Cầu thủ không có trong đội bóng'
			rollback transaction
		end
	end
end
go
-------------------------------capNhatBanThangCauThu-----------------------------------------------------------------------------
create trigger Tr_BANTHANG_SoBanThang_insert on BANTHANG
for insert
as
begin
	declare @MaBanThang varchar(45),@MaCauThu varchar(45), @MaLoaiBanThang varchar(45)
	select @MaBanThang=MaBanThang,@MaCauThu=MaCauThu,@MaLoaiBanThang=MaLoaiBanThang
	from inserted
	if((select TinhBanChoCauThu from LOAIBANTHANG where MaLoaiBanThang=@MaLoaiBanThang)=1)
	begin
		if((select SoBanThang from CAUTHU where MaCauThu=@MaCauThu) is null)
		begin
			update CAUTHU
			set SoBanThang=1
			where MaCauThu=@MaCauThu
		end
		else
		begin
			update CAUTHU
			set SoBanThang+=1
			where MaCauThu=@MaCauThu
		end
	end	
end
go
------------------------------------------------------------------------------------------------------------
create trigger Tr_BANTHANG_SoBanThang_delete on BANTHANG
for delete
as
begin
	declare @MaBanThang varchar(45),@MaCauThu varchar(45), @MaLoaiBanThang varchar(45)
	select @MaBanThang=MaBanThang,@MaCauThu=MaCauThu,@MaLoaiBanThang=MaLoaiBanThang
	from deleted
	if((select TinhBanChoCauThu from LOAIBANTHANG where MaLoaiBanThang=@MaLoaiBanThang)=1)
	begin
		if((select SoBanThang from CAUTHU where MaCauThu=@MaCauThu) is null)
		begin
			update CAUTHU
			set SoBanThang=0
			where MaCauThu=@MaCauThu
		end
		else
		begin
			update CAUTHU
			set SoBanThang-=1
			where MaCauThu=@MaCauThu
		end
	end	
end
go
------------------------------------------------------------------------------------------------------------
create trigger Tr_BANTHANG_SoBanThang_update on BANTHANG
for update
as
begin
	declare @MaBanThang varchar(45),@MaCauThu varchar(45), @MaLoaiBanThang varchar(45)
	select @MaBanThang=MaBanThang,@MaCauThu=MaCauThu,@MaLoaiBanThang=MaLoaiBanThang
	from inserted
	if((select TinhBanChoCauThu from LOAIBANTHANG where MaLoaiBanThang=@MaLoaiBanThang)=1)
	begin
		if((select SoBanThang from CAUTHU where MaCauThu=@MaCauThu) is null)
		begin
			update CAUTHU
			set SoBanThang=1
			where MaCauThu=@MaCauThu
		end
		else
		begin
			update CAUTHU
			set SoBanThang+=1
			where MaCauThu=@MaCauThu
		end
	end	

	select @MaBanThang=MaBanThang,@MaCauThu=MaCauThu,@MaLoaiBanThang=MaLoaiBanThang
	from deleted
	if((select TinhBanChoCauThu from LOAIBANTHANG where MaLoaiBanThang=@MaLoaiBanThang)=1)
	begin
		if((select SoBanThang from CAUTHU where MaCauThu=@MaCauThu) is null)
		begin
			update CAUTHU
			set SoBanThang=0
			where MaCauThu=@MaCauThu
		end
		else
		begin
			update CAUTHU
			set SoBanThang-=1
			where MaCauThu=@MaCauThu
		end
	end	
end
go
-------------------------------KetQuaDoiBong-----------------------------------------------------------------------------
create procedure KQ @MaTranDau varchar(45)
as
begin
	declare @DoiChuNha varchar(45),@DoiKhach varchar(45), @SoBanThangDoiNha varchar(45), @SoBanThangDoiKhach varchar(45),@Thang int, @Thua int,@Hoa int
	select @DoiChuNha=DoiChuNha,@DoiKhach=DoiKhach,@SoBanThangDoiKhach=SoBanThangDoiKhach,@SoBanThangDoiNha=SoBanThangDoiNha
	from TRANDAU
	where MaTranDau=@MaTranDau
	select @Thang=DiemSoThang,@Thua=DiemSoThua,@Hoa=DiemSoHoa
	from DIEUKIEN
	where MaMuaGiai=(select MaMuaGiai from DOIBONG where MaDoi=@DoiKhach)
	update KETQUADOIBONG
	set Thang=0
	where Thang is null 
	update KETQUADOIBONG
	set Thua=0
	where Thua is null 
	update KETQUADOIBONG
	set Hoa=0
	where Hoa is null 
	update KETQUADOIBONG
	set HieuSo=0
	where HieuSo is null 
	update KETQUADOIBONG
	set SoBanThangSanKhach=0
	where SoBanThangSanKhach is null 
	update KETQUADOIBONG
	set Diem=0
	where Diem is null
	if(@SoBanThangDoiNha>@SoBanThangDoiKhach)
	begin
		update KETQUADOIBONG
		set Thua=Thua+1,Diem=Diem+@Thua,HieuSo=HieuSo-@SoBanThangDoiNha+@SoBanThangDoiKhach,SoBanThangSanKhach=SoBanThangSanKhach+@SoBanThangDoiKhach
		where MaDoi=@DoiKhach

		update KETQUADOIBONG
		set Thang=Thang+1,Diem=Diem+@Thang,HieuSo=HieuSo+@SoBanThangDoiNha-@SoBanThangDoiKhach
		where MaDoi=@DoiChuNha
	end
	else if(@SoBanThangDoiNha=@SoBanThangDoiKhach)
	begin
		update KETQUADOIBONG
		set Hoa=Hoa+1,Diem=Diem+@Hoa,SoBanThangSanKhach=SoBanThangSanKhach+@SoBanThangDoiKhach
		where MaDoi=@DoiKhach

		update KETQUADOIBONG
		set Hoa=Hoa+1,Diem=Diem+@Hoa
		where MaDoi=@DoiChuNha
	end
	else if(@SoBanThangDoiNha<@SoBanThangDoiKhach)
	begin
		update KETQUADOIBONG
		set Thua=Thua+1,Diem=Diem+@Thua,HieuSo=HieuSo+@SoBanThangDoiNha-@SoBanThangDoiKhach,SoBanThangSanKhach=SoBanThangSanKhach+@SoBanThangDoiKhach
		where MaDoi=@DoiChuNha

		update KETQUADOIBONG
		set Thang=Thang+1,Diem=Diem+@Thang,HieuSo=HieuSo-@SoBanThangDoiNha+@SoBanThangDoiKhach
		where MaDoi=@DoiKhach
	end
end
go
------------------------------------------------------------------------------------------------------------
create trigger Tr_KETQUADOIBONG_TranDau_delete on TRANDAU
for delete
as
begin
	declare @DoiChuNha varchar(45),@DoiKhach varchar(45), @SoBanThangDoiNha varchar(45), @SoBanThangDoiKhach varchar(45),@Thang int, @Thua int,@Hoa int,@MaTranDau varchar(45), @KTDel bit
	select @DoiChuNha=DoiChuNha,@DoiKhach=DoiKhach,@SoBanThangDoiKhach=SoBanThangDoiKhach,@SoBanThangDoiNha=SoBanThangDoiNha
	from deleted
	select @Thang=DiemSoThang,@Thua=DiemSoThua,@Hoa=DiemSoHoa
	from DIEUKIEN
	where MaMuaGiai=(select MaMuaGiai from DOIBONG where MaDoi=@DoiKhach)
	if(@SoBanThangDoiKhach is null and @SoBanThangDoiNha is null)
		set @KTDel = 0
	else
		set @KTDel=1
	if(@KTDel=1)
	begin
		if(@SoBanThangDoiNha>@SoBanThangDoiKhach)
		begin
			update KETQUADOIBONG
			set Thua=Thua-1,Diem=Diem-@Thua,HieuSo=HieuSo+@SoBanThangDoiNha-@SoBanThangDoiKhach,SoBanThangSanKhach=SoBanThangSanKhach-@SoBanThangDoiKhach
			where MaDoi=@DoiKhach

			update KETQUADOIBONG
			set Thang=Thang-1,Diem=Diem-@Thang,HieuSo=HieuSo-@SoBanThangDoiNha+@SoBanThangDoiKhach
			where MaDoi=@DoiChuNha
		end
		else if(@SoBanThangDoiNha=@SoBanThangDoiKhach)
		begin
			update KETQUADOIBONG
			set Hoa=Hoa-1,Diem=Diem-@Hoa,SoBanThangSanKhach=SoBanThangSanKhach-@SoBanThangDoiKhach
			where MaDoi=@DoiKhach

			update KETQUADOIBONG
			set Hoa=Hoa-1,Diem=Diem-@Hoa
			where MaDoi=@DoiChuNha
		end
		else if(@SoBanThangDoiNha<@SoBanThangDoiKhach)
		begin
			update KETQUADOIBONG
			set Thua=Thua-1,Diem=Diem-@Thua,HieuSo=HieuSo-@SoBanThangDoiNha+@SoBanThangDoiKhach
			where MaDoi=@DoiChuNha

			update KETQUADOIBONG
			set Thang=Thang-1,Diem=Diem-@Thang,HieuSo=HieuSo+@SoBanThangDoiNha-@SoBanThangDoiKhach,SoBanThangSanKhach=SoBanThangSanKhach-@SoBanThangDoiKhach
			where MaDoi=@DoiKhach
		end
	end
end
go
------------------------------------------------------------------------------------------------------------
create trigger Tr_KETQUADOIBONG_TranDau_update on TRANDAU
for update
as
begin
	declare @DoiChuNha varchar(45),@DoiKhach varchar(45), @SoBanThangDoiNha varchar(45), @SoBanThangDoiKhach varchar(45),@Thang int, @Thua int,@Hoa int, @KT bit
	select @DoiChuNha=DoiChuNha,@DoiKhach=DoiKhach,@SoBanThangDoiKhach=SoBanThangDoiKhach,@SoBanThangDoiNha=SoBanThangDoiNha
	from inserted
	select @Thang=DiemSoThang,@Thua=DiemSoThua,@Hoa=DiemSoHoa
	from DIEUKIEN
	where MaMuaGiai=(select MaMuaGiai from DOIBONG where MaDoi=@DoiKhach)
	if(@SoBanThangDoiKhach is null and @SoBanThangDoiNha is null)
		set @KT = 0
	else
		set @KT=1
	if(@KT=1)
	begin
		if(@SoBanThangDoiNha>@SoBanThangDoiKhach)
		begin
			update KETQUADOIBONG
			set Thua=Thua+1,Diem=Diem+@Thua,HieuSo=HieuSo-@SoBanThangDoiNha+@SoBanThangDoiKhach,SoBanThangSanKhach=SoBanThangSanKhach+@SoBanThangDoiKhach
			where MaDoi=@DoiKhach

			update KETQUADOIBONG
			set Thang=Thang+1,Diem=Diem+@Thang,HieuSo=HieuSo+@SoBanThangDoiNha-@SoBanThangDoiKhach
			where MaDoi=@DoiChuNha
		end
		else if(@SoBanThangDoiNha=@SoBanThangDoiKhach)
		begin
			update KETQUADOIBONG
			set Hoa=Hoa+1,Diem=Diem+@Hoa,SoBanThangSanKhach=SoBanThangSanKhach+@SoBanThangDoiKhach
			where MaDoi=@DoiKhach

			update KETQUADOIBONG
			set Hoa=Hoa+1,Diem=Diem+@Hoa
			where MaDoi=@DoiChuNha
		end
		else if(@SoBanThangDoiNha<@SoBanThangDoiKhach)
		begin
			update KETQUADOIBONG
			set Thua=Thua+1,Diem=Diem+@Thua,HieuSo=HieuSo+@SoBanThangDoiNha-@SoBanThangDoiKhach
			where MaDoi=@DoiChuNha

			update KETQUADOIBONG
			set Thang=Thang+1,Diem=Diem+@Thang,HieuSo=HieuSo-@SoBanThangDoiNha+@SoBanThangDoiKhach,SoBanThangSanKhach=SoBanThangSanKhach+@SoBanThangDoiKhach
			where MaDoi=@DoiKhach
		end
	end
	select @DoiChuNha=DoiChuNha,@DoiKhach=DoiKhach,@SoBanThangDoiKhach=SoBanThangDoiKhach,@SoBanThangDoiNha=SoBanThangDoiNha
	from deleted
	select @Thang=DiemSoThang,@Thua=DiemSoThua,@Hoa=DiemSoHoa
	from DIEUKIEN
	where MaMuaGiai=(select MaMuaGiai from DOIBONG where MaDoi=@DoiKhach)
	if(@SoBanThangDoiKhach is null and @SoBanThangDoiNha is null)
		set @KT = 0
	else
		set @KT=1
	if(@KT=1)
	begin
		if(@SoBanThangDoiNha>@SoBanThangDoiKhach)
		begin
			update KETQUADOIBONG
			set Thua=Thua-1,Diem=Diem-@Thua,HieuSo=HieuSo+@SoBanThangDoiNha-@SoBanThangDoiKhach,SoBanThangSanKhach=SoBanThangSanKhach-@SoBanThangDoiKhach
			where MaDoi=@DoiKhach

			update KETQUADOIBONG
			set Thang=Thang-1,Diem=Diem-@Thang,HieuSo=HieuSo-@SoBanThangDoiNha+@SoBanThangDoiKhach
			where MaDoi=@DoiChuNha
		end
		else if(@SoBanThangDoiNha=@SoBanThangDoiKhach)
		begin
			update KETQUADOIBONG
			set Hoa=Hoa-1,Diem=Diem-@Hoa,SoBanThangSanKhach=SoBanThangSanKhach-@SoBanThangDoiKhach
			where MaDoi=@DoiKhach

			update KETQUADOIBONG
			set Hoa=Hoa-1,Diem=Diem-@Hoa
			where MaDoi=@DoiChuNha
		end
		else if(@SoBanThangDoiNha<@SoBanThangDoiKhach)
		begin
			update KETQUADOIBONG
			set Thua=Thua-1,Diem=Diem-@Thua,HieuSo=HieuSo-@SoBanThangDoiNha+@SoBanThangDoiKhach
			where MaDoi=@DoiChuNha

			update KETQUADOIBONG
			set Thang=Thang-1,Diem=Diem-@Thang,HieuSo=HieuSo+@SoBanThangDoiNha-@SoBanThangDoiKhach,SoBanThangSanKhach=SoBanThangSanKhach-@SoBanThangDoiKhach
			where MaDoi=@DoiKhach
		end
	end
end
go
-------------------------------KoDauQua2lan-----------------------------------------------------------------------------
create trigger Tr_TRANDAU_LanDau_insert on TranDau
for insert
as
begin
	declare @MaTranDau varchar(45),@MaMuaGiai varchar(45),@DoiChuNha varchar(45),@DoiKhach varchar(45),@SoLanDau int
	select @MaTranDau=MaTranDau,@MaMuaGiai=MaMuaGiai,@DoiChuNha=DoiChuNha,@DoiKhach=DoiKhach
	from inserted
	select @SoLanDau=count(MaTranDau)
	from TRANDAU
	where DoiChuNha=@DoiChuNha and DoiKhach=@DoiKhach
	if(@SoLanDau>1)
	begin
		print N'Đã có 1 trận đấu giữa hai đội bóng'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện hai đội thi đấu không quá 2 lần'
end
go
------------------------------------------------------------------------------------------------------------
create trigger Tr_TRANDAU_LanDau_update on TranDau
for update
as
begin
	declare @MaTranDau varchar(45),@MaMuaGiai varchar(45),@DoiChuNha varchar(45),@DoiKhach varchar(45),@SoLanDau int
	select @MaTranDau=MaTranDau,@MaMuaGiai=MaMuaGiai,@DoiChuNha=DoiChuNha,@DoiKhach=DoiKhach
	from inserted
	select @SoLanDau=count(MaTranDau)
	from TRANDAU
	where DoiChuNha=@DoiChuNha and DoiKhach=@DoiKhach
	if(@SoLanDau>1)
	begin
		print N'Đã có 1 trận đấu giữa hai đội bóng'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện hai đội thi đấu không quá 2 lần'
end
go
-------------------------------NgayThiDauTranDau-----------------------------------------------------------------------------
create trigger Tr_TRANDAU_Ngaydau_insert on TranDau
for insert
as
begin
	declare @NgayThiDau date,@MaTranDau varchar(45),@DoiChuNha varchar(45),@DoiKhach varchar(45)
	select @NgayThiDau=NgayThiDau,@MaTranDau=MaTranDau,@DoiChuNha=DoiChuNha,@DoiKhach=DoiKhach,@NgayThiDau=NgayThiDau
	from inserted
	if((select count(MaTranDau) from TRANDAU where (DoiChuNha=@DoiChuNha or DoiKhach=@DoiChuNha)and NgayThiDau=@NgayThiDau)>1)
	begin
		print N'Đội chủ nhà đã có trận đấu trong ngày'
		rollback transaction
	end
	else if((select count(MaTranDau) from TRANDAU where (DoiChuNha=@DoiKhach or DoiKhach=@DoiKhach)and NgayThiDau=@NgayThiDau)>1)
	begin
		print N'Đội khách đã có trận đấu trong ngày'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện đội bóng không thi đấu quá 1 trận 1 ngày'
end
go
---------------------------------------------------------------------------------------------------------
create trigger Tr_TRANDAU_Ngaydau_update on TranDau
for update
as
begin
	declare @NgayThiDau date,@MaTranDau varchar(45),@DoiChuNha varchar(45),@DoiKhach varchar(45)
	select @NgayThiDau=NgayThiDau,@MaTranDau=MaTranDau,@DoiChuNha=DoiChuNha,@DoiKhach=DoiKhach,@NgayThiDau=NgayThiDau
	from inserted
	if((select count(MaTranDau) from TRANDAU where (DoiChuNha=@DoiChuNha or DoiKhach=@DoiChuNha)and NgayThiDau=@NgayThiDau)>1)
	begin
		print N'Đội chủ nhà đã có trận đấu trong ngày'
		rollback transaction
	end
	else if((select count(MaTranDau) from TRANDAU where (DoiChuNha=@DoiKhach or DoiKhach=@DoiKhach)and NgayThiDau=@NgayThiDau)>1)
	begin
		print N'Đội khách đã có trận đấu trong ngày'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện đội bóng không thi đấu quá 1 trận 1 ngày'
end
go
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

	select @MaTheVang= MaLoaiThe
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

	select @MaTheVang= MaLoaiThe
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
--------------------------TenMuaGiaiDuyNhat-------------------------
create trigger Tr_MuaGiai_Ten on MUAGIAI
for insert, update
as
begin
	declare @TenMuaGiai nvarchar(45), @MaMuaGiai varchar(45),@SoLuong int
	select @TenMuaGiai=TenMuaGiai,@MaMuaGiai=MaMuaGiai
	from inserted
	select @SoLuong=count(MaMuaGiai)
	from MUAGIAI
	where TenMuaGiai=@TenMuaGiai
	if (@SoLuong>1)
	begin 
		print N'Lỗi: Tên mùa giải đả tồn tại'
		rollback transaction
	end
	else
		print N'Thỏa mãn điều kiện mùa giải không trùng lặp'
end
go
--------------------------TenDoiBongDuyNhat-------------------------
create trigger Tr_DoiBong_Ten on DOIBONG
for insert, update
as
begin
	declare @MaDoi varchar(45),@TenDoi nvarchar(45),@MaMuaGiai varchar(45),@SoLuong int
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

-----------------------------CapNhatbangXepHang---------------------------------------------------------
create procedure BXH @MaMuaGiai varchar(45)
as
begin
	declare @Ngay date,@UuTien1 nvarchar(45),@UuTien2 nvarchar(45),@UuTien3 nvarchar(45)
	select @UuTien1=TenLoaiUuTien
	from THUTUUUTIEN 
	where ChiSoUuTien=1 and THUTUUUTIEN.MaMuaGiai=@MaMuaGiai
	select @UuTien2=TenLoaiUuTien
	from THUTUUUTIEN 
	where ChiSoUuTien=2 and THUTUUUTIEN.MaMuaGiai=@MaMuaGiai
	select @UuTien3=TenLoaiUuTien
	from THUTUUUTIEN 
	where ChiSoUuTien=3 and THUTUUUTIEN.MaMuaGiai=@MaMuaGiai
	set @Ngay=GETDATE()
	if(@Ngay in (select distinct(Ngay) from BANGXEPHANG ))
	begin
		delete from BANGXEPHANG
		where Ngay=@Ngay
		insert into BANGXEPHANG(MaDoi,Ngay,Thang,Thua,Hoa,HieuSo,Diem,SoBanThangSanKhach)
		select MaDoi,@Ngay,Thang,Thua,Hoa,HieuSo,Diem,SoBanThangSanKhach
		from KETQUADOIBONG
		where KETQUADOIBONG.MaDoi in (select MaDoi from DOIBONG where MaMuaGiai=@MaMuaGiai)
	end
	else
	begin
		insert into BANGXEPHANG(MaDoi,Ngay,Thang,Thua,Hoa,HieuSo,Diem,SoBanThangSanKhach)
		select MaDoi,@Ngay,Thang,Thua,Hoa,HieuSo,Diem,SoBanThangSanKhach
		from KETQUADOIBONG
		where KETQUADOIBONG.MaDoi in (select MaDoi from DOIBONG where MaMuaGiai=@MaMuaGiai)
	end
	if(@UuTien1='SoBanThangSanKhach')
	begin
		if(@UuTien2='Diem')
		begin
			update BANGXEPHANG
			set XepHang=KQDB.XepHang
			from
			(select MaDoi,Ngay,Thang,Thua,Hoa,HieuSo,SoBanThangSanKhach,Diem,RANK() over(order by SoBanThangSanKhach desc,Diem desc,HieuSo desc) as [XepHang]
			from BANGXEPHANG
			where Ngay=@Ngay) as KQDB 
			where BANGXEPHANG.MaDoi=KQDB.MaDoi and BANGXEPHANG.Ngay=KQDB.Ngay
		end
		else
		begin
			update BANGXEPHANG
			set XepHang=KQDB.XepHang
			from
			(select MaDoi,Ngay,Thang,Thua,Hoa,HieuSo,SoBanThangSanKhach,Diem,RANK() over(order by SoBanThangSanKhach desc,HieuSo desc,Diem desc) as [XepHang]
			from BANGXEPHANG
			where Ngay=@Ngay) as KQDB 
			where BANGXEPHANG.MaDoi=KQDB.MaDoi and BANGXEPHANG.Ngay=KQDB.Ngay
		end
	end
	if(@UuTien1='Diem')
	begin
		if(@UuTien2='HieuSo')
		begin
			update BANGXEPHANG
			set XepHang=KQDB.XepHang
			from
			(select MaDoi,Ngay,Thang,Thua,Hoa,HieuSo,SoBanThangSanKhach,Diem,RANK() over(order by Diem desc,HieuSo desc,SoBanThangSanKhach desc) as [XepHang]
			from BANGXEPHANG
			where Ngay=@Ngay) as KQDB 
			where BANGXEPHANG.MaDoi=KQDB.MaDoi and BANGXEPHANG.Ngay=KQDB.Ngay
		end
		else
		begin
			update BANGXEPHANG
			set XepHang=KQDB.XepHang
			from
			(select MaDoi,Ngay,Thang,Thua,Hoa,HieuSo,SoBanThangSanKhach,Diem,RANK() over(order by Diem desc,SoBanThangSanKhach desc,HieuSo desc) as [XepHang]
			from BANGXEPHANG
			where Ngay=@Ngay) as KQDB 
			where BANGXEPHANG.MaDoi=KQDB.MaDoi and BANGXEPHANG.Ngay=KQDB.Ngay
		end
	end
	if(@UuTien1='HieuSo')
	begin
		if(@UuTien2='Diem')
		begin
			update BANGXEPHANG
			set XepHang=KQDB.XepHang
			from
			(select MaDoi,Ngay,Thang,Thua,Hoa,HieuSo,SoBanThangSanKhach,Diem,RANK() over(order by HieuSo desc,Diem desc,SoBanThangSanKhach desc) as [XepHang]
			from BANGXEPHANG
			where Ngay=@Ngay) as KQDB
			where BANGXEPHANG.MaDoi=KQDB.MaDoi and BANGXEPHANG.Ngay=KQDB.Ngay
		end
		else
		begin
			update BANGXEPHANG
			set XepHang=KQDB.XepHang
			from
			(select MaDoi,Ngay,Thang,Thua,Hoa,HieuSo,SoBanThangSanKhach,Diem,RANK() over(order by HieuSo desc,SoBanThangSanKhach desc,Diem desc) as [XepHang]
			from BANGXEPHANG
			where Ngay=@Ngay) as KQDB 
			where BANGXEPHANG.MaDoi=KQDB.MaDoi and BANGXEPHANG.Ngay=KQDB.Ngay
		end
	end
	select *
	from  BANGXEPHANG
	order by XepHang asc
end
go
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
----------DỬ Liệu Mẩu-----------------------

insert into MUAGIAI values('2019','M2019',1); 
insert into MUAGIAI values('2018','M2018',1); 


insert into LOAICAUTHU values(N'LW',N'Công',1,'2019');
insert into LOAICAUTHU values(N'RS',N'Công1',1,'2019');
insert into LOAICAUTHU values(N'GK',N'Thủ',1,'2019');
insert into LOAICAUTHU values(N'NG',N'Nước ngoài',1,'2019');

insert into VONGDAU values('001',N'Vòng 1','2019');
insert into VONGDAU values('002',N'Vòng 2','2019');


insert into DIEUKIEN(MaMuaGiai,DiemSoThang,DiemSoHoa,DiemSoThua,TuoiToiDa,TuoiToiThieu,SoCauThuToiDa,SoCauThuToiThieu,SoCauThuNuocNgoaiToiDa,SoLanThayNguoiToiDa) values('2019',3,1,0,40,18,4,2,10,2);

insert into DOIBONG(MaDoi,MaMuaGiai) values(N'HCM','2019');
insert into DOIBONG(MaDoi,MaMuaGiai) values(N'MU','2019');
insert into DOIBONG(MaDoi,MaMuaGiai) values(N'HAGl','2019');

insert into KETQUADOIBONG values('HAGL',0,0,0,0,0,0);
insert into KETQUADOIBONG values('MU',0,0,0,0,0,0);
insert into KETQUADOIBONG values('HCM',0,0,0,0,0,0);

insert into SANTHIDAU values('CP01','CamPha','2019','CamPha','HAGL'); 
insert into SANTHIDAU values('CP02','Chilang','2019','ChiLang','HAGL'); 


insert into CAUTHU values (N'NCP',N'Nguyễn Công Phượng',10,'12/12/1995','12/12/1995',N'LW',N'Thể Lực Tốt',N'HCM',0);
insert into CAUTHU values (N'NVT',N'Nguyễn Văn Toàn',11,'8/20/1995','12/12/1995',N'RS',N'Thể Lực Tốt',N'HAGL',0);
insert into CAUTHU values (N'NVT1',N'Nguyễn Văn Toàn',12,'8/20/1995','12/12/1995',N'RS',N'Thể Lực Tốt',N'HAGL',0);
insert into CAUTHU values (N'DVL',N'Đặng Văn Lâm',13,'1995/8/20','12/12/1995',N'GK',N'Thể Lực Tốt',N'MU',0);
insert into CAUTHU values (N'LCV',N'Lê Công Vinh',14,'1995/8/20','12/12/1995',N'LW',N'Thể Lực Tốt',N'HCM',0);
insert into CAUTHU values (N'NQH',N'Nguyễn Quang Hải',15,'1993/4/1','12/12/1995',N'LW',N'Thể Lực Tốt',N'HCM',0);
insert into CAUTHU values (N'DVL5',N'Đặng Văn Lâm',16,'1995/8/20','12/12/1995',N'GK',N'Thể Lực Tốt',N'MU',0);
insert into CAUTHU values (N'NTT2',N'Nguyễn Quang Hải',17,'1993/4/1','12/12/1995',N'LW',N'Thể Lực Tốt',N'MU',0);
insert into CAUTHU values (N'DVL6',N'Đặng Văn Lâm',18,'1995/8/20','12/12/1995',N'GK',N'Thể Lực Tốt',N'MU',0);

insert into TRANDAU values('001','2019','MU','HAGL','2020-3-26','2020-3-26','10:20:56','10:20:56','CP01','CP01',0,0,'10:20:56','001');
exec KQ '001'

insert into DANHSACHTHAMGIA values('001',N'DVL',0,1);
insert into DANHSACHTHAMGIA values('001',N'NTT2',0,1);
insert into DANHSACHTHAMGIA values('001',N'NVT1',0,1);
insert into DANHSACHTHAMGIA values('001',N'DVL5',1,0);
insert into DANHSACHTHAMGIA values('001',N'NVT',1,0);
insert into DANHSACHTHAMGIA values('001',N'DVL6',1,0);

insert into CHITIETTHAYNGUOI values('001',N'DVL5',N'DVL','10:20:54','001');
insert into CHITIETTHAYNGUOI values('002',N'NVT',N'NVT1','10:20:56','001');


insert into LOAITHE values('001',N'Đỏ');
insert into LOAITHE values('002',N'Vàng');

insert into PHATTHE values('001','NCP','001','10:20:56','001');
insert into PHATTHE values('002','NCP','002','10:20:56','001');
insert into PHATTHE values('003','NVT1','001','10:20:56','001');
insert into PHATTHE values('004','NCP','002','10:20:56','001');
insert into PHATTHE values('005','NVT1','002','10:20:55','001');

insert into LOAIBANTHANG values('001','2019','VOLEL',1);
insert into LOAIBANTHANG values('002','2019','VOLER',0);

insert into BANTHANG values('001','DVL5','001','10:20:55','001');
insert into BANTHANG values('002','NVT1','001','10:20:55','001');

insert into THUTUUUTIEN values(1,'2019','Diem');
insert into THUTUUUTIEN values(2,'2019','HieuSo');
insert into THUTUUUTIEN values(3,'2019','SoBanThangSanKhach');

--thêm cầu thủ: Xếp hạng có bộ lọc cho các đội bóng có trùng thứu tự cần sắp xếp về chỉ số đối đầu------------------
--Hà Nhật Linh version 1.4--------------------

