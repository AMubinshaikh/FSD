--SQL Triggers are automatically fired when
--action performed in below example trigger fired when we delete
--any record from Table Customers
CREATE TRIGGER tr_Customer_forDelete
ON Customers
AFTER DELETE
AS
BEGIN
SELECT [name], [address] FROM DELETED
END


delete from Customers where customer_id=1;
delete from Customers where customer_id=2;
delete from Customers where customer_id=3;
delete from Customers where customer_id=4;


---------------------------------------------------------
--action performed in below example trigger fired when we 
--inserted
--any record in Table Customers
CREATE TRIGGER tr_Customer_forInsert
ON Customers
AFTER INSERT
AS
BEGIN
SELECT [address] , pin, [name] FROM INSERTED WHERE pin>500050;
END

insert into Customers values
(7,'Nani',23,'Female', 'Dahisar',400055);

insert into Customers values
(8,'Miller',56,'Male', 'Parle',400034);

insert into Customers values
(9,'job',43,'Male', 'Pune',400052);
