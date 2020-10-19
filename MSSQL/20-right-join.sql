--RIGHT OUTER JOIN is used to display Whole Right table and no matching feild required
--it return null if no match

SELECT 
a.[NAME] , a.ProductNumber, b.[Name] 
AS
ProductSubCategoryName
FROM
Production.ProductSubcategory b
RIGHT OUTER JOIN
Production.Product a
ON 
a.ProductSubcategoryID = b.ProductSubcategoryID

