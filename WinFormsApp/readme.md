Create SQL Server Database

Run table creation:

-- DbTohaNTT.dbo.ParkingLot definition

-- Drop table

-- DROP TABLE DbTohaNTT.dbo.ParkingLot;

CREATE TABLE DbTohaNTT.dbo.ParkingLot (
	Slot int NOT NULL,
	PlatNo varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	MotorType varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	RegistrationNoColour varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CheckInTime datetime DEFAULT getdate() NULL
);



Config connection String at settings.json at block string : SQLConnectionString



If Setting Total slot is not available, default is 6