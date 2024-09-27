-- SQL BUILT IN FUNCTIONS
  

-- AGGREGATE FUNCTIONS 

-- COUNT 
SELECT COUNT(customer_id) from Customers GROUP BY customer_name;

-- SUM 
SELECT SUM([orders]) from Orders 

-- MAX 
SELECT MAX(total) from Orders

-- MIN 
SELECT MIN([product_cost]) from Products

-- AVG 
SELECT AVG([order]) from 


--How	many	rows	are	in	the	Person.Person	table?
--Use	an	aggregate	function	NOT	 “SELECT *”.

SELECT COUNT(*) FROM Person.Person
--ans 19972

-------------------------------------------------------------------

--2) How	many	rows	in	the	Person.Person	table	do	not	have
--a	NULL	value	in	the	MiddleName	column?

SELECT COUNT(*) FROM Person.Person WHERE MiddleName IS NOT NULL

--OR

SELECT COUNT(MiddleName) FROM Person.Person

--ans 11473



------------------------------------------------------------------
--3) What	is	the	average	StandardCost	
--(located	in	Production.Product)	for	each	product	
--where	the	StandardCost	is	greater	than	$0.00?

SELECT AVG(StandardCost) FROM Production.Product WHERE StandardCost>$0.00;
ans= 428.7364

-------------------------------------------------------------------


--4) What	is	the	average	Freight	amount	for	each	sale	
--(found	in	Sales.SalesOrderHeader)	
--where	the	sale	took	place	in	TerritoryID	4?

SELECT AVG(Freight) FROM Sales.SalesOrderHeader Where TerritoryID = 4;
--ans= 113.4619

--------------------------------------

--5) How	expensive	is	the	most	expensive	product,	
--by	ListPrice,	in	the	table	
--Production.Product?

SELECT MAX(ListPrice) FROM Production.product
--ans=3578

-----------------------------------------------------------------
--6) Join	the	Production.Product	table	and	the	
--Production.ProductInventory	table	for	
--only	the	products	that	appear	in	
--both	table.		Use	the	ProductID	as	the	joining	
--column.		Production.ProductInventory	contains	the	quantity
--of	each	product	
--(several	rows	can	appear	for	each	product	to	indicate	
--the	product	appears	in	
--multiple	locations).		Your	goal	is	to	determine	how	much
--money	we	would	earn	if	
--we	sold	every	product	for	its	list	price for	each
--product	with	a	ListPrice	greater	than	
--$0.		That	is,	if	you	summed	the	product	of	each	
--product’s	inventory	by	its	list	price,	
--what	would	that	value	be?		
--(Hint:	This	is	intentionally	challenging.		
--You	must	use	an	
--aggregate	function	with	a	mathematical	expression	
--to	accomplish	your	goal)

SELECT SUM(a.ListPrice*b.Quantity) FROM 
Production.Product a INNER JOIN 
Production.ProductInventory b ON  a.ProductID = b.ProductID
 WHERE ListPrice>$0.00
