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
	DateJoined		date			
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
	PlayerID		int				NOT NULL		foreign key references Player( PlayerID ),
	ItemID			int				NOT NULL		foreign key references Item( ItemID )
)
GO

Insert	Player(Username, Password, EmailAddress, DateJoined)
		values('admin', 'Admin!', 'InvalidEmail@Notawebsite.net', '1/1/1')
GO

Insert		Item(ItemName, ItemDesc)
		values	('Plunger of Doom', 'The stronger you are the more it sucks.'),
				('Cap of Prince Dunces', 'A hat that once belonged to the wisest of men.'),
				('"Shrinking Potion"', 'Actually makes you grow twice your normal size.'),
				('Shadowmorne', 'Its bugged on warmane.'),
				('Rotten Potato', 'If this was runescape, this item would be the best item in the game. But its not.')
GO
