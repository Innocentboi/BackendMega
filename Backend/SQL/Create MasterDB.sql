CREATE DATABASE MasterDB

CREATE TABLE ms_user
(
	user_name varchar(300) not null,
	password varchar(300) not null,
	user_type varchar(5) not null,
	CONSTRAINT PK_ms_user PRIMARY KEY (user_name)
)

CREATE TABLE ms_storage_location
(
	location_id varchar(10),
	location_name varchar(100),
	CONSTRAINT PK_ms_storage_location PRIMARY KEY (location_id)
);