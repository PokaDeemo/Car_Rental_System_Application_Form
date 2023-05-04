CREATE DATABASE ASSIGNMENT01
USE ASSIGNMENT01;

CREATE Table Account
(
	AccountID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	AccountUsername VARCHAR (1000),
	AccountPassword VARCHAR (1000),
	AccountEmail VARCHAR (1000),
	AccountRole VARCHAR (100),
)

SELECT * FROM Account

INSERT INTO Account(AccountUsername, AccountPassword, AccountEmail, AccountRole)
VALUES('Freeman', '1234', 'Freeman@gmail.com', 'Employee') 

INSERT INTO Account(AccountUsername, AccountPassword, AccountEmail, AccountRole)
VALUES('Admin', '1234', 'Admin@gmail.com', 'Admin')

CREATE TABLE RentalCarData 
(
	CustomerID INT NOT NULL PRIMARY KEY,
	SocialSecurityNo VARCHAR (1000),
	Title VARCHAR (1000),
	FirstName VARCHAR (1000),
	Surname VARCHAR (1000),
	ContactNo VARCHAR (1000),
	PostalCode VARCHAR (1000),
	City VARCHAR (1000),
	Country VARCHAR (1000),
	VehicleID VARCHAR(1000),
	CarEngine VARCHAR (1000),
	CarRegistYear VARCHAR (1000),
	CarModel VARCHAR (1000),
	CarColor VARCHAR (1000),
	CarSpecification VARCHAR (1000),
	MilesBefore VARCHAR(1000),
	MilesAfter VARCHAR(1000),
	CarCategory VARCHAR (1000),
	PersonalHire VARCHAR (1000),
	CharteredHire VARCHAR (1000),
	BookingNo VARCHAR (1000),
	DaysRented VARCHAR (1000),
	RentalDate DATE,
	RentalTime VARCHAR (1000),
	MeterSetting VARCHAR (1000),
	DiscountRate VARCHAR (1000),
	DayOfTariff FLOAT,
	TotalCost FLOAT,
)

SELECT * FROM RentalCarData

DROP TABLE RentalCarData

CREATE TABLE ReturnCarDetails
(
	BookingNo VARCHAR (1000),
	ReturnDate DATE,
	ReturnTime VARCHAR (1000),
	ReturnMeterSetting VARCHAR (1000),
)

SELECT * FROM ReturnCarDetails

DROP TABLE ReturnCarDetails