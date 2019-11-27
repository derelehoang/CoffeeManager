﻿CREATE DATABASE COFFEE_MANAGERMENT
GO
USE COFFEE_MANAGERMENT
----
CREATE TABLE TABLE_DRINK
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100) NOT NULL DEFAULT N'BÀN CHƯA ĐẶT TÊN',
	STATUS NVARCHAR(100) DEFAULT N'BÀN TRỐNG'
)
GO
----

CREATE TABLE ACCOUNT
(
	USERNAME NVARCHAR(100) PRIMARY KEY,
	DISPLAYNAME NVARCHAR(100)NOT NULL DEFAULT 'DERE',
	PASS NVARCHAR(100) NOT NULL DEFAULT 0,
	TYPE INT NOT NULL DEFAULT 0
)
GO
---
CREATE TABLE DRINK_CATEGORY
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100) NOT NULL DEFAULT N'CHƯA ĐẶT TÊN'
)
GO
----
CREATE TABLE DRINK
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100) NOT NULL DEFAULT N'CHƯA ĐẶT TÊN',
	ID_CATEGORY INT NOT NULL,
	PRICE FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (ID_CATEGORY) REFERENCES DBO.DRINK_CATEGORY(ID)
)
GO
-----
CREATE TABLE BILL
(
	ID INT IDENTITY PRIMARY KEY,
	DATE_CHECKIN DATE NOT NULL DEFAULT GETDATE(),
	DATE_CHECKOUT DATE NOT NULL,
	ID_TABLE INT NOT NULL,
	STATUS INT NOT NULL DEFAULT 0

	FOREIGN KEY (ID_TABLE) REFERENCES DBO.TABLE_DRINK(ID)
)
GO
-----
CREATE TABLE BILL_INFO
(
	ID INT IDENTITY PRIMARY KEY,
	ID_BILL INT NOT NULL,
	ID_DRINK INT NOT NULL,
	COUNT INT NOT NULL DEFAULT 0

	FOREIGN KEY (ID_BILL) REFERENCES DBO.BILL(ID),
	FOREIGN KEY (ID_DRINK) REFERENCES DBO.DRINK(ID)
)
GO


CREATE PROC USP_GetAccountByUserName
@Username nvarchar(100)
AS
BEGIN
	SELECT * FROM ACCOUNT WHERE USERNAME = @username
END


EXEC USP_GetAccountByUserName @username = N'DERE'

SELECT * FROM ACCOUNT WHERE USERNAME ='DERE' AND PASS = '123123'


go
CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN

	SELECT * FROM ACCOUNT WHERE @userName = USERNAME and @passWord = PASS
END

exec USP_Login @userName , @passWord


DECLARE @1 INT = 1
WHILE @1 <= 9
BEGIN
		INSERT TABLE_DRINK (NAME) VALUES (N'BÀN' + CAST(@1 AS NVARCHAR(100)))
		SET @1 = @1 + 1
END

select * from TABLE_DRINK

GO
CREATE PROC USP_GETTableList
AS SELECT * FROM TABLE_DRINK

EXEC USP_GETTableList

UPDATE TABLE_DRINK
SET STATUS = N'CÓ NGƯỜI' WHERE ID = 1788953

EXEC USP_GETTableList

GO
---THÊM BÀN
DECLARE @1 INT = 1
WHILE @1 <= 9
BEGIN
		INSERT TABLE_DRINK (NAME) VALUES (N'BÀN' + CAST(@1 AS NVARCHAR(100)))
		SET @1 = @1 + 1
END


SELECT * FROM BILL
SELECT * FROM BILL_INFO
SELECT * FROM DRINK
SELECT * FROM DRINK_CATEGORY

INSERT DBO.BILL
(
DATE_CHECKIN,
DATE_CHECKOUT,
ID_TABLE,
STATUS)
VALUES
(GETDATE(),
GETDATE(),
1788945,
0),
(GETDATE(),
GETDATE(),
1788946,
0),
(GETDATE(),
GETDATE(),
1788947,
1)

--select * from BILL where ID_TABLE = 1788945 and STATUS = 0
select * from BILL_INFO where ID_BILL = 5

select * from BILL
select * from BILL_INFO
select * from DRINK
select * from DRINK_CATEGORY
select * from TABLE_DRINK


