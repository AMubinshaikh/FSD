-- CROSS JOINS
-- EVERY COLUMN JOINS WITH ANOTHER TABLE'S COLUMN

SELECT 
c.first_name AS Customer,   
p.name AS product
FROM customers c
CROSS JOIN products p                                                     
ORDER BY c.first_name 