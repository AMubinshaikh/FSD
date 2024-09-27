--FULL OUTER JOIN
--In this type of join two or more table merge and 
--both table display whole tables data even right one or left one
--does not match or null values are displayed
--in this example all data is displayed from right table even if not matched

SELECT a.[Name],a.ProductNumber, b.[Name]
AS 
ProductSubCategoryName 
FROM 
Production.ProductSubcategory b
FULL OUTER JOIN
Production.Product a
ON 
a.ProductSubcategoryID = b.ProductSubcategoryID;