CREATE DATABASE BOOKMYEVENT

CREATE TABLE BME_TBL_USERS(user_id bigint primary key identity(1,1),username varchar(200),email varchar(200),
                           password varchar(220),mobile_number bigint,gender varchar(200),dob date,
						   address varchar(200),created_date date,updated_date date,login_time date,
						   logout_time date); 
 SELECT * FROM BME_TBL_USERS

 
 CREATE TABLE BME_TBL_ADMIN(admin_id bigint primary key identity(1,1),name varchar(200),email varchar(200),
                            password varchar(200),mobile_number bigint,login_time date,logout_time date);
 SELECT * FROM BME_TBL_ADMIN

 CREATE TABLE BME_TBL_SUPER_ADMIN(super_admin_id bigint primary key identity(1,1),name varchar(200),email varchar(200),
                            password varchar(200),mobile_number bigint,login_time date,logout_time date);
 
 SELECT * FROM BME_TBL_SUPER_ADMIN

 CREATE TABLE BME_TBL_EVENTS(event_id bigint primary key identity(1,1),name varchar(200),venue varchar(200),
                             location varchar(200), start_date date,end_date date,price decimal,description varchar(200));

 SELECT * FROM BME_TBL_EVENTS


