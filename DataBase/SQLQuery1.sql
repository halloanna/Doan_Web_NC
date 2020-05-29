create database StudentWEB
go 
use StudentWEB
go
create table HoSoHS
(HocSinhID int not null,
HoTen nvarchar(50) not null,
GioiTinh nvarchar(10) not null,
NgaySinh date not null,
DiaChi nvarchar(max) not null,
Email nvarchar(100) not null,
LopID int,
constraint PK_HOSOHS primary key(HocSinhID),
constraint FK_HoSoHS_Lop foreign key(LopID) references Lop(LopID) on delete set null
)
go

create table Lop
(
	LopID int not null,
	TenLop nvarchar(50) not null,
	SiSo int ,
	SLDat int,
	TiLe int
	constraint PK_LOP primary key(LopID)

)

create table MonHoc
(
MonHocID int identity(1,1),
TenMH nvarchar(50) not null,
constraint PK_MONHOC primary key(MonHocID)
)

create table BangDiemMonHoc
(
BDiemID int identity(1,1),
HocSinhID int,
MonHocID int,
HocKi int not null,
Diem15p float not null,
Diem1t float not null,
DiemTB float not null
constraint PK_BangDiemMonHoc primary key(BDiemID),
constraint FK_BangDiemMonHoc_HOCSINH	foreign key(HocsinhID) references HoSoHS(HocSinhID),
constraint FK_BangDiemMonHoc_MonHoc	foreign key(MonHocID) references MonHoc(MonHocID)
)

create table UserTK
(
UserID int identity(1,1),
UserName Nvarchar(50) not null,
PassWord nvarchar(40) not null,
constraint PK_USER primary key(UserID)
)
