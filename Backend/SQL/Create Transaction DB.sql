CREATE DATABASE Transaction_DB_1
CREATE DATABASE Transaction_DB_2

CREATE TABLE tr_bpkb
(
	agreement_number varchar(100),
	bpkb_no varchar(100),
	branch_id varchar(10),
	bpkb_date datetime,
	faktur_no varchar(100),
	faktur_date datetime,
	location_id varchar(10),
	police_no varchar(20),
	bpkb_date_in datetime,
	CONSTRAINT PK_tr_bpkb PRIMARY KEY (agreement_number)
);
