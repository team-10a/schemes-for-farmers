USE [agriculture]
GO
/****** Object:  StoredProcedure [dbo].[SP_Bidder]    Script Date: 3/8/2022 9:56:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SP_Bidder]
(
@Full_Name varchar(50),
@Contact_No varchar(10),
@Email_Id varchar(Max),
@Address varchar (max) ,
@City varchar(20) ,
@State varchar(20) ,
@Pincode nvarchar(50),
@Account_No varchar(50) ,
@IFSC varchar(20),
@Aadhar nvarchar(20),
@Pan varchar(20),
@Trader_License varchar(20),
@Password varchar(20),
@IsSuccess BIT OUTPUT,
	@Message Nvarchar(200) OUTPUT
)	
as
begin
set @IsSuccess='false'
insert into Bidder(Full_Name,Contact_No,Email_Id,Address,city,State,Pincode,Account_No,IFSC,Aadhar,Pan,Trader_License,Password)
values(@Full_Name,@Contact_No,@Email_Id,@Address,@City,@State,@Pincode,@Account_No,@IFSC,@Aadhar,@Pan,@Trader_License,@Password)
begin
		set @Message = ' Bidder Registration failed'
		set @IsSuccess = 'FALSE'
		
		end
		
		begin
		
		set @Message = 'Bitter Registered successfully'
		set @IsSuccess = 'TRUE'
		
		END
		
END