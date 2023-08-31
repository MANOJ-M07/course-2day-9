create database Assignment9Db

use Assignment9Db

create table Customers
(CustomerId int primary key,
FirstName nvarchar(50),
LastName nvarchar(50)
)

create table Orders
(OrderId int primary key identity,
CustomerId int foreign key references Customers,
OrderDate datetime,
TotalAmount decimal)

insert into Customers values (13,'Aishu','Dv'),
(14,'Saran','Kumar'),
(15,'kavi','priya')
select * from Customers
insert into Orders values (13,'12/12/2023',2581.22),
(14,'05/06/2022',350.25),
(15,'06/04/2019',5000.00)
select * from Orders

alter table Customers
add TotalSpending decimal;

Create Procedure PlaceOrder
@id int,
@total decimal(10,2)
As
Begin
Insert Into Orders(CustomerId,OrderDate,TotalAmount)
Values (@id,GetDate(),@total);
Update Customers Set TotalSpending=isnull(TotalSpending,0)+@total
where CustomerId=@id;
end;

exec PlaceOrder @id = 15,@total = 150.00;