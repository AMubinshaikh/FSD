
-- Insert As Select Statements

INSERT INTO Department VALUES(1,'Shaikh','Mumbai', 'Maharashtra');


-- This statement insert(copy) all the 
--Department Table's field into Employee table

INSERT INTO Employee ([name], city, [state])
SELECT [name], city, [state] FROM Department;
