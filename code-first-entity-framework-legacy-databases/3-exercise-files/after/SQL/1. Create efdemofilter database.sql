CREATE DATABASE efdemofilter ON PRIMARY 
( NAME = N'efdemofilter',     FILENAME = N'S:\MSSQL\DATA\efdemofilter.mdf' ,    SIZE = 5MB,    FILEGROWTH = 1MB ) LOG ON 
( NAME = N'efdemofilter_log', FILENAME = N'S:\MSSQL\DATA\efdemofilter_log.ldf', SIZE = 1024KB, FILEGROWTH = 10%);
GO
ALTER DATABASE [efdemofilter] SET COMPATIBILITY_LEVEL = 110
ALTER DATABASE [efdemofilter] SET RECOVERY SIMPLE WITH NO_WAIT
GO
