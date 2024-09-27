--SQL DISTINCT STATEMENTS it returns UNIQUE value from table. 

-- We can apply DISTICT on Single Column
SELECT DISTINCT(pin) FROM Customers;

-- We can apply DISTICT on Multiple Column
SELECT DISTINCT(category,items) FROM Category; 


-- We can count different record from column
SELECT COUNT(DISTINCT [address]) FROM Customers;



