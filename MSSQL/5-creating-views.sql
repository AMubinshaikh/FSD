--Views in SQL
-- In SQL view is an virtual table but it look like real table 
-- with real rows and columns.
-- it is used to display required information from table 
-- we can select columns as we want and display them

CREATE VIEW viewCustomers
AS
SELECT [name], [address], pin FROM Customers WHERE pin=400051;

CREATE VIEW viewOrdersDetails
AS 
SELECT number, [date], Customers.customer_id
FROM Orders , Customers
WHERE Orders.customer_id=Customers.customer_id;

select * from viewordersDetails



