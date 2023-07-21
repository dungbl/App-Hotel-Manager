CREATE DATABASE QuanLyKhachSan
GO

USE QuanLyKhachSan
GO

--Room
--Services
--ServicesCategory
--Account 
--Bill
--BillInfo

CREATE TABLE Room
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)DEFAULT N'Chưa đặt tên',
	status NVARCHAR(100) DEFAULT N'Trống'
)
GO

CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Staff',
	UserName NVARCHAR(100) NOT NULL,
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0
)
GO

CREATE TABLE ServicesCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Services
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price INT NOT NULL DEFAULT 0,
	
	FOREIGN KEY (idCategory) REFERENCES dbo.ServicesCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateIn DATE NOT NULL,
	DateOut DATE NOT NULL,
	idRoom 	INT NOT NULL,
	status INT NOT NULL
	
	FOREIGN KEY (idRoom) REFERENCES dbo.Room(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idServices INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id)
	FOREIGN KEY (idServices) REFERENCES dbo.Services(id)
)
GO

INSERT INFO dbo.Account
	(
		UserName,
		DisplayName,
		PassWord,
		Type
	)
VALUES 
	(
		N'DungBacLieu',
		N'Dung',
		N'1',
		1 --Type = int
	
	)

INSERT INFO dbo.Account
	(
		UserName,
		DisplayName,
		PassWord,
		Type
	)
VALUES 
	(
		N'Staff1',
		N'Nhân viên 1',
		N'1',
		0 --Type = int
	)
SELECT * FROM dbo.Account




