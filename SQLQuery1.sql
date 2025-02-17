CREATE DATABASE QLKARAOKE2;

USE QLKARAOKE2;

CREATE TABLE tblKHACHHANG
(
	maKH INT IDENTITY (1,1),
	tenKH NVARCHAR(100),
	diachi NVARCHAR(300),
	gioitinh NVARCHAR(10),
	dienthoai NVARCHAR(10) UNIQUE,

	CONSTRAINT PK_kh PRIMARY KEY (maKH)
);

CREATE TABLE tblNHANVIEN
(
	maNV INT IDENTITY (1,1),
	tenNV NVARCHAR(100),
	diachi NVARCHAR(300),
	gioitinh NVARCHAR(10),
	dienthoai NVARCHAR(10) UNIQUE,
	cmnd NVARCHAR(100),
	ngaylam DATE,
	luong INT,


	CONSTRAINT PK_nv PRIMARY KEY (maNV)
);

CREATE TABLE tblTAIKHOAN
(
	maTK INT IDENTITY(1,1),
	tendangnhap NVARCHAR(20) UNIQUE,
	matkhau NVARCHAR(20),
	trangthai BIT,
	isAdmin BIT,

	CONSTRAINT PK_tk PRIMARY KEY (maTK)
);

CREATE TABLE tblLOAIPHONG
(
	maLoaiPhong INT IDENTITY(1,1),
	tenLoaiPhong NVARCHAR(100),
	giaPhong INT,

	CONSTRAINT PK_Phong PRIMARY KEY(maLoaiPhong)
);

CREATE TABLE tblPHONG
(
	maPhong INT IDENTITY(1,1),
	tenPhong NVARCHAR(100),
	maLoaiPhong INT,
	trangthai NVARCHAR(100),

	CONSTRAINT PK_PhongSo PRIMARY KEY(maPhong),
	CONSTRAINT FK_Phong FOREIGN KEY (maLoaiPhong) REFERENCES tblLOAIPHONG (maLoaiPhong)
);

CREATE TABLE tblDICHVU
(
	maDV INT IDENTITY(1,1),
	tenDV NVARCHAR(300),
	giaDV INT,

	CONSTRAINT PK_dv PRIMARY KEY (maDV)
);

CREATE TABLE tblHOADON
(
	maHD INT IDENTITY(1,1),
	batdau DATETIME,
	ketthuc DATETIME,
	tongtien INT,
	maKH INT,
	maPhong INT,
	trangthai NVARCHAR(10),

	CONSTRAINT PK_hd PRIMARY KEY (maHD),
	CONSTRAINT FK_hd1 FOREIGN KEY (maKH) REFERENCES tblKHACHHANG (maKH),
	CONSTRAINT FK_hd2 FOREIGN KEY (maPhong) REFERENCES tblPHONG (maPhong)
);


CREATE TABLE tblSUDUNGDICHVU
(
	maHD INT,
	maDV INT,
	soluong INT,

	CONSTRAINT PK_sddv PRIMARY KEY (maHD, maDV),
	CONSTRAINT FK_sddv1 FOREIGN KEY (maHD) REFERENCES tblHOADON (maHD),
	CONSTRAINT FK_sddv2 FOREIGN KEY (maDV) REFERENCES tblDICHVU (maDV),
);


