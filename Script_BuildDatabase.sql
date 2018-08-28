USE master
GO

IF DB_ID ('AA_CPW212_ProjectDB') IS NOT NULL
	DROP DATABASE AA_CPW212_ProjectDB
GO

CREATE DATABASE AA_CPW212_ProjectDB
GO

USE AA_CPW212_ProjectDB
GO


CREATE TABLE Player(
	PlayerID		int			NOT NULL			identity primary key,

	[Username]		varchar(32)		NOT NULL,
	[Password]		varchar(16)		NOT NULL,
	EmailAddress	varchar(255)	NOT NULL,
	DateJoined		date			NOT NULL
)
GO

CREATE TABLE Item(
	ItemID			int				NOT NULL		identity primary key,
	ItemName		varchar(144)	NOT NULL,
	ItemDesc		varchar(255),
)
GO

CREATE TABLE Inventory(
	InventoryID		int				NOT NULL		identity primary key,
	PlayerID		int				NOT NULL		foreign key references Player( PlayerID )
)
GO
