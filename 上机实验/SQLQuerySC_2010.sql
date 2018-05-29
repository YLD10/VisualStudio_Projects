--create database SC;

use SC;
go

--CREATE TABLE Administrators (
--	ID INT PRIMARY KEY NOT NULL,
--	userName VARCHAR(20) unique NOT NULL,
--	passwd VARCHAR(20) NOT NULL,
--	constraint checkID CHECK (ID >= 0)
--);

--create table Students (
--	ID varchar(15) primary key not null,
--	stuName varchar(20) not null,
--	stuSex int not null,
--	stuCollege varchar(25) not null,
--	stuMajor varchar(20) not null,
--	stuClass varchar(10) not null,
--	passwd varchar(20) not null,
--	check (StuSex >= 0 and StuSex <= 1)
--);

--create table Teachers (
--	ID varchar(15) primary key not null,
--	teaName varchar(20) not null,
--	teaSex int not null,
--	teaTitle varchar(10) not null,
--	passwd varchar(20) not null,
--	check (TeaSex >= 0 and TeaSex <= 1)
--);

--create table Courses (
--	ID varchar(15) primary key not null,
--	couName varchar(20) not null,
--	couTime int not null,
--	couPoint float not null,
--	constraint checkTime check (couTime > 0 and couPoint > 0)
--);

--create table CS (
--	couID varchar(15) not null ,
--	stuID varchar(15) not null ,
--	score float,
--	primary key (couID,stuID),
--	foreign key (couID) references Courses(ID) on delete cascade on update cascade,
--	foreign key (stuID) references Students(ID) on delete cascade on update cascade,
--	constraint checkScore check (score >= 0 and score <= 100)
--);

--create table TC (
--	teaID varchar(15) not null,
--	couID varchar(15) not null,
--	primary key (teaID,couID),
--	foreign key (teaID) references Teachers(ID) on delete cascade on update cascade,
--	foreign key (couID) references Courses(ID) on delete cascade on update cascade
--);

--create table ST (
--	stuID varchar(15) not null,
--	teaID varchar(15) not null,
--	primary key (teaID,stuID),
--	foreign key (teaID) references Teachers(ID) on delete cascade on update cascade,
--	foreign key (stuID) references Students(ID) on delete cascade on update cascade
--);

--insert into Administrators (userName, passwd)
--values ('admin','123456');

--insert into Students
--values('3150931035','yld',1,'计算机科学与工程学院','网络工程','网络152','123456');

--insert into Teachers
--values('100','ch',1,'讲师','123456');

--insert into Courses
--values('200','软件开发技术','100','60','3');

--insert into SelectCourses(couID, stuID)
--values('200','3150931035');
