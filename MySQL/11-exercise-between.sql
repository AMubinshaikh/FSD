-- Return Customers born between 
-- 1/1/1990 to 1/1/2000

SELECT * 
FROM Customers
WHERE birth_date 
BETWEEN '1990-01-01' AND '2000-01-01' ;
