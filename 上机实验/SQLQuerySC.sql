--create database SC;

use SC;
go
--CREATE TABLE administrators (
--	ID INT PRIMARY KEY NOT NULL,
--	USerName VARCHAR(20) NOT NULL,
--	Passwd VARCHAR(20) NOT NULL,
--	CHECK (ID > 0)
--);

--create table students (
--	ID varchar(15) primary key not null,
--	StuName varchar(20) not null,
--	StuSex int not null,
--	StuCollege varchar(25) not null,
--	StuMajor varchar(20) not null,
--	StuClass varchar(10) not null,
--	Passwd varchar(20) not null,
--	check (StuSex >= 0 and StuSex <= 1)
--);

--create table teachers (
--	ID varchar(15) primary key not null,
--	TeaName varchar(20) not null,
--	TeaSex int not null,
--	TeaTitle varchar(10) not null,
--	Passwd varchar(20) not null,
--	check (TeaSex >= 0 and TeaSex <= 1)
--);

--create table courses (
--	ID varchar(15) primary key not null,
--	CouName varchar(20) not null,
--	TeaID varchar(15) foreign key references teachers(ID) not null,
--	CouTime int not null,
--	CouPoint int not null,
--	check (CouTime > 0 and CouPoint > 0)
--);

--create table selectCourses (
--	CouID varchar(15) not null foreign key references courses(ID),
--	StuID varchar(15) not null foreign key references students(ID),
--	CouScore int
--	check (CouScore >= 0 and CouScore <= 100)
--);

--insert into administrators (UserName, Passwd)
--values ('admin','123456');

--insert into students
--values('3150931035','yld',1,'计算机科学与工程学院','网络工程','网络152','123456');

--insert into teachers
--values('100','ch',1,'讲师','123456');

--insert into courses
--values('200','软件开发技术','100','60','3');

--insert into selectCourses(CouID, StuID)
--values('200','3150931035');