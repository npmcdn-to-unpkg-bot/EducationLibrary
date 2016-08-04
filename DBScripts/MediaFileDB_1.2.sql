USE master
GO
--Add exsist check

--		DATABASE CREATION BLOCK

CREATE DATABASE MediaLibraryDB
ON
(
	NAME = MediaLibrary,
	FILENAME = 'D:\Project\MediaLibraryDB\MediaLibrary.mdf',
	SIZE = 50mb,
	FILEGROWTH = 10%
)
LOG ON
(
	NAME = MediaLibrary_log,
	FILENAME = 'D\Project\MediaLibraryDB\MediaLibrary.ldf',
	SIZE = 5mb,
	FILEGROWTH = 10%
)

USE MediaLibraryDB
GO



--		CREATE TABLE BLOCK

CREATE TABLE MediaType
(
	IdType				BIGINT			NOT NULL IDENTITY,
	TypeName			NVARCHAR (MAX)	NOT NULL
		CONSTRAINT PK_IdType PRIMARY KEY (IdType)
)

CREATE TABLE Category
(
	IdCategory			BIGINT			NOT NULL IDENTITY,
	CategoryName		NVARCHAR (MAX)	NOT NULL
		CONSTRAINT PK_Category PRIMARY KEY (IdCategory)
)

CREATE TABLE SubCategory
(
	IdSubCategory		BIGINT			NOT NULL IDENTITY,
	SubCategoryName		NVARCHAR (MAX)	NOT NULL,
	IdCategory			BIGINT			NOT NULL
		CONSTRAINT PK_SubCategory PRIMARY KEY (IdSubCategory)
)

CREATE TABLE Resourse
(
	IdResourse			BIGINT			NOT NULL IDENTITY,
	MediaFileName		NVARCHAR (MAX)	NOT NULL,	
	MediaFileLocation	NVARCHAR (MAX)	NOT NULL,	--change field to Table(Location, ) 
	Duration			FLOAT			NOT NULL,	--change name to Length
  --IsFavorite			BIT				NOT NULL, --Index !!!
	IdType				BIGINT			NOT NULL, 
		CONSTRAINT PK_IdResourse PRIMARY KEY (IdResourse)
)

CREATE TABLE Author
(
	IdAuthor			BIGINT			NOT NULL IDENTITY,
	Name				NVARCHAR(MAX)	NOT NULL
		CONSTRAINT PK_IdAuthor PRIMARY KEY (IdAuthor)
)

CREATE TABLE AdditionalFileInfo
(
	IdResourse			BIGINT			NOT NULL,
	DateCreation		DATE			NULL,
	ResourseDescription	NVARCHAR (MAX)	NULL,
	ResourseVersion		FLOAT			NULL
)

CREATE TABLE ResourseCategory
(
	IdCategory			BIGINT			NOT NULL,
	IdResourse			BIGINT			NOT NULL 
)
GO

CREATE TABLE AuthorResourse
(
	IdResourse			BIGINT			NOT NULL,
	IdAuthor			BIGINT			NOT NULL
)

CREATE TABLE Languages
(
	IdResourse			BIGINT			NOT NULL,
	ResourseLanguage	NVARCHAR (MAX)	NOT NULL
)

--		ADDITIONAL CONSTRAINT BLOCK
ALTER TABLE Resourse
	ADD CONSTRAINT FK_Resourse_Type FOREIGN KEY	(IdType)
	REFERENCES	MediaType (IdType) 

ALTER TABLE AdditionalInfo
	ADD CONSTRAINT FK_Info_Resourse FOREIGN KEY	(IdResourse)
	REFERENCES	Resourse (IdResourse) 

ALTER TABLE ResourseCategory
	ADD CONSTRAINT FK_Category_Resourse FOREIGN KEY (IdCategory)
	REFERENCES Category (IdCategory) 

ALTER TABLE ResourseCategory
	ADD CONSTRAINT FK_Resourse_Category FOREIGN KEY (IdResourse)
	REFERENCES Resourse (IdResourse)
	
ALTER TABLE SubCategory
	ADD CONSTRAINT FK_SubCategory FOREIGN KEY (IdCategory)
	REFERENCES	Category (IdCategory) 

ALTER TABLE AuthorResourse
	ADD CONSTRAINT	FK_Author_Resourse FOREIGN KEY	(IdAuthor)
	REFERENCES	Author (IdAuthor)
ALTER TABLE AuthorResourse
	ADD CONSTRAINT FK_Resourse_Author FOREIGN KEY (IdResourse)
	REFERENCES Resourse (IdResourse)

ALTER TABLE Languages
	ADD CONSTRAINT FK_Language FOREIGN KEY (IdResourse)
	REFERENCES	Resourse (IdResourse)
GO

--CREATE NONCLUSTERED INDEX IX_IsFavorite
	--ON MediaFile (IsFavorite)
