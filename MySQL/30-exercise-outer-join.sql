-- EXERCISE

SELECT p.product_id, p.name, o.quantity 
FROM  products p 
LEFT OUTER JOIN order_items o
 ON p.product_id = o.product_id;
 