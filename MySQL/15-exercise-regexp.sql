-- Exercise

-- first names are elka or ambur
SELECT * 
FROM Customers
WHERE first_name REGEXP 'ELKA|AMBUR';

-- last name ends with EY or ON

SELECT *
FROM Customers
WHERE last_name REGEXP 'EY$|ON$';

-- last name starts with MY and contains SE
SELECT *
FROM Customers
WHERE last_name REGEXP '^MY|SE';

-- last_name contains B followed by U OR R
SELECT *
FROM Customers
WHERE last_name REGEXP 'B[RU]';