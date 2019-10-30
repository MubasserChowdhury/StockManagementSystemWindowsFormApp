CREATE DATABASE StockManagementSystem;

CREATE TABLE Categories(
Id INT PRIMARY KEY IDENTITY(1,1),
Code VARCHAR (4),
Name VARCHAR (50)
);

CREATE TABLE Products(
Id INT PRIMARY KEY IDENTITY(1,1),
Code VARCHAR (4),
Name VARCHAR (50),
CategoryId INT REFERENCES Categories(Id),
ReorderLevel INT,
[Description] VARCHAR(MAX)
);

CREATE VIEW ProductInformation AS
SELECT p.Id,p.Code,p.Name,c.Name AS Category,ReorderLevel,[Description] FROM Products AS p
LEFT JOIN Categories AS c ON c.Id=p.CategoryId 

CREATE TABLE Customers(
Id INT PRIMARY KEY IDENTITY(1,1),
Code VARCHAR (4),
Name VARCHAR (50),
[Address] VARCHAR(200),
Email VARCHAR(100),
Contact VARCHAR(11),
LoyaltyPoint FLOAT
);


CREATE TABLE Suppliers(
Id INT PRIMARY KEY IDENTITY(1,1),
Code VARCHAR (4),
Name VARCHAR (50),
[Address] VARCHAR(200),
Email VARCHAR(100),
Contact VARCHAR(11),
ContactPerson VARCHAR(50)
);
CREATE TABLE Purchases(
Id INT PRIMARY KEY IDENTITY(1,1),
[Date] DATE,
InvoiceNo VARCHAR(15),
SupplierId INT REFERENCES Suppliers(Id),
ProductId INT REFERENCES Products(Id),
Code VARCHAR(15),
ManufacturedDate DATE,
[ExpireDate] DATE,
Quantity INT,
UnitPrice FLOAT,
TotalPrice FLOAT,
MRP FLOAT,
Remarks VARCHAR(MAX)
);
CREATE TABLE Sales(
Id INT PRIMARY KEY IDENTITY(1,1),
CustomerId INT REFERENCES Customers(Id),
ProductId INT REFERENCES Products(Id),
Code VARCHAR(15),
[Date] DATE,
Quantity INT,
MRP FLOAT,
TotalMRP FLOAT,
);

