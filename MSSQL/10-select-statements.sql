-- Select Statement
--Display all records from Customers Table

SELECT * FROM Customers;

--we can display selected columns from table 
--with specific condition , if condition not satisfied then 
-- not display anything

SELECT [name], age, [address] 
FROM Customers WHERE pin=400051 AND age > 40 OR age < 50;