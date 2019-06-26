﻿USE master
IF EXISTS(select * from sys.databases where name='BikeForLife')
DROP DATABASE BikeForLife

CREATE DATABASE BikeForLife
GO

USE [BikeForLife]
GO

CREATE TABLE BikeRoutes(
	BikeRouteId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name NVARCHAR(max) NOT NULL,
	Length FLOAT NOT NULL,
	Difficulty INT NOT NULL,
	Country NVARCHAR(max) NOT NULL,
	City NVARCHAR(max) NOT NULL
)

INSERT BikeRoutes VALUES ('Lundbykrat', 15.3, 1, 'Denmark', 'Gistrup')
INSERT BikeRoutes VALUES ('Rebild bakker', 28.4, 2, 'Denmark', 'Rebild')
INSERT BikeRoutes VALUES ('Aalborg Rundt', 65.2, 3, 'Denmark', 'Aalborg')
INSERT BikeRoutes VALUES ('Klokkeholm sø tur', 3.5, 0, 'Denmark', 'Klokkeholm')
GO

CREATE TABLE Members(
	MemberId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name NVARCHAR(max) NOT NULL,
	EnrollmentDate DATE NOT NULL
)
GO

INSERT Members VALUES ('Mich Jensen', '2019-05-21')
INSERT Members VALUES ('Gitte Olsen', '2019-04-09')
INSERT Members VALUES ('Trols Hansen', '2019-06-15')
GO

CREATE TABLE Rides(
	RideId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	MemberId INT NOT NULL FOREIGN KEY REFERENCES Members(MemberId),
	BikeRouteId INT NOT NULL FOREIGN KEY REFERENCES BikeRoutes(BikeRouteId),
	RideDate DATE NOT NULL 	
)
GO

INSERT Rides VALUES (1, 4, '2019-01-01')
INSERT Rides VALUES (1, 4, '2019-02-01')
INSERT Rides VALUES (1, 4, '2019-03-01')
INSERT Rides VALUES (1, 4, '2019-04-01')
INSERT Rides VALUES (1, 4, '2019-05-01')
GO