Create Database PersonalShopping
Go
Use PersonalShopping
GO
Create Table SystemUsers
(
UserId int PRIMARY KEY IDENTITY(1,1),
FirstName nvarchar (50),
LastName nvarchar (50),
UserName nvarchar (50),
Password nvarchar (50),
CreatedOn DateTime,
CreatedBy int,
UpdateOn DateTime,
UpdateBy int,
)
GO
Create Table Items 
(
ItemId int PRIMARY KEY IDENTITY(1,1),
ItemName nvarchar (200),
Unit nvarchar(50),
Quantity float,
UserId int,
FOREIGN KEY (UserId) REFERENCES SystemUsers(UserId)
CreatedOn DateTime,
CreatedBy int,
UpdateOn DateTime,
UpdateBy int,
)
GO
