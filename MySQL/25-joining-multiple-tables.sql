-- JOINING MULTIPLE TABLES

  SELECT o.order_id,
         o.order_date,
         c.first_name,
         c.last_name,
         s.name AS Status
  FROM orders o 
  JOIN customers c
	ON o.customer_id = c.customer_id
  JOIN order_statuses s
     ON o.status = s.order_status_id