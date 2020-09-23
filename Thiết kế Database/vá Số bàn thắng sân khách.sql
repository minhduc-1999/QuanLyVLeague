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