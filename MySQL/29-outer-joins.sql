-- OUTER JOINS --OUTER keyword is optional


-- INNER JOI
SELECT  c.customer_id,
        c.first_name,
        o.order_id
FROM Customers c
JOIN Orders o 
ON c.customer_id = o.customer_id;

-- LEFT OUTER JOIN ( all the records in the left table are returned)

SELECT  c.customer_id,
        c.first_name,
        o.order_id
FROM Customers c
LEFT JOIN Orders o 
ON c.customer_id = o.customer_id;

-- RIGHT OUTER JOIN ( all the records in the right table are returned)

SELECT c.customer_id,
       c.first_name,
       o.order_id
FROM Orders o
RIGHT JOIN Customers c
ON c.customer_id = o.customer_id;