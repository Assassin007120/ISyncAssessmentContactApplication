-- Create tables of Category and Contact

CREATE TABLE Category(
	Id INT PRIMARY KEY IDENTITY(1,1),
	CategoryName VARCHAR(50) NOT NULL,
	IsActive BIT NOT NULL DEFAULT 1
);

CREATE TABLE Contact(
	Id INT PRIMARY KEY IDENTITY(1,1),
	CategoryId INT NOT NULL REFERENCES Category(Id),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DateOfBirth DATE, 
	CellNumber NVARCHAR(10),
	Email VARCHAR(50) NOT NULL UNIQUE,
	ContactImage IMAGE, 
	DateCreated DATETIME,
	Active BIT NOT NULL
);

-- Insert default record into Category table
INSERT INTO dbo.Category (CategoryName, IsActive)
VALUES ('None', 1);