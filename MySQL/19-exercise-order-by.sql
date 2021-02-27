-- Exercise

SELECT * , quantity * unit_price AS 'TOTAL PRICE'
FROM order_items
WHERE order_id = 2
ORDER BY quantity * unit_price DESC;