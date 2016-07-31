CREATE DATABASE efdemocallback_spanish ON PRIMARY 
( NAME = N'efdemocallback_spanish',     FILENAME = N'S:\MSSQL\DATA\efdemocallback_spanish.mdf' ,    SIZE = 5MB,    FILEGROWTH = 1MB ) LOG ON 
( NAME = N'efdemocallback_spanish_log', FILENAME = N'S:\MSSQL\DATA\efdemocallback_spanish_log.ldf', SIZE = 1024KB, FILEGROWTH = 10%);
GO
ALTER DATABASE [efdemocallback_spanish] SET COMPATIBILITY_LEVEL = 110
ALTER DATABASE [efdemocallback_spanish] SET RECOVERY SIMPLE WITH NO_WAIT
GO

USE efdemocallback_spanish
GO

CREATE TABLE Cursos       ( ID INT NOT NULL PRIMARY KEY IDENTITY(1,1), added DATETIME NOT NULL );
CREATE TABLE Cervezas     ( ID INT NOT NULL PRIMARY KEY IDENTITY(1,1), added DATETIME NOT NULL );
GO
