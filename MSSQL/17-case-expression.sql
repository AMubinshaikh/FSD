-- CASE Expression
-- CASE is just like if else/ switch case in any programming language. 
--we can apply many case expression in single block
SELECT [name], [address] ,
CASE
WHEN pin > 400051  THEN 'Mumbai Suburban'
ELSE 'South Mumbai'
END AS [Location] FROM Customers;

