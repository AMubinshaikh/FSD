-- Get all the customers whose 
-- addresses contains TRAIL or VANUE
-- phone number ends with 9


SELECT * 
FROM Customers 
WHERE address LIKE '%TRAIL%' OR
    address LIKE '%AVENUE' OR 
    phone LIKE '%9';
    
SELECT * 
FROM Customers 
WHERE phone LIKE '%9'
    

