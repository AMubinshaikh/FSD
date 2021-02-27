-- UNIONS are used to combine multiple row set
-- combine results from multiple queries

SELECT 
 order_id,
 order_date,
 'ACTIVE' AS Status
FROM orders
WHERE order_date >= '2019-01-01'
UNION
SELECT 
 order_id,
 order_date,
 'ARCHIVED' AS Status
FROM orders
WHERE order_date <= '2019-01-01';

-- ------------------------------------------------------------------------------
SELECT first_name FROM customers
UNION
SELECT name FROM shippers;

