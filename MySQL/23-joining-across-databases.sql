-- JOINING across Databases
-- in this example we are going to join two database(sql_inventory, sql_store) tables 
-- both tables contains same product_id field

SELECT * 
FROM order_items o
JOIN
sql_inventory.products p ON -- before second table name ust prefix onother database name
o.product_id = p.product_id;