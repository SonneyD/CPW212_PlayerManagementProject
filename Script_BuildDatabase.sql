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
	PlayerID		int			NOT NULL			IDENTITY(1,1)	Primary Key,
	PlayerUDID		int			NOT NULL,
	InventoryID		int			NOT NULL,
)
GO

CREATE TABLE PlayerUserData(
	PlayerUDID		int				NOT NULL		IDENTITY(1,1)	Primary Key,
	[Username]		varchar(32)		NOT NULL,
	[Password]		varchar(16)		NOT NULL,
	EmailAddress	varchar(255)	NOT NULL,
	DateJoined		date			NOT NULL
)
GO

CREATE TABLE Inventory(
	InventoryID		int				NOT NULL		IDENTITY(1,1)	Primary Key,
)
GO

CREATE TABLE Item(
	ItemID			int				NOT NULL		IDENTITY(1,1)	Primary Key,
	ItemName		varchar(144)	NOT NULL,
	ItemDesc		varchar(255),

	InventoryID		int				NOT NULL,

)
GO