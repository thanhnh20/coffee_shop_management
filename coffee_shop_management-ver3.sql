use master
go
drop database if exists [CoffeeShopManagement]
create database [CoffeeShopManagement]
go
use [CoffeeShopManagement];
go
drop table if exists [Role]
drop table if exists [Account]
drop table if exists [Staff]
drop table if exists [Category_Product]
drop table if exists [Product]
drop table if exists [Ingredient]
drop table if exists [Ingredient_Product]
drop table if exists [Customer]
drop table if exists [Payment_Method]
drop table if exists [Status_Order]
drop table if exists [Order]
drop table if exists [Order_Detail]
drop table if exists [Storage]

CREATE TABLE [dbo].[Role](
-- 0: admin, 1: staff
	roleID INT NOT NULL PRIMARY KEY, 
	[name] NVARCHAR(50) NOT NULL, 
);
GO

CREATE TABLE [dbo].Account(
	username NVARCHAR(50) NOT NULL PRIMARY KEY, 
	[password] NVARCHAR(50) NOT NULL, 
	roleID INT NOT NULL,
	[status] INT NOT NULL, -- 0: unactive, 1: active
);
GO

ALTER TABLE Account 
ADD CONSTRAINT FK_ROLEID_ACCOUNT FOREIGN KEY (roleID) REFERENCES Role(RoleID)

CREATE TABLE [dbo].Staff(
	staffID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	[fullname] NVARCHAR(50) NOT NULL, 
	dateJoin DATE NOT NULL,
	[address] NVARCHAR(100),
	phoneNumber VARCHAR(10),
	dateOfBirth DATE,
	taxCode CHAR,
	salary float,
	username NVARCHAR(50) UNIQUE,
);
GO

ALTER TABLE Staff 
ADD CONSTRAINT FK_USERNAME_STAFF FOREIGN KEY (username) REFERENCES Account(username)

CREATE TABLE [dbo].Category_Product(
	categoryID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] NVARCHAR(50) NOT NULL,
);
GO

CREATE TABLE [dbo].Product(
	productID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[productName] NVARCHAR(50) NOT NULL, 
	[description] NVARCHAR(100),
	price float,
	[image] NVARCHAR(100),
	status INT,  -- 0 Inactive, 1 Active
	categoryID INT,
);
GO

ALTER TABLE Product 
ADD CONSTRAINT FK_CATEGORYID_PRODUCT FOREIGN KEY (categoryID) REFERENCES Category_Product(categoryID)

CREATE TABLE [dbo].Ingredient(
	ingredientID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] NVARCHAR(50) NOT NULL, 
	unit NVARCHAR(10),
	[status] int NOT NULL,
);
GO

CREATE TABLE [dbo].Ingredient_Product(
	productID INT NOT NULL,
	ingredientID INT NOT NULL,
	mass int NOT NULL, 
	PRIMARY KEY(productID, ingredientID)
);
GO

ALTER TABLE Ingredient_Product 
ADD CONSTRAINT FK_PRODUCT_ID_INGREDIENT_PRODUCT FOREIGN KEY (productID) REFERENCES Product(productID)
ALTER TABLE Ingredient_Product 
ADD CONSTRAINT FK_INGREDIENT_ID_INGREDIENT_PRODUCT FOREIGN KEY (ingredientID) REFERENCES Ingredient(ingredientID)

CREATE TABLE [dbo].[Customer](
	phoneNumber NVARCHAR(10) NOT NULL PRIMARY KEY,
	[name] NVARCHAR(50) NOT NULL,
	email NVARCHAR(50),
	address CHAR
);
GO

CREATE TABLE [dbo].Payment_Method(
	paymentMethodID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] NVARCHAR(50) NOT NULL,
);
GO

CREATE TABLE [dbo].Status_Order(
-- 1: Paid, 2: Finish, 0: waiting, 3: cancel
	statusOrderID INT NOT NULL PRIMARY KEY,
	[name] NVARCHAR(50) NOT NULL,
);
GO

CREATE TABLE [dbo].[Order](
	orderID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	dateOrder DATE,
	amount FLOAT,
	staffID INT NOT NULL,
	phoneNumber NVARCHAR(10) NOT NULL,
	paymentMethodID INT NOT NULL,
	statusOrderID INT NOT NULL
);
GO

ALTER TABLE [Order]
ADD CONSTRAINT FK_STAFFID_ORDERR FOREIGN KEY (staffID) REFERENCES Staff(staffID)
ALTER TABLE [Order] 
ADD CONSTRAINT FK_PHONENUMBER_ORDER FOREIGN KEY (phoneNumber) REFERENCES Customer(phoneNumber)
ALTER TABLE [Order] 
ADD CONSTRAINT FK_PAYMENT_METHOD_ID_ORDERR FOREIGN KEY (paymentMethodID) REFERENCES Payment_Method(paymentMethodID)
ALTER TABLE [Order] 
ADD CONSTRAINT FK_STATUS_ORDER_ID_ORDERR FOREIGN KEY (statusOrderID) REFERENCES Status_Order(statusOrderID)

CREATE TABLE [dbo].Order_Detail(
	orderID INT NOT NULL,
	productID INT NOT NULL,
	quantity INT NOT NULL,
	totalPrice float NOT NULL,
	PRIMARY KEY(orderID,productID)
);
GO
ALTER TABLE Order_Detail 
ADD CONSTRAINT FK_ORDER_ID_ORDER_DETAIL FOREIGN KEY (orderID) REFERENCES [Order](orderID)
ALTER TABLE Order_Detail 
ADD CONSTRAINT FK_PRODUCT_ID_ORDER_DETAIL FOREIGN KEY (productID) REFERENCES Product(productID)

CREATE TABLE [dbo].Storage(
	storageID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ingredientID INT NOT NULL,
	quantity INT NOT NULL,
);
GO

ALTER TABLE Storage 
ADD CONSTRAINT FK_INGREDIENT_ID_STORAGE FOREIGN KEY (ingredientID) REFERENCES Ingredient(ingredientID)
