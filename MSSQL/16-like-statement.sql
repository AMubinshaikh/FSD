-- SQL Like statements is use to search string with specific char expression
-- search Customers in column name with last character is s

SELECT * FROM Customers WHERE [name] LIKE '%s';

-- search Customers in column name with First character is j

SELECT * FROM Customers WHERE [name] LIKE 'j%';

-- search Customers in column name with middle character is m

SELECT * FROM Customers WHERE [name] LIKE '%m%';

-- search Customers in column name with middle characters is om

SELECT * FROM Customers WHERE [name] LIKE '%om%';

-- search Customers in column name with after 2 characters is 

SELECT * FROM Customers WHERE [name] LIKE '__mes';

-- search Customers in column name with starts with j and ends with s 

SELECT * FROM Customers WHERE [name] LIKE 'j%s';

-- search Customers in column name NOT LIKE with after 2 characters is 

SELECT * FROM Customers WHERE [name] NOT LIKE '__mes';

-- search Customers in column name NOT LIKE with after 2 characters is 

SELECT * FROM Customers WHERE [name] NOT LIKE 'a%';

--all results which is available Customers name colums either s, j , m;
SELECT * FROM Customers WHERE [name] LIKE '[!sjm]%';

--all results which is available Customers name colums NOT LIKE either s, j , m;
SELECT * FROM Customers WHERE [name] NOT LIKE '[!sjm]%';

