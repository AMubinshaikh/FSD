--IN and NOT IN Command in SQL

--IN command search in Table which 
--get all records which is  IN RECORDS
SELECT [name],age FROM Customers WHERE [address] 
IN('Bandra','Juhu','Santacruz');

--NOT IN command search in Table which 
--get all records which is we are NOT IN list
SELECT [name],age FROM Customers WHERE [address] 
NOT IN('Bandra','Juhu','Santacruz');

