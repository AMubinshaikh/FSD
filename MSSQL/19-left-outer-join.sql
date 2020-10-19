--LEFT	OUTER JOIN
--In this type of join two or more table merge and 
--left one display whole table data even right one 
--does not match or null values are displayed

--and	Practice Problem
--1) Return	the	BusinessEntityID and SalesYTD
--column from Sales.SalesPerson. Join this	
--table	to	the	Sales.SalesTerritory table	in	
--such	a	way	that every	in	Sales.SalesPerson	
--will	be	returned regardless	of	whether	or	
--not they	are	assigned to	a	territory. Also,	
--return	the	Name column	from Sales.SalesTerritory.	Give this	
--column the column	alias “Territory Name”

SELECT a.BusinessEntityID, a.SalesYTD, 
b.[Name] AS [Territory Name]
FROM
Sales.SalesPerson a 
LEFT OUTER JOIN Sales.SalesTerritory b 
ON
a.TerritoryID = b.TerritoryID;

