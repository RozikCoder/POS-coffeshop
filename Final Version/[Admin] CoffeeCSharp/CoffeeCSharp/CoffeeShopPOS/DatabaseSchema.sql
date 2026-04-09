-- ========================================
-- Coffee Shop POS Database Schema
-- ========================================

-- Create Database
CREATE DATABASE CoffeeShopPOS;
GO

USE CoffeeShopPOS;
GO

-- ========================================
-- Table: Inventory (Stock Management)
-- ========================================
CREATE TABLE Inventory (
    ItemID INT PRIMARY KEY IDENTITY(1,1),
    ItemName NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50) NOT NULL,
    Quantity INT NOT NULL DEFAULT 0,
    UnitPrice DECIMAL(10,2) NOT NULL,
    ReorderLevel INT NOT NULL DEFAULT 10,
    SupplierName NVARCHAR(100),
    LastUpdated DATETIME DEFAULT GETDATE()
);

-- ========================================
-- Table: Customers (Membership Management)
-- ========================================
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    MemberID NVARCHAR(20) UNIQUE NOT NULL,
    CustomerName NVARCHAR(100) NOT NULL,
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(100),
    MembershipType NVARCHAR(20) NOT NULL CHECK (MembershipType IN ('Bronze', 'Silver', 'Gold')),
    Points INT NOT NULL DEFAULT 0,
    JoinDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1
);

-- ========================================
-- Table: Sales (For Reporting & Analytics)
-- ========================================
CREATE TABLE Sales (
    SaleID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NULL,
    SaleDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(10,2) NOT NULL,
    PaymentMethod NVARCHAR(20),
    CashierName NVARCHAR(100),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- ========================================
-- Table: SaleItems (Transaction Details)
-- ========================================
CREATE TABLE SaleItems (
    SaleItemID INT PRIMARY KEY IDENTITY(1,1),
    SaleID INT NOT NULL,
    ItemID INT NOT NULL,
    ItemName NVARCHAR(100) NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (SaleID) REFERENCES Sales(SaleID),
    FOREIGN KEY (ItemID) REFERENCES Inventory(ItemID)
);

-- ========================================
-- Table: AppSettings (Configuration)
-- ========================================
CREATE TABLE AppSettings (
    SettingID INT PRIMARY KEY IDENTITY(1,1),
    SettingKey NVARCHAR(50) UNIQUE NOT NULL,
    SettingValue NVARCHAR(255) NOT NULL,
    LastUpdated DATETIME DEFAULT GETDATE()
);

-- ========================================
-- Insert Sample Data - Inventory
-- ========================================
INSERT INTO Inventory (ItemName, Category, Quantity, UnitPrice, ReorderLevel, SupplierName)
VALUES 
('Espresso', 'Coffee', 100, 2.50, 20, 'Coffee Beans Co.'),
('Latte', 'Coffee', 80, 3.50, 15, 'Coffee Beans Co.'),
('Cappuccino', 'Coffee', 90, 3.00, 15, 'Coffee Beans Co.'),
('Americano', 'Coffee', 70, 2.00, 10, 'Coffee Beans Co.'),
('Croissant', 'Pastry', 50, 1.50, 10, 'Bakery Supplier'),
('Muffin', 'Pastry', 40, 2.00, 10, 'Bakery Supplier'),
('Sandwich', 'Food', 30, 4.50, 8, 'Deli Supplier'),
('Cookie', 'Dessert', 60, 1.00, 15, 'Bakery Supplier');

-- ========================================
-- Insert Sample Data - Customers
-- ========================================
INSERT INTO Customers (MemberID, CustomerName, PhoneNumber, Email, MembershipType, Points)
VALUES 
('M001', 'John Smith', '012345678', 'john@email.com', 'Gold', 150),
('M002', 'Sarah Johnson', '012345679', 'sarah@email.com', 'Silver', 80),
('M003', 'Mike Brown', '012345680', 'mike@email.com', 'Bronze', 30),
('M004', 'Emily Davis', '012345681', 'emily@email.com', 'Gold', 200),
('M005', 'David Wilson', '012345682', 'david@email.com', 'Bronze', 15);

-- ========================================
-- Insert Sample Data - Sales
-- ========================================
INSERT INTO Sales (CustomerID, SaleDate, TotalAmount, PaymentMethod, CashierName)
VALUES 
(1, GETDATE()-30, 25.50, 'Cash', 'Cashier1'),
(2, GETDATE()-25, 15.00, 'Card', 'Cashier1'),
(3, GETDATE()-20, 8.50, 'Cash', 'Cashier2'),
(1, GETDATE()-15, 32.00, 'Card', 'Cashier1'),
(4, GETDATE()-10, 45.50, 'Cash', 'Cashier2'),
(2, GETDATE()-5, 18.00, 'Card', 'Cashier1'),
(5, GETDATE()-2, 12.50, 'Cash', 'Cashier2'),
(1, GETDATE()-1, 28.00, 'Card', 'Cashier1');

-- ========================================
-- Insert Sample Data - SaleItems
-- ========================================
INSERT INTO SaleItems (SaleID, ItemID, ItemName, Quantity, UnitPrice, Subtotal)
VALUES 
(1, 1, 'Espresso', 2, 2.50, 5.00),
(1, 5, 'Croissant', 3, 1.50, 4.50),
(2, 2, 'Latte', 2, 3.50, 7.00),
(3, 4, 'Americano', 1, 2.00, 2.00),
(4, 3, 'Cappuccino', 3, 3.00, 9.00),
(5, 7, 'Sandwich', 5, 4.50, 22.50),
(6, 2, 'Latte', 2, 3.50, 7.00),
(7, 8, 'Cookie', 8, 1.00, 8.00),
(8, 1, 'Espresso', 4, 2.50, 10.00);

-- ========================================
-- Insert Default Settings
-- ========================================
INSERT INTO AppSettings (SettingKey, SettingValue)
VALUES 
('Theme', 'Light'),
('ShopName', 'Coffee Shop POS'),
('TaxRate', '10'),
('Currency', 'USD'),
('ReceiptFooter', 'Thank you for your visit!');

GO
