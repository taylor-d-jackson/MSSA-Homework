use Northwind

--Potentially Ambiguous
select LastName from Employees

--Fully Qualified Column Name
select dbo.Employees.LastName from Employees;

--Fully Qualified table with Alias
select E.LastName from dbo.Employees as E;


--1. Find all of the regions
select * from Region;

select RegionDescription from Region;

--2. What are the cities?
select * from Territories;

select TerritoryDescription as Cities 
from Territories
order by Cities;

--3. Find all the cities in the southern region
select * from Region;
select * from Territories;

select TerritoryID, 
		TerritoryDescription,
		'Southern' as Region
	from Territories
	where RegionId = 4;


--4. How do you run this query with a fully qualified column name
select  dbo.Territories.TerritoryID, 
		dbo.Territories.TerritoryDescription,
		'Southern' as Region
	from Territories
	where RegionId = 4;

--5.
select  T.TerritoryID, 
		T.TerritoryDescription as CityName,
		'Southern' as Region
	from dbo.Territories as T
	where RegionId = 4;

--6.
select ContactName, Phone, City 
		from Customers;

--7. Find products out of stock
select *
	from Products
	where UnitsInStock = 0 and Discontinued = 0;

--8 Find the 10 least stocked products    asc = ascending; desc = descending, top = limits how many you want (x) where x = number
select top(10) *
	from Products
	where UnitsInStock != 0
	order by UnitsInStock asc;


--9 5 Most expensive products

select top(5) *
	from Products
	where UnitsInStock > 0
	order by UnitPrice desc;

--10. How many Products, Customers and suppliers does Northwind have?

select count(*) as SupplierCount
	from Suppliers

select count(*) as CusomerCount
	from Customers;

select count(*) as ProdutCount
	from Products;

	--Extra. Average cost of a product

	select * from Products;

	select count(*), sum(UnitPrice) from Products;

	select sum(UnitPrice) / count(*) as AveragePrice
		from Products;