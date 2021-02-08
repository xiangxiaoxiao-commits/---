create table xiangx_record16(
	xx_ccno16 char(10) not null,
	xx_tno16 char(10) not null,
	xx_sno16 char(10) not null,
	xx_rresult int,
	foreign key(xx_tno16) references xiangx_teacher16(xx_tno16),
	foreign key(xx_ccno16) references xiangx_course16(xx_ccno16),
	foreign key(xx_sno16) references xiangx_student16(xx_sno16),
	primary key(xx_tno16,xx_ccno16,xx_sno16)
	)