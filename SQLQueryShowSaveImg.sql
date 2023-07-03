create table tbl_imgRecord
(
	id int identity(1,1) primary key,
	Uname varchar(50),
	Uemail varchar(50),
	Uimage image
)

select * from tbl_imgRecord

ALTER TABLE tbl_imgRecord
ALTER COLUMN Uimage varbinary(MAX);