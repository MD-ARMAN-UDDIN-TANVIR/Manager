DROP TABLE IF EXISTS IngredientUsageLog;
DROP TABLE IF EXISTS Payments;
DROP TABLE IF EXISTS EWalletTransactions;
DROP TABLE IF EXISTS OrderItems;
DROP TABLE IF EXISTS Orders;
DROP TABLE IF EXISTS MenuIngredients;
DROP TABLE IF EXISTS MenuItems;
DROP TABLE IF EXISTS Ingredients;
DROP TABLE IF EXISTS Categories;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS Roles;

Create Table Roles(RoleID Int Identity(1,1) Primary Key,
RoleName Nvarchar(100) Not Null);
 Insert Into Roles (RoleName) Values ('Admin');
 Insert Into Roles (RoleName) values ('Manager');
 Insert Into Roles (RoleName) Values ('Chief');
 Insert into Roles (RoleName) Values ('Cashier');
 Insert INto Roles (RoleName) Values ('Customer');

Create Table Users(UserID Int Identity(1,1) Primary Key,
LoginID Nvarchar(50) Not NUll,
FullName Nvarchar(100) not null,
Password Nvarchar(100) Not Null,
Email Nvarchar(100) ,
Phone Nvarchar(20) ,
WalletBalance Decimal(10,2) Default 0.00,
RoleID Int Foreign Key References Roles(RoleID)
);

Insert Into Users (LoginID, FullName, Password, Email, Phone, RoleID)
Values ('Admin01', 'Basil', 'DingDong', 'basil@example.com', '1234567890', 1);
Insert Into Users (LoginID, FullName, Password, Email, Phone, RoleID)
Values ('Manager01', 'Arrman', 'BingBong', 'alice@example.com', '0987654321', 2);
Insert Into Users (LoginID, FullName, Password, Email, Phone, RoleID)
Values ('Chief01', 'CheZero', 'Singsong', 'charlie@example.com', '1122334455', 3);
Insert Into Users (LoginID, FullName, Password, Email, Phone, RoleID)
Values ('Cashier01', 'Purabi', 'Kingkong', 'david@example.com', '5566778899', 4);
Insert Into Users (LoginID, FullName, Password, Email, Phone, RoleID)
Values ('Customer01', 'Mahiat', 'Ringrong', 'eve@example.com', '9988776655', 5);


SELECT * FROM Users;

CREATE TABLE Categories(
CategoryID Int Identity(1,1) Primary Key,
CategoryName Nvarchar(100) Not Null Unique
);

CREATE TABLE Ingredients(
IngredientID Int Identity(1,1) Primary Key,
IngredientName Nvarchar(100) Not Null,
unit Nvarchar(50) Not Null,
QuantityInStock Decimal(10,2) Not Null Default 0	
);

CREATE TABLE MenuItems(
MenuItemID Int Identity(1,1) Primary Key,
ItemName Nvarchar(100) Not Null,
CategoryID Int Foreign Key References Categories(CategoryID),
Price Decimal(10,2) Not Null,
IsAvailable Bit Not Null Default 1
);

Insert into Categories (CategoryName)
Values ('BreakFast'),
       ('Lunch'),
       ('Desserts'),
       ('Dinner'),
       ('Drinks');

Insert Into Ingredients (IngredientName, unit, QuantityInStock)
Values ('Tomato', 'kg', 10.00),
       ('Onion', 'kg', 5.00),
       ('Garlic', 'g', 200.00),
       ('Chicken', 'kg', 8.00),
       ('Rice', 'kg', 15.00);
 
Insert Into MenuItems (ItemName, CategoryID, Price)
Values ('Omleet', (Select CategoryID From Categories Where CategoryName = 'BreakFast'), 8.50);
Insert into MenuItems (ItemName, categoryID, Price)
Values ('Nan Chees', (Select CategoryID From Categories Where CategoryName = 'Lunch'), 12.00);
Insert Into MenuItems (ItemName, CategoryID, Price)
Values ( 'Hot Chocolate', (Select CategoryID From Categories Where CategoryName = 'Drinks'), 7.70);

Create table MenuIngredients(MenuItemID Int Not null Foreign Key References MenuItems(MenuItemID), 
IngredientID Int Foreign Key References Ingredients(IngredientID),
QuantityRequired Decimal (10,2) Not Null Check (QuantityRequired  > 0),
Primary key ( MenuItemID, IngredientID)
);

Insert Into MenuIngredients (MenuItemID, IngredientID,QuantityRequired)
Values ((Select MenuItemID From MenuItems Where ItemName = 'Omleet'),
(Select IngredientID From Ingredients Where IngredientName = 'Tomato'), 0.50);

Insert Into MenuIngredients (MenuItemID, IngredientID, QuantityRequired)    
Values ((Select MenuItemID From MenuItems Where ItemName = 'Nan Chees'),
(Select IngredientID From Ingredients Where IngredientName = 'Onion'), 0.30);

insert into MenuIngredients (MenuItemID, IngredientID, QuantityRequired)
values ((select MenuItemID from MenuItems where ItemName = 'Hot Chocolate'),
(select IngredientID from Ingredients where IngredientName = 'Rice'), 0.20);

Create table Orders(OrderID Int identity(1,1) Primary Key,
CustomerID int not null Foreign Key References Users(UserID),
OrderDate DateTime Not Null Default GetDate(),
TotalAmount Decimal(10,2) Not Null Check (TotalAmount >= 0 ),
Status Nvarchar(20) Not NUll Default 'Pending'
    Check (Status IN('pending', 'In progres', 'Completed', 'Cancelled') )
    );
INSERT INTO Orders (CustomerID, OrderDate, TotalAmount, Status)
VALUES 
(5, '2026-10-20 12:30:00', 8.50, 'Completed'),
(5, '2026-10-22 14:15:00', 12.00, 'Completed'),
(5, '2026-10-24 09:00:00', 7.70, 'Completed');

CREATE TABLE OrderItems (
    OrderItemID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL FOREIGN KEY REFERENCES Orders(OrderID),
    MenuItemID INT NOT NULL FOREIGN KEY REFERENCES MenuItems(MenuItemID),
    Quantity INT NOT NULL CHECK (Quantity > 0),
    UnitPrice DECIMAL(10,2) NOT NULL
);

INSERT INTO OrderItems (OrderID, MenuItemID, Quantity, UnitPrice)
VALUES 
(1, (SELECT MenuItemID FROM MenuItems WHERE ItemName = 'Omleet'), 1, 8.50),
(2, (SELECT MenuItemID FROM MenuItems WHERE ItemName = 'Nan Chees'), 1, 12.00),
(3, (SELECT MenuItemID FROM MenuItems WHERE ItemName = 'Hot Chocolate'), 1, 7.70);

CREATE TABLE EWalletTransactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID),
    OrderID INT NULL FOREIGN KEY REFERENCES Orders(OrderID),
    TransactionType NVARCHAR(20) NOT NULL
        CHECK (TransactionType IN ('TopUp', 'Order', 'Refund')),
    Amount DECIMAL(10,2) NOT NULL CHECK (Amount > 0),
    TransactionDate DATETIME NOT NULL DEFAULT GETDATE()
);
INSERT INTO EWalletTransactions (UserID, OrderID, TransactionType, Amount, TransactionDate)
VALUES
(5, 1, 'Order', 8.50, GETDATE()),
(5, 2, 'Order', 12.00, GETDATE()),
(5, 3, 'Order', 7.70, GETDATE());   

 Create table Payments(PaymentsID Int Identity(1,1) Primary Key,
 OrderID int not null Foreign Key References Orders(OrderID),
 CashierID Int Not Null Foreign key References Users(UserID),
 AmountPaid Decimal(10,2) Not Null Check (AmountPaid > 0 ),
 PaymentDate DateTime Not Null Default GetDate()
  );

  Create Table IngredientUsagelog (LogID Int Identity(1,1) Primary Key,
  IngredientID Int Not Null Foreign  Key References Ingredients(IngredientID),
  OrderID Int Not null Foreign Key References Orders(OrderID),
  ChefID int Not NUll Foreign Key References Users(UserID),
  QuantityUsed Decimal(10,2) Not Null Check (QuantityUsed > 0),
  UsageDate DateTime Not Null Default GetDate()
   );

   SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_NAME;

    SELECT MenuItems.ItemName, Ingredients.IngredientName, MenuIngredients.QuantityRequired, Ingredients.Unit
    FROM MenuIngredients
    INNER JOIN MenuItems ON MenuIngredients.MenuItemID = MenuItems.MenuItemID
    INNER JOIN Ingredients ON MenuIngredients.IngredientID = Ingredients.IngredientID;