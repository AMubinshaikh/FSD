-- LIMIT CLAUSE

--  we can display record as we want

SELECT * 
FROM Customers
LIMIT 3; 

-- if we want record from 7-9 then we know we have to discard or skip 6 recored so first value is 6 and 3 records we want so 3
SELECT * 
FROM Customers
LIMIT 6,3;

