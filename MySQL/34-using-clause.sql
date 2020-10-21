-- USING clause  
-- in place of on and type same feilds name tow times we can use using clause.

SELECT 
   o.order_id,
   c.first_name,
  s.name AS Shipper
FROM orders o 
JOIN customers c 
--  ON o.customer_id = c.customer_id   replaced by using clause
   USING(customer_id)
LEFT JOIN shippers s
   USING(shipper_id);
   
   -- USNG CLAUSE WITH MULTIPLE TABLES AND DIFFERENT FIELDS
   
   SELECT * 
   FROM order_items oi
   JOIN order_item_notes oin
  -- ON oi.order_id = oin.order_id
  -- AND oi.product_id = oin.product_id;
  USING(order_id, product_id)
  
   