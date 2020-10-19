-- SELECT STATEMENTS ALIAS

----SQL aliases are used to give a table, or a column in a table, 
--   a temporary name.

---Aliases are often used to make column names more readable.

---An alias only exists for the duration of the query.

SELECT [name] AS [Customer Name], 
age AS [Customer Age], 
pin AS [Pin Code]
FROM Customers WHERE age>30 OR gender='Male';

-- we can apply Alias on Table also 

CREATE VIEW viewOrdersDetails
AS 
SELECT number, [date], b.customer_id
FROM Orders AS a , Customers AS b
WHERE a.customer_id=b.customer_id;
