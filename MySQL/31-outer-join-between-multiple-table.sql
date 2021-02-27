	-- OUTER JOIN BETWEEN MULTIPLE TABLES

		SELECT c.customer_id,
			   c.first_name,
			   o.order_id,
			   o.order_date,s.name AS Shipper
		FROM customers c 
		LEFT OUTER JOIN orders o
		   ON c.customer_id = o.customer_id
	   LEFT OUTER JOIN shippers s 
		   ON o.shipper_id = s.shipper_id
		ORDER BY c.customer_id;
        
       