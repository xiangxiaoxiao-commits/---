create table xiangx_class16(
	xx_cno16 char(10) not null,
	xx_mno16 char(10) ,
	xx_classnum16 int,
	foreign key(xx_mno16) references xiangx_major16(xx_mno16),
	primary key(xx_cno16)
	)
