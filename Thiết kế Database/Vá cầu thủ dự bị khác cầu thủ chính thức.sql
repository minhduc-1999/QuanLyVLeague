----------DieuKienCauThuDuBiKhacCauThuChinhThuc----------
alter table DANHSACHTHAMGIA 
add constraint Tr_DanhSachThamGia  check(CauThuDuBi != CauThuChinhThuc);
go