CREATE DATABASE QUANLY_VPP
GO 
USE QUANLY_VPP
GO 



CREATE TABLE LOAISP
(
	MALOAISP INT IDENTITY,
	TENLOAISP NVARCHAR(200),
	CONSTRAINT PK_LOAISP PRIMARY KEY(MALOAISP)
)
go
CREATE TABLE SANPHAM
(
	MASP INT IDENTITY,
	TENSP NVARCHAR(200),
	MALOAI INT,
	DONGIA MONEY,
	SOLUONGTON INT,
	HINHANH nvarchar(500),
	CONSTRAINT PK_SP PRIMARY KEY(MASP),
	CONSTRAINT FK_LOAI_SANPHAM FOREIGN KEY (MALOAI) REFERENCES LOAISP (MALOAISP)
)

CREATE TABLE NHACUNGCAP
(
	MANCC INT IDENTITY,
	TENNCC NVARCHAR(200),
	SDT VARCHAR(20),
	EMAIL VARCHAR(100),
	DIACHI NVARCHAR(300),
	CONSTRAINT PK_NCC PRIMARY KEY(MANCC),
)

CREATE TABLE NHANVIEN 
(
	MANV INT IDENTITY,
	TENNV NVARCHAR(100),
	GIOITINH NVARCHAR(10),
	DIACHI NVARCHAR(200),
	SDT VARCHAR(20),
	CHUCVU INT,
	TENDN VARCHAR(50) unique,
	MK VARCHAR(50),
	CONSTRAINT PK_NV PRIMARY KEY(MANV)
)

CREATE TABLE PHIEUNHAP
(
	MAPN INT IDENTITY,
	MANCC INT,
	MANV INT,
	NGAYLAP DATE,
	TONGTIEN MONEY,
	CONSTRAINT PK_PHIEUNHAP PRIMARY KEY(MAPN),
	CONSTRAINT FK_PHIEUNHAP_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN (MANV),
	CONSTRAINT FK_PHIEUNHAP_NHACUNGCAP FOREIGN KEY (MANCC) REFERENCES NHACUNGCAP (MANCC),
)
CREATE TABLE CHITIETPHIEUNHAP
(
	MACTPN INT IDENTITY,
	MAPN INT,
	MASP INT,
	SOLUONG INT,
	THANHTIEN MONEY,
	CONSTRAINT PK_CTPHIEUNHAP PRIMARY KEY(MACTPN),
	CONSTRAINT FK_PHIEUNHAP_CTPN FOREIGN KEY (MAPN) REFERENCES PHIEUNHAP (MAPN),
	CONSTRAINT FK_SP_CTPN FOREIGN KEY (MASP) REFERENCES SANPHAM (MASP),
)

CREATE TABLE KHACHHANG 
(
	MAKH INT IDENTITY,
	TENKH NVARCHAR(100),
	SDT VARCHAR(20),
	GIOITINH NVARCHAR(10),
	CONSTRAINT PK_KH PRIMARY KEY(MAKH),
)

CREATE TABLE HOADON 
(
	MAHD INT IDENTITY,
	MAKH INT,
	MANV INT,
	NGAYLAP DATE,
	GIAMGIA MONEY,
	TONGTIEN MONEY,
	CONSTRAINT PK_HD PRIMARY KEY (MAHD),
	CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY (MAKH) REFERENCES KHACHHANG (MAKH),
	CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN (MANV),
)
--ALTER TABLE HOADON
--  DROP COLUMN TONGTIEN;
--ALTER TABLE HOADON
--  ADD GIAMGIA MONEY,
--		TONGTIEN MONEY

CREATE TABLE CHITIETHD
(
		MACTHD INT IDENTITY,
		MAHD INT, 
		MASP INT,
		SOLUONG INT,
		THANHTIEN MONEY,
		CONSTRAINT PK_CHITIETHD PRIMARY KEY (MACTHD),
		CONSTRAINT FK_CHIIETHD_HOADON FOREIGN KEY (MAHD) REFERENCES HOADON (MAHD),
		CONSTRAINT FK_CHITIETHD_SANPHAM FOREIGN KEY (MASP) REFERENCES SANPHAM (MASP),
)

------------------------------------------------------------nh???p d??? li???u---------------------------------------------------------------


select*from nhanvien
--th??m d??? li???u v??o b???ng loaisp
select*from sanpham
insert into LOAISP values 
(N'B??t vi???t'),
(N'T???p - s???'),
(N'M??y t??nh'),
(N'B???ng'),
(N'Ph???n'),
(N'Lau b???ng'),
(N'B???m kim'),
(N'Th?????c'),
(N'Dao k??o c???t gi???y'),
(N'B??a h??? s??')

--th??m d??? li???u v??o b???ng sanpham 

insert into sanpham values 
(N'B??t ch?? b???m Pentel 05mm', 1, 55000, 9, N'butchikimbam05mm.jpg'),
(N'B??t ch?? 24 m??u', 1, 55000, 12, N'butchi24mau.jpg'),
(N'B??t ch?? s??p 12 m??u', 1, 75000, 10, N'butchisap12mau.jpg'),
(N'B??t ch?? Koh I Noor 2B', 1, 8000, 28, N'butchikohinoor2b.jpg'),
(N'B??t ch?? 12 m??u', 1, 30000, 12, N'butchi12mau.jpg'),
(N'B??t bi TL xanh', 1, 3500, 50, N'butbitlxanh'),
(N'B??t bi TL ??en', 1, 3500, 50, N'butbitlden.jpg'),
(N'B??t bi ???n ????? xanh', 1, 3000, 50, N'butbiandoxanh.jpg'),
(N'B??t bi ???n ????? ??en', 1, 3000, 50, N'butbiandoden.jpg'),
(N'B??t bi Uniball Laknock ?????', 2, 25000, 30, N'butbiuniballlaknockdo.jpg'),
(N'T???p Thu???n Ti???n 100 trang', 2, 10000, 100, N'tapthuantien100trang.jpg'),
(N'Vinabook 100 trang', 2, 10000, 120, N'vinabook100trang.jpg'),
(N'Vinabook 200 trang', 2, 15000, 150, N'vinabook200trang.jpg'),
(N'S??? da Viaone', 2, 70000, 80, N'sodaviaone.jpg'),
(N'S??? l?? xo Lax A4', 2, 38000, 110, N'soloxolaxa4.jpg'),
(N'Casio FX-570VN', 3, 485000, 65, N'casiofx570vn.jpg'),
(N'Casio FX-500MS', 3, 280000, 48, N'casiofx500ms.jpg'),
(N'Vinacal 570-ESPlus', 3, 420000, 32, N'vinacal570esplus.jpg'),
(N'B???ng tr???ng 0.6x0.4', 4, 70000, 25, N'bangtran06x04.jpg'),
(N'B???ng nhung 0.6x0.4', 4, 120000, 25, N'bangnhung06x04.jpg'),
(N'Ph???n tr???ng', 5, 7000, 80, N'phantrang.jpg'),
(N'Ph???n m??u', 5, 7000, 80, N'phanmau.jpg'),
(N'Kh??n lau b???ng', 6, 7000, 100, N'khanlaubang.jpg'),
(N'M??t x???p lau b???ng', 6, 5000, 100, N'mutxoplaubang.jpg'),
(N'Lau b???ng xukiva', 6, 12000, 100, N'laubangxukiva.jpg'),
(N'B???m kim Kanex HD10 - 10 t???', 7, 20000, 32, N'bamkim10to.jpg'),
(N'B???m kim Kwtrio 5003 - 240 t???', 7, 550000, 15, N'bamkim240to.jpg'),
(N'Th?????c d???o WinQ 30cm', 8, 5000, 95, N'thuocdeo30cm.jpg'),
(N'Th?????c ??ke', 8, 5000, 88, N'thuoceke.jpg'),
(N'Th?????c ??o ?????', 8, 5000, 56, N'thuocdodo.jpg'),
(N'Th?????c Parabol WinQ QL-01', 8, 4000, 120, N'thuocparabol.jpg'),
(N'Th?????c v??? k??? thu???t, Template Ruler C-2007', 8, 27000, 100, N'thuocvekythuat.jpg'),
(N'K??o v??n ph??ng Stacom F102 - 180mm', 9, 25000, 220, N'keovanphong.jpg'),
(N'Dao r???c gi???y mini M&G 2243 h??nh c??? c?? r???t', 9, 14000, 190, N'daorocgiaycarot.jpg'),
(N'Dao r???c gi???y mini M&G 2281', 9, 12000, 90, N'daorocmini.jpg'),
(N'K??o nh??? M&G 2229', 9, 12000, 70, N'keonho_mg2229.jpg'),
(N'B??a c??ng KING JIM kh??? F4 - 7F', 10, 50000, 40, N'biacongkingjimf4_7f.jpg'),
(N'B??a c??y A4 g??y l???n', 10, 6000, 100, N'biacaya4gaylon.jpg'),
(N'B??a c??y A4 g??y nh???', 10, 4000, 100, N'biacaya4gaynho.jpg'),
(N'B??a n??t kh??? A5 kh??ng ch???', 10, 2500, 200, N'bianutkhoa5khongchu.jpg')
--(N'B??t ch?? b???m Pentel 05mm', 1, 55000, 9),
--(N'B??t ch?? 24 m??u', 1, 55000, 12),
--(N'B??t ch?? s??p 12 m??u', 1, 75000, 10),
--(N'B??t ch?? Koh I Noor 2B', 1, 8000, 28),
--(N'B??t ch?? 12 m??u', 1, 30000, 12),
--(N'B??t bi TL xanh', 1, 3500, 50),
--(N'B??t bi TL ??en', 1, 3500, 50),
--(N'B??t bi ???n ????? xanh', 1, 3000, 50),
--(N'B??t bi ???n ????? ??en', 1, 3000, 50),
--(N'B??t bi Uniball Laknock ?????', 2, 25000, 30),
--(N'T???p Thu???n Ti???n 100 trang', 2, 10000, 100),
--(N'Vinabook 100 trang', 2, 10000, 120),
--(N'Vinabook 200 trang', 2, 15000, 150),
--(N'S??? da Viaone', 2, 70000, 80),
--(N'S??? l?? xo Lax A4', 2, 38000, 110),
--(N'Casio FX-570VN', 3, 485000, 65),
--(N'Casio FX-500MS', 3, 280000, 48),
--(N'Vinacal 570-ESPlus', 3, 42000, 32),
--(N'B???ng tr???ng 0.6x0.4', 4, 70000, 25),
--(N'B???ng nhung 0.6x0.4', 4, 120000, 25),
--(N'Ph???n tr???ng', 5, 7000, 80),
--(N'Ph???n m??u', 5, 7000, 80),
--(N'Kh??n lau b???ng', 6, 7000, 100),
--(N'M??t x???p lau b???ng', 6, 5000, 100),
--(N'Lau b???ng xukiva', 6, 12000, 100),
--(N'B???m kim Kanex HD10 - 10 t???', 7, 20000, 32),
--(N'B???m kim Kwtrio 5003 - 240 t???', 7, 550000, 15),
--(N'Th?????c d???o WinQ 30cm', 8, 5000, 95),
--(N'Th?????c ??ke', 8, 5000, 88),
--(N'Th?????c ??o ?????', 8, 5000, 56),
--(N'Th?????c Parabol WinQ QL-01', 8, 4000, 120),
--(N'Th?????c v??? k??? thu???t, Template Ruler C-2007', 8, 27000, 100),
--(N'K??o v??n ph??ng Stacom F102 - 180mm', 9, 25000, 220),
--(N'Dao r???c gi???y mini M&G 2243 h??nh c??? c?? r???t', 9, 14000, 190),
--(N'Dao r???c gi???y mini M&G 2281', 9, 12000, 90),
--(N'K??o nh??? M&G 2229', 9, 12000, 70),
--(N'B??a c??ng KING JIM kh??? F4 - 7F', 10, 50000, 40),
--(N'B??a c??y A4 g??y l???n', 10, 6000, 100),
--(N'B??a c??y A4 g??y nh???', 10, 4000, 100),
--(N'B??a n??t kh??? A5 kh??ng ch???', 10, 2500, 200)




select count(*) from NHANVIEN where TENTAIKHOAN='lqt' and MATKHAU='123'



--th??m d??? li???u v??o b???ng nhanvien 

insert into nhanvien values 
(N'Nguy???n Th??nh V??n', N'Nam', N'TP.HCM', '0383633081',  1, 'admin', '123'),
(N'L?? Quang Tr???c', N'Nam', N'TP.HCM', '0123321223',  1, 'lqt', '123'),
(N'Nguy???n H???a Hi???n Vinh', N'Nam', N'TP.HCM', '0883311233',  0, 'vinh', '123'),
(N'Tr????ng ????nh V??n', N'Nam', N'TP.HCM', '0798889992',  0, 'uservan', '123'),
(N'Nguy???n Tu???n Ki???t', N'Nam', N'TP.HCM', '0789632456', 0, 'userkiet', '123'),
(N'L?? Quang Tu???n', N'Nam', N'TPHCM', '0792666144', 0, 'usertuan', '123'),
(N'Tr???n Kh??nh Ng???c', N'N???', N'TPHCM', '0785568156', 0, 'userngoc', '123'),
(N'Nguy???n Nh???t My', N'N???', N'TPHCM', '0125325635', 0, 'usermy', '123'),
(N'Nguy???n Hu???nh Ng???c Th?? ', N'N???', N'TPHCM', '0987656565', 0, 'userthu', '123'),
(N'B??i Th??? Thu Linh', N'N???', N'TPHCM', '0123876598', 0, 'userlinh', '123')

--th??m d??? li???u v??o b???ng khachhang

insert into khachhang values 
(N'Nguy???n Tr???ng Ngh??a', '0911422428', N'Nam'),
(N'Hu???nh Anh Tri???u', '0931748456', N'Nam'),
(N'Hu???nh T???n Ki???t', '0343592659', N'Nam'),
(N'Nguy???n Nh???t H??o', '0385120406', N'Nam'),
(N'Nguy???n Th??? Thu Ng??n', '0396219444', N'N???'),
(N'????? Th??? H???i Y???n', '0707796677', N'N???'),
(N'Nguy???n Th??? Qu???nh Nh??', '0783536600', N'N???'),
(N'Nguy???n Qu???c Trung', '0793453322', 'Nam'),
(N'Nguy???n Nh???t Tr?????ng', '078990077', N'Nam'),
(N'Nguy???n ????nh Kh???', '0703227711', N'Nam')

--th??m d??? li???u v??o b???ng nhacungcap

--	TENNCC NVARCHAR(200),
--	SDT VARCHAR(20),
--	EMAIL VARCHAR(100),
--	DIACHI NVARCHAR(300),

insert into nhacungcap values 
(N'V??N PH??NG PH???M KHANG MINH', '0944697678', 'tbvpkhangminh@gmail.com', N'70/16 Hi???p Nh???t, Ph?????ng 4, Qu???n T??n B??nh, TP. H??? Ch?? Minh'),
(N'V??N PH??NG PH???M ANH ?????C', ' 0983481825', 'nguyenanhtuanhcmvn@gmail.com', N'490/41 L?? V??n S???, Ph?????ng 14, Qu???n 3, TP H??? Ch?? Minh'),
(N'V??N PH??NG PH???M 24', '0985180684', ' minhanh@vanphongpham24.com', N'S??? 218 L?? C5 Khu ???? Th??? ?????i Kim, Qu???n Ho??ng Mai, TP H?? N???i'),
(N'V??N PH??NG PH???M H??NG THU???N PH??T', '0908150636', 'htp@hungthuanphat.vn', N'104/3 Mai Th??? L???u, Ph?????ng ??a Kao, Qu???n 1, TP H??? Ch?? Minh'),
(N'V??N PH??NG PH???M KHANG L??', '0935508693', 'vppkhangle@gmail.com', N'S??? 60A, ???????ng Tam ????ng 21, X?? Th???i Tam Th??n, Huy???n H??c M??n, Tp H??? Ch?? Minh')

--th??m d??? li???u v??o b???ng hoadon 

set dateformat dmy		
insert into hoadon values 
('HD001', '29/12/2020', NULL, 'KH001', 'NV001'),
('HD002', '01/02/2021', NULL, 'KH002', 'NV001'),
('HD003', '22/02/2021', NULL, 'KH003', 'NV002'),
('HD004', '29/03/2021', NULL, 'KH004', 'NV002'),
('HD005', '29/01/2021', NULL, 'KH005', 'NV003'),
('HD006', '16/05/2021', NULL, 'KH006', 'NV003'),
('HD007', '21/06/2021', NULL, 'KH007', 'NV004'),
('HD008', '08/03/2021', NULL, 'KH008', 'NV004'),
('HD009', '19/04/2021', NULL, 'KH009', 'NV005'),
('HD010', '22/07/2021', NULL, 'KH010', 'NV005')

--th??m d??? li???u v??o b???ng chitiethd 

insert into chitiethd values 
('HD001', 'SP001', 1, NULL, NULL),
('HD001', 'SP002', 1, NULL, NULL),
('HD001', 'SP003', 2, NULL, NULL),
('HD001', 'SP004', 3, NULL, NULL),
('HD001', 'SP005', 3, NULL, NULL),
('HD001', 'SP006', 2, NULL, NULL),
('HD002', 'SP007', 1, NULL, NULL),
('HD002', 'SP008', 1, NULL, NULL),
('HD002', 'SP009', 1, NULL, NULL),
('HD003', 'SP010', 1, NULL, NULL),
('HD003', 'SP011', 2, NULL, NULL),
('HD004', 'SP012', 1, NULL, NULL),
('HD004', 'SP013', 1, NULL, NULL),
('HD005', 'SP014', 1, NULL, NULL),
('HD006', 'SP015', 2, NULL, NULL),
('HD006', 'SP016', 1, NULL, NULL),
('HD007', 'SP017', 3, NULL, NULL),
('HD007', 'SP018', 1, NULL, NULL),
('HD009', 'SP019', 1, NULL, NULL),
('HD009', 'SP020', 1, NULL, NULL),
('HD008', 'SP021', 1, NULL, NULL),
('HD008', 'SP022', 3, NULL, NULL),
('HD010', 'SP023', 2, NULL, NULL),
('HD010', 'SP024', 1, NULL, NULL),
('HD005', 'SP025', 1, NULL, NULL),
('HD010', 'SP026', 2, NULL, NULL),
('HD009', 'SP027', 6, NULL, NULL),
('HD006', 'SP028', 3, NULL, NULL),
('HD005', 'SP029', 2, NULL, NULL),
('HD002', 'SP030', 1, NULL, NULL)

--------C???P NH???T C???T GIABAN TRONG B???NG CHITIETHD D???A V??O GI?? B??N C???A S???N PH???M
declare cursorgiaban cursor 
for select masp, giatien from sanpham
open cursorgiaban
declare @masp char(20)
declare @giatien money
fetch next from cursorgiaban into @masp, @giatien
while (@@FETCH_STATUS = 0)
begin 
	update chitiethd set giaban = (select giatien from sanpham where chitiethd.masp = sanpham.masp) 
	where @masp = chitiethd.masp
	fetch next from cursorgiaban into @masp, @giatien
end 
close cursorgiaban
deallocate cursorgiaban

select * from chitiethd

--------C???P NH???T C???T TH??NH TI???N TRONG B???NG CHITIETHD D???A V??O SOLUONG V?? GIABAN
declare cursorthanhtien cursor 
for select soluong, giaban from CHITIETHD
open cursorthanhtien
declare @sluong int
declare @giaban money
fetch next from cursorthanhtien into @sluong, @giaban
while (@@FETCH_STATUS = 0)
begin 
		update chitiethd set thanhtien =  (@sluong * @giaban) where (@sluong = SOLUONG and @giaban = giaban)
		fetch next from cursorthanhtien into @sluong, @giaban
end 
close cursorthanhtien
deallocate cursorthanhtien

select * from CHITIETHD

--------C???P NH???T C???T TIENBAN TRONG HOADON
declare cursortienban cursor 
for select MAHD from CHITIETHD
open cursortienban
declare @mahd char(20) 
fetch next from cursortienban into @mahd
while (@@FETCH_STATUS = 0)
begin 
	update HOADON set tongtien = (select sum(thanhtien) from CHITIETHD where HOADON.MAHD = CHITIETHD.MAHD)
	 where MAHD = @mahd 
	 fetch next from cursortienban into @mahd
end 
close cursortienban
deallocate cursortienban

select * from hoadon
select * from chitiethd






select hd.MAHD,nv.TENNV,kh.TENKH,hd.NGAYLAP,sp.TENSP,sp.DONGIA,cthd.SOLUONG,cthd.THANHTIEN,hd.GIAMGIA,hd.TONGTIEN  
                    from HOADON hd, CHITIETHD cthd, SANPHAM sp, KHACHHANG kh, NHANVIEN nv  
                    where hd.MAHD=cthd.MAHD  
                    and cthd.MASP=sp.MASP  
                    and hd.MAKH=kh.MAKH  
                    and nv.MANV=hd.MANV