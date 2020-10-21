-- IMPLICIT JOIN SYNTAX
-- INNER JOIN
SELECT * 
FROM orders o 
JOIN customers c
ON o.customer_id = c.customer_id;

-- IMPLICIT JOIN
SELECT * 
FROM orders o, customers c 
WHERE o.customer_id = c.customer_id;