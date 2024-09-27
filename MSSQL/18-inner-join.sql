-- JOINS IN SQL 
-- INNER JOIN
-- this is used to join two or more table and get data
--from tables But only related data will displayed.

--INNER	JOIN	Practice	Problems

--1) Using	the	Person.Person	and	Person.Password	tables,	
--INNER	JOIN	the	two	tables using the BusinessEntityID column and
--return	the	FirstName and	LastName columns	from Person.Person 
--and	then PasswordHash  column from Person.Password

SELECT a.FirstName, a.LastName , b.PasswordHash
FROM Person.Person a 
INNER JOIN 
Person.[Password] b 
ON 
a.BusinessEntityID = b.BusinessEntityID;


--------------------------------------------------------------


--2) Join	the	HumanResources.Employee	and	the	
--HumanResources.EmployeeDepartmentHistory	tables	
--together	via	an	INNER	JOIN	
--using	the	BusinessEntityID	column.		Return	the	
--BusinessEntityID,	NationalIDNumber	and	JobTitle	
--columns	from	HumanResources.Employee	and	the	DepartmentID,	
--StartDate,	and	EndDate	columns	from 
--HumanResources.EmployeeDepartmentHistory.		
--Notice	the	number	of	rows returned.		
--Why	is	the	row	count	what	it	is?

SELECT a.BusinessEntityID, a.NationalIDNumber, a.JobTitle, 
b.DepartmentID, b.StartDate, b.EndDate From HumanResources.Employee a
INNER JOIN 
HumanResources.EmployeeDepartmentHistory b
ON
a.BusinessEntityID = b.BusinessEntityID;

--------------------------------------------------------------

--3) Expand	upon	the	query	used	in	question	1.	
--Using	the	existing	query,	add	another	INNER	JOIN	to	
--the	Person.EmailAddress	table	and	include	the	EmailAddress
--column in	your	select	statement.

SELECT a.FirstName, a.LastName , b.PasswordHash, c.EmailAddress
FROM Person.Person a 
INNER JOIN 
Person.[Password] b 
ON 
a.BusinessEntityID = b.BusinessEntityID
INNER JOIN Person.EmailAddress c
ON
b.BusinessEntityID = c.BusinessEntityID;

-----------------------------------------------------------------


