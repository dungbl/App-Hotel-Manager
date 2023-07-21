CREATE DATABASE QuanLyKhachSan
GO

USE QuanLyKhachSan
GO

--Room
--Customer
--
--Support
--Account 
--Bill
--BillInfo

CREATE TABLE Room
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)DEFAULT N'Chưa đặt tên',
	status NVARCHAR(100) DEFAULT N'Trống',
	amount INT DEFAULT 1,
	amountPeople INT DEFAULT 0,

)
GO

CREATE TABLE Customer
(
	idCus NVARCHAR(100) PRIMARY KEY,
	gender INT ,
	name NVARCHAR(100) DEFAULT N'Chưa nhập tên',
	cmnd INT DEFAULT N'0',
	address NVARCHAR(100) DEFAULT N'Chưa nhập địa chỉ',
	country NVARCHAR(100) DEFAULT N'Chưa nhập quốc tịch',
	sdt INT DEFAULT 0,
	email NVARCHAR(100) DEFAULT N'Chưa nhập email',
	idRoom int ,
	amount INT DEFAULT 0
	
	FOREIGN KEY (idRoom) REFERENCES dbo.Room(id),
	
)
GO



CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Staff',
	UserName NVARCHAR(100) NOT NULL,
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 -- 1 la admin || 0 la staff
)
GO


CREATE TABLE Support -- dich vu
(
	idSup INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	price INT NOT NULL DEFAULT 0,
	
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateIn DATE NOT NULL DEFAULT GETDATE(),
	DateOut DATE,
	idRoom 	INT NOT NULL,
	status INT NOT NULL,
	idCus NVARCHAR(100) DEFAULT N'Chưa có mã khách hàng'
	
	FOREIGN KEY (idRoom) REFERENCES dbo.Room(id),
	FOREIGN KEY (idCus) REFERENCES dbo.Customer(idCus)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT ,
	idSupport INT 
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idSupport) REFERENCES dbo.Support(idSup)
)
GO


INSERT INTO dbo.Account
	(
		UserName,
		DisplayName,
		PassWord,
		Type
	)
VALUES 
	(
		N'Dung',
		N'DungBacLieu',
		N'0',
		1 --Type = int
	)

INSERT INTO dbo.Account
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

INSERT INTO dbo.Account
	(
		UserName,
		DisplayName,
		PassWord,
		Type
	)
VALUES 
	(
		N'nv',
		N'Nhân viên 2',
		N'1',
		0 --Type = int
	)


	--thêm khách
	DECLARE @i int = 0
	while @i<10
	begin
		INSERT dbo.Customer(idCus, gender, amount) VALUES (N'KH' + CAST(@i+1 AS nvarchar(1000)), 1, 1)
		SET @i = @i+1
	end



	-- thêm bàn
	DECLARE @j int = 0
	while @j<12
	begin
		INSERT dbo.Room (name, status, amount, amountPeople) VALUES (N'Phòng ' + CAST(@j+1 AS nvarchar(1000)), N'Trống', 0, 0)
		SET @j = @j+1
	end
SELECT * FROM dbo.Account

SELECT * FROM dbo.Support

SELECT * FROM dbo.BillInfo

SELECT * FROM dbo.Room

SELECT * FROM dbo.Customer

SELECT * FROM dbo.Bill where id = 2

SELECT * FROM dbo.BillInfo where idBill = 2 

select s.name, bi.idBill,s.price from dbo.BillInfo as bi, dbo.Bill as b, dbo.Support as s
where bi.idBill = b.id and bi.idSupport = s.id and idRoom = 2

select s.name, bi.idBill,s.price from dbo.BillInfo as bi, dbo.Bill as b, dbo.Support as s
where bi.idBill = b.id and bi.idSupport = s.id and idBill = 2

select s.name, bi.idBill,s.price from dbo.BillInfo as bi, dbo.Support as s
where bi.idSupport = s.id and idSupport =2 

select price from dbo.Support where id= 2

go
CREATE PROC USP_GetRoomList
AS SELECT * FROM dbo.Room
go

exec dbo.USP_GetRoomList

go
CREATE PROC USP_GetBillList
AS SELECT * FROM dbo.Bill
go

exec dbo.USP_GetBillList



update dbo.Room SET STATUS = N'Có khách' WHERE id = 4
update dbo.Room SET amount = 4 WHERE id = 4
update dbo.Room SET amountPeople = 4 WHERE id = 4

update dbo.Room SET STATUS = N'Có khách' WHERE id = 2
update dbo.Room SET amount = 1 WHERE id = 2
update dbo.Room SET amountPeople = 1 WHERE id = 2

go
-- sửa thông tin
DECLARE @k int = 5
	while @k<10
	begin
		update dbo.Room (status, amount, amountPeople) VALUES (N'Trống',0,0) WHERE id = @k
		SET @k = @k+1
	end


select * from dbo.Bill

select * from dbo.Room
go

-- thêm bill

INSERT INTO dbo.Bill
	(
		DateIn,
		DateOut,
		idRoom, 
		idCus,
		status
	)
VALUES 
	(
		GETDATE(), --ngày vào
		GETDATE(), --ngày ra
		2, --mã phòng
		N'KH3', -- mã khách hàng
		0 -- trạng thái hóa đơn (0 là chưa trả tiền, 1 là trả tiền)
	)

INSERT INTO dbo.Bill
	(
		DateIn,
		DateOut,
		idRoom, 
		idCus,
		status
	)
VALUES 
	(
		GETDATE(), --ngày vào
		GETDATE(), --ngày ra
		4, --mã phòng
		N'KH5', -- mã khách hàng
		0 -- trạng thái hóa đơn (0 là chưa trả tiền, 1 là đã trả tiền)
	)

INSERT INTO dbo.Bill
	(
		DateIn,
		DateOut,
		idRoom, 
		idCus,
		status
	)
VALUES 
	(
		GETDATE(), --ngày vào
		GETDATE(), --ngày ra
		9, --mã phòng
		N'KH7', -- mã khách hàng
		1 -- trạng thái hóa đơn (0 là chưa trả tiền, 1 là đã trả tiền)
	)

select * from dbo.BillInfo
go
-- thêm billinfo

INSERT INTO dbo.BillInfo
	(
		idBill,
		idSupport
	)
VALUES 
	(
		1, -- mã bill
		1 -- mã dịch vụ
	)


INSERT dbo.BillInfo
	(
		idBill,
		idSupport
	)
VALUES 
	(
		1, -- mã bill
		2 -- mã dịch vụ
	)

	INSERT dbo.BillInfo
	(
		idBill,
		idSupport
	)
VALUES 
	(
		1, -- mã bill
		4 -- mã dịch vụ
	)

	INSERT dbo.BillInfo
	(
		idBill,
		idSupport
	)
VALUES 
	(
		2, -- mã bill
		5 -- mã dịch vụ
	)

	INSERT dbo.BillInfo
	(
		idBill,
		idSupport
	)
VALUES 
	(
		2, -- mã bill
		3 -- mã dịch vụ
	)

select * from dbo.Support
go
-- thêm dịch vụ
INSERT INTO dbo.Support
	(
		name,
		price
		
	)
VALUES 
	(
		N'Dịch vụ Spa ',
		1000000
	)

	INSERT INTO dbo.Support
	(
		name,
		price
		
	)
VALUES 
	(
		N'Dịch vụ ủi quần áo',
		200000
	)
	INSERT INTO dbo.Support
	(
		name,
		price
	)
VALUES 
	(
		N'Dịch vụ Gym ',
		1000000
	)
	INSERT INTO dbo.Support
	(
		name,
		price
		
	)
VALUES 
	(
		N'Dịch vụ đưa rước ',
		100000
	)
INSERT INTO dbo.Support
	(
		name,
		price
		
	)
VALUES 
	(
		N'Dịch vụ Yoga ',
		700000
	)