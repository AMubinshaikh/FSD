-- NATURAL JOINS -- automatic join,  database engine sense and join two tables

SELECT 
o.order_id, c.first_name
FROM 
Customers c
NATURAL JOIN Orders o