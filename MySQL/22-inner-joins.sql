-- INNER JOINS are used to joins two or more table but both table should contains same field ie PRIMARY FOREIGN KEY relation

SELECT order_id, first_name,last_name, a.customer_id
FROM Orders 
INNER JOIN customers a 
     ON orders.customer_id = a.customer_id;
-- -----------------------------------------------------------

-- Exercise
SELECT order_id,o.product_id,o.unit_price,quantity
FROM Order_items o
JOIN Products p 
  ON o.product_id = p.product_id;

