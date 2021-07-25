

create table NewStudent(
NAID int NOT NULL IDENTITY(1,1) primary key,
rollno varchar(10) not null,
stuname varchar(250) not null,
dept varchar(250) not null,
yr varchar(50) not null,
sem varchar(10) not null,
div varchar(10) not null,
yoa varchar(50) not null,
sex varchar(50) not null,
guarname varchar(250) not null,
email varchar(250) not null,
mobileno bigint not null,
gmobile bigint not null,
feeamt varchar(50) not null,
paid varchar(10) not null,
);



select * from NewStudent

select max(NAID) from NewStudent;

create table fees
(
fid int NOT NULL IDENTITY (1,1) primary key,
rollno int not null,
fees int not null
);


select * from fees