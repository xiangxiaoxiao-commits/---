USE master
GO
CREATE DATABASE xiangxiaoMIS16
ON
( NAME =xiangxiaoMIS16_Data,
	FILENAME = 'D:\DATABASE\xiangxiaoMIS16_Data.mdf',
	SIZE = 10,
	MAXSIZE = 50,
	FILEGROWTH = 5 )
LOG ON
( NAME = 'xiangxiaoMIS16_Log',
	FILENAME = 'D:\DATABASE\xiangxiaoMIS16_Log.ldf',
	SIZE = 5MB,
	MAXSIZE = 25MB,
	FILEGROWTH = 5MB )
GO