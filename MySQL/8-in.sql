-- IN statements are use to filter data from table and it compressed sql statements

-- if we search State wise customers using or operator

SELECT * 
FROM Customers
WHERE state='VA' OR state='GA'OR state = 'FL';

SELECT * 
FROM Customers WHERE state IN('VA','GA', 'FL');


-- NOT IN
SELECT * 
FROM Customers WHERE state NOT IN('VA','GA', 'FL');