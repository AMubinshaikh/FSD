-- Procedures
-- Basically section of code, so we can reuse queries again and again. If we want to save collection of queries 
-- we will create procedures.

-- creating two tables
CREATE TABLE table1 (amount int);
CREATE TABLE table2 (amount int);

-- create peocedures with parameters

CREATE PROCEDURE insert_values(value1 int, value2 int)
LANGUAGE SQL 
AS $$
INSERT INTO table1 VALUES(value1);
INSERT INTO table2 VALUES(value2);
$$;

-- Calling procedures with passing parameters
CALL insert_values(10,20);

SELECT * FROM table1;
SELECT * FROM table2;