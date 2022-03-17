create database Agriculture
/* User */
create table UserDetails(
UserTypeId int primary key not null,
UserType Varchar (20)
);

/* Login Info (Admin) (Farmer) (Bidder) */
create table LoginInfo(
EmailId varchar (100),
Password varchar (30),
UserId int FOREIGN KEY REFERENCES UserInfo(UserId),
UserTypeId int FOREIGN KEY REFERENCES UserDetails(UserTypeId)
);


/* UserInfo */
create table UserInfo(
FullName varchar (20),
ContactNo int not null,
EmailId	varchar(100),
Address	varchar(100),
City varchar(20),
State varchar(20),
Pincode	int not null,
Password varchar(30),
PermittedtoSale varchar(20),
UserId int primary key not null,
UserTypeId int FOREIGN KEY REFERENCES UserDetails(UserTypeId)
);

/* Bank Details */
create table BankDetails(
AccountNo int not null,
IFSCCode varchar(30),
Adhar int not null,
Pan	varchar(20),
TraderLicense varchar(30),
UserId int FOREIGN KEY REFERENCES UserInfo(UserId)
);

/* Farmer - Welcome Login Page */

Create table PlaceSellRequest(
CropType varchar(20) not null,
CropName varchar(20),
FertilizerType varchar(20),
Quantity decimal,
SoilPhCertificate varchar (max),
Primary Key(CropType),
UserId int FOREIGN KEY REFERENCES UserInfo(UserId)
);

Create table ViewSoldCropHistory(
Date date,
CropName varchar(20),
Quantity decimal (18,2),
MSP decimal (18,2),
SolidPrice decimal (18,2),
TotalPrice decimal(18,2),
UserId int FOREIGN KEY REFERENCES UserInfo(UserId)
);

Create table ViewMarketPlace(
CropType varchar(20) not null,
CropName varchar(20),
BasePrice decimal(18,2),
CurrentBid decimal(18,2),
Primary Key(CropName),
UserId int FOREIGN KEY REFERENCES UserInfo(UserId)
);

/* -------------------------------- */

/* Insurance */

create table ApplyForPolicy(
Season varchar(50),
Year date,
CropName varchar(20), 
SumInsured decimal (18,2),
Area decimal (18,2) ,
Insurance_Company varchar(20),
SumInsuredperhect decimal (18,2),
SharePremium decimal (18,2),
PremiumAmount decimal (18,2),
Primary Key(CropName),
UserId int FOREIGN KEY REFERENCES UserInfo(UserId),
PolicyNo int FOREIGN KEY REFERENCES ClaimInsurance(PolicyNo)
);

create table ClaimInsurance(
ParticularsOfInsuree varchar (20),
PolicyNo int not null, 
InsuranceCompany varchar (20),
NameOfInsuree varchar (20),
SumInsured decimal (18,3),
CauseOfLoss nvarchar(max),
DateOfLoss date,
Primary Key(PolicyNo)
);

/*-----------------------------------------------*/

/* Bidder Welcome Page */

create table BidderWelcomePage(
CropName varchar (20),
CropType varchar (20),
BasePrice decimal (18,2),
CurrentBid	decimal (18,2),
Bidammount	decimal (18,2),
UserId int FOREIGN KEY REFERENCES UserInfo(UserId)
);


/* Crop */
create table CropType(
CropTypeId int primary key not null,
CropType varchar (30)
);

/*---------------------------------------------*/


/* Sell */
create table Sell(
SellId int primary key not null,
CropName varchar(20),
FertilizerType varchar(30),
Quantity decimal(18,2),
BasePrice decimal (18,2),
CropTypeId int FOREIGN KEY REFERENCES CropType(CropTypeId),
UserId int FOREIGN KEY REFERENCES UserInfo(UserId)
);

/*---------------------------------------------*/

/* Bidding */

create table Bidding(
BiddingId int primary key not null,
BidAmt decimal (18,2),
BidDate Date,
is_BitStatus BIT,
UserId int FOREIGN KEY REFERENCES UserInfo(UserId),
SellId int FOREIGN KEY REFERENCES Sell(SellId)
);
