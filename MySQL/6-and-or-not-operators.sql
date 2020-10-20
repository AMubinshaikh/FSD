-- AND OR & NOT operators

-- AND OPERATOR
SELECT * 
FROM Customers
WHERE birth_date > '1990-01-01' AND points > 1000; 

-- OR OPERATOR
SELECT * 
FROM Customers
WHERE birth_date > '1990-01-01' OR 
(points > 1000 AND state = 'VA');

-- NOT

SELECT * 
FROM Customers
WHERE NOT birth_date > '1990-01-01' OR 
(points > 1000 AND state = 'VA');