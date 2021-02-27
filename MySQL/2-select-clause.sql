USE sql_store;

SELECT 
       last_name,
       first_name,
       points, 
       (points + 10) * 100 AS 'Discount factor' -- using single qoute for adding space between name
FROM Customers;

SELECT State
FROM Customers;

-- remove duplicate using DISTINCT constraint
SELECT DISTINCT State 
FROM Customers;