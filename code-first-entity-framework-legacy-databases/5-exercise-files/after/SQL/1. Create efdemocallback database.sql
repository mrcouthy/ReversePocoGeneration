CREATE DATABASE efdemocallback ON PRIMARY 
( NAME = N'efdemocallback',     FILENAME = N'S:\MSSQL\DATA\efdemocallback.mdf' ,    SIZE = 5MB,    FILEGROWTH = 1MB ) LOG ON 
( NAME = N'efdemocallback_log', FILENAME = N'S:\MSSQL\DATA\efdemocallback_log.ldf', SIZE = 1024KB, FILEGROWTH = 10%);
GO
ALTER DATABASE [efdemocallback] SET COMPATIBILITY_LEVEL = 110
ALTER DATABASE [efdemocallback] SET RECOVERY SIMPLE WITH NO_WAIT
GO

USE efdemocallback
GO

CREATE TABLE Symbols
(
	[$] INT NOT null PRIMARY KEY,
	[%] INT null,
	[£] INT null,
	[&callbacks$] INT null
);

CREATE TABLE tblOrders          ( ID INT NOT NULL PRIMARY KEY IDENTITY(1,1), added DATETIME NOT NULL );
CREATE TABLE tblOrderLines      ( ID INT NOT NULL PRIMARY KEY IDENTITY(1,1), OrderID INT NOT NULL, sku VARCHAR(15) NULL );
CREATE TABLE tblOrderErrors     ( ID INT NOT NULL PRIMARY KEY IDENTITY(1,1), OrderID INT NOT NULL, error VARCHAR(50) NULL );
CREATE TABLE AB_OrdersAB_       ( ID INT NOT NULL PRIMARY KEY IDENTITY(1,1), added DATETIME NOT NULL );
CREATE TABLE AB_OrderLinesAB_   ( ID INT NOT NULL PRIMARY KEY IDENTITY(1,1), OrderID INT NOT NULL, sku VARCHAR(15) NULL );
CREATE TABLE tblOrderErrorsAB_  ( ID INT NOT NULL PRIMARY KEY IDENTITY(1,1), OrderID INT NOT NULL, error VARCHAR(50) NULL );
GO
ALTER TABLE tblOrderLines ADD CONSTRAINT tblOrdersFK FOREIGN KEY (OrderID) REFERENCES tblOrders (id);
ALTER TABLE AB_OrderLinesAB_ ADD CONSTRAINT AB_OrderLinesAB_FK FOREIGN KEY (OrderID) REFERENCES AB_OrdersAB_ (id);
GO

-- Stored procedure with multiple results
CREATE PROCEDURE [dbo].[stp_order_details] (@order_id INT)
AS
    SELECT * FROM tblOrders WHERE ID = @order_id;
    SELECT * FROM tblOrderLines WHERE OrderID = @order_id;
    SELECT * FROM tblOrderErrors WHERE OrderID = @order_id;
GO

-- Enums
CREATE TABLE Car
(
    Id INT NOT NULL PRIMARY key,
    PrimaryColourId INT NOT NULL,
    CarMake VARCHAR(255) NOT NULL
)
GO
CREATE TABLE Colour
(
    Id INT NOT NULL PRIMARY key,
    Name VARCHAR(255) NOT NULL
)
GO
CREATE TABLE CarToColour
(
    CarId INT NOT NULL,
    ColourId INT NOT NULL,
)
GO
ALTER TABLE Car ADD CONSTRAINT CarPrimaryColourFK FOREIGN KEY (PrimaryColourId) REFERENCES Colour (Id);
ALTER TABLE CarToColour ADD PRIMARY KEY (CarId, ColourId);
ALTER TABLE CarToColour ADD CONSTRAINT CarToColour_CarId FOREIGN KEY (CarId) REFERENCES Car (Id);
ALTER TABLE CarToColour ADD CONSTRAINT CarToColour_ColourId FOREIGN KEY (ColourId) REFERENCES Colour (Id);
GO
INSERT INTO Colour (Id, Name) VALUES (1, 'Red'),(2,'Green'),(3,'Blue')
INSERT INTO Car (Id, PrimaryColourId, CarMake) VALUES (1, 1, 'Ford'),(2,3, 'Saab')
INSERT INTO CarToColour (CarId, ColourId) VALUES (1,2),(2,1),(2,2)
