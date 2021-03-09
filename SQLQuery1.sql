Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers
-- **********************
Select * from Customers where City = 'London'
-- **********************
Select * from Products where CategoryID = 1 or CategoryID = 3
-- **********************
Select * from Products where CategoryID = 1 and UnitPrice >= 10
-- **********************
select * from Products where CategoryID = 1 order by UnitPrice desc       --ascending --descending
-- **********************
select count(*) from Products where CategoryID = 2
-- ***********************
-- birim fiyatı 20 den büyük olanları categoryId ye göre grupla ve her grupta sayısı 10 dan az olanları göster
select CategoryID,count(*) from Products where UnitPrice > 20  group by CategoryID having count(*) < 10
-- ***********************
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10
--DTO  Data Transformation Object
-- inner join iki tablodada eşleşiyorsa verileri getirir
-- left join solda olup sağda olmayanları da getirir
select * from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o 
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null