--create database Financing;
--go
use Financing;
go
--create table users (
--	UserId int primary key not null,
--	UserName nchar(20) not null,
--	Password nvarchar(20) not null
--);
--insert into users (
--	UserId, UserName, Password
--)values(
--	1, 'YLD', '123456'
--)

--create table Category(
--	CategoryID int not null primary key,
--	CategoryName nvarchar(20) not null,
--	ISPayout int not null,
--	Remark nvarchar(100)
--)

--create table Item(
--	ItemID int not null primary key,
--	ItemName nvarchar(20) not null,
--	CategoryID int not null,
--	Remark nvarchar(20)
--)

create table List(
	ListID int not null primary key,
	Item
)