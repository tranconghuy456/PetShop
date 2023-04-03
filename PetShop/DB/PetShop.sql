CREATE DATABASE [PetShop];
GO
USE [PetShop];
GO
CREATE TABLE Users(
	UID			BIGINT PRIMARY KEY,
	Username	NVARCHAR(50) UNIQUE,
	Password	NVARCHAR(50),
	IsActive	BIT,
	IsAdmin		BIT,
	IsMod		BIT
)
GO

INSERT INTO [PetShop].[dbo].[Users] VALUES(1, 'huydev@admin.com', '19032003', 1, 1, 0);