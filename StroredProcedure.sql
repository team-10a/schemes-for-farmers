create procedure [dbo].[SP_Farmer]
(
@Full_Name varchar(50),
@Contact_No int,
@Email_Id varchar(Max),
@Address varchar (max) ,
@City varchar(20) ,
@State varchar(20) ,
@Pincode nvarchar(50),
@Account_No integer ,
@IFSC varchar(20),
@Aadhar int,
@Pan varchar(20),
@Trader_License varchar(20),
@Password varchar(20),
@IsSuccess BIT OUTPUT,
	@Message Nvarchar(200) OUTPUT
)	
as
begin
set @IsSuccess='false'
insert into Farmer(Full_Name,Contact_No,Email_Id,Address,city,State,Pincode,Account_No,IFSC,Aadhar,Pan,Trader_License,Password)
values(@Full_Name,@Contact_No,@Email_Id,@Address,@City,@State,@Pincode,@Account_No,@IFSC,@Aadhar,@Pan,@Trader_License,@Password)
begin
		set @Message = ' Farmer Registration failed'
		set @IsSuccess = 'FALSE'
		
		end
		
		begin
		
		set @Message = 'farmer Registered successfully'
		set @IsSuccess = 'TRUE'
		
		END
		
END
