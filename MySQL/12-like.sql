-- MySQL LIKE Statements

-- return all records which first name starts with c
SELECT *
FROM Customers
WHERE first_name LIKE 'c%';

-- return all records which first name ends with a
SELECT *
FROM Customers
WHERE first_name LIKE '%a';

-- return all records which start with some text
SELECT *
FROM Customers
WHERE first_name LIKE 'Bab%';

-- return whos first name contain a in a middle
SELECT *
FROM Customers
WHERE first_name LIKE '%a%';

-- return whos last name contain only six characters and ends with y
SELECT *
FROM Customers
WHERE last_name LIKE '_____y';
