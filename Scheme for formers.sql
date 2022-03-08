create database agriculture

Create table UserInfo (
Email varchar(50) not null,
Password varchar(10) not null );



create table Farmer(
Full_Name varchar(50),
Contact_No int not null,
Email_Id varchar(50),
Address varchar (max) not null,
city varchar(20) not null,
State varchar(20) not null,
Pincode int,
Account_No integer not null,
IFSC varchar(20),
Adhar int,
PAN varchar(20),
Trader_License varchar(20),
Password varchar(20),
);



create table Bidder(
Full_Name varchar(50),
Contact_No int not null,
Email_Id varchar(50),
Address varchar (max) not null,
city varchar(20) not null,
State varchar(20) not null,
Pincode int,
Account_No integer not null,
IFSC varchar(20),
Adhar int,
PAN varchar(20),
Trader_License varchar(20),
Password varchar(20));


Create table CropBidDetails(
Crop_Type varchar(20),
Crop_Name varchar(20),
Fertilizer_Type varchar(20),
Quantity decimal,
Soil_Ph_Certificate imagepath(),
Sold_To,
Date date,
MSP decimal ,
Solid_Price decimal,
Total_Price decimal,
Base_Price decimal,
Current_Bid decimal,
Bid_Amount decimal);








 


