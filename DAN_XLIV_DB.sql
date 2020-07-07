CREATE DATABASE DAN_XLIV
 IF DB_ID('DAN_XLIV') IS NULL
CREATE DATABASE DAN_XLIV;
GO
USE DAN_XLIV;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblOrders')
drop table tblOrders;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblProducts')
drop table tblProducts ;


if exists (SELECT name FROM sys.sysobjects WHERE name = 'vwOrders')
drop view vwOrders;




Create table tblProducts(
ProductID int identity(1,1) Primary key, --Primary key
ProductName nvarchar(50) not null,
Price int not null,

);


Create table tblOrders(
 OrderID int IDENTITY(1,1) Primary key not null, --Primary key
 Quantity int not null,
 OrderDate date not null,
 OrderStatus varchar(50),
 Username varchar(13) NOT NULL,
 ProductID int,
);

  

ALTER TABLE tblOrders
ADD FOREIGN KEY (ProductID) REFERENCES tblProducts(ProductID);


GO

CREATE VIEW vwOrders
as
select o.OrderID, o.Quantity, o.OrderDate, o.Username, o.ProductID, o.Quantity * p.Price AS TotalPrice
from tblOrders o
inner join tblProducts p
on o.ProductID = p.ProductID;

GO

INSERT INTO tblProducts(ProductName, Price)
VALUES 
('Pizza1', 500),
('Pizza2', 600),
('Pizza3', 550),
('Pizza4', 700),
('CocaCola', 100),
('Beer', 150);
