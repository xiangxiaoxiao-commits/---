create table xiangx_student16(
	xx_sno16 char(10) not null,
	xx_cno16 char(10) ,
	xx_sname16 char(20) not null,
	xx_ssex16 char(4),
	xx_sage16 int,
	xx_sbp char(20),
	xx_scredit int,
	foreign key(xx_cno16) references xiangx_class16(xx_cno16),
	primary key(xx_sno16)
	)
