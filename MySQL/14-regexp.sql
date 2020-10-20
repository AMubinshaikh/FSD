-- REGEXP is stands Regular Expression
-- it works as same as LIKE statements but slightly different in syntax

-- ^ beginning
-- $ end
-- | multiple search pattern (logical OR)
-- [abc] e any of them match(single)
-- [a-j] e we can also write(Range)


SELECT * 
FROM Customers 
WHERE last_name LIKE '%field%';

-- search all record from table Customer Where given string find
SELECT * 
FROM Customers 
WHERE last_name REGEXP 'field';

-- using ^ cap sign starting with m
SELECT * 
FROM Customers 
WHERE last_name REGEXP '^m';

-- ending of the record in field searched
SELECT * 
FROM Customers 
WHERE last_name REGEXP 'field$';

-- we can search multiple results
SELECT * 
FROM Customers 
WHERE last_name REGEXP 'field|mac|rose';



