DELIMITER //
CREATE PROCEDURE spGetAll()
BEGIN
SELECT * FROM customers;
END //
DELIMITER ;

CALL spGetAll()

-- -------------------------------------------------------------------------------------

DELIMITER //
CREATE PROCEDURE spPrimeCustomerInfo()
BEGIN
SELECT customer_id AS 'Customer Code',
	   first_name AS 'Customer Name',
       address,
       city
       FROM Customers 
       WHERE points>2000;

END //
DELIMITER ;

CALL spPrimeCustomerInfo();

-- ---------------------------------------------------------------------------------

-- STORED PROCEDURES WITH JOINS

DELIMITER //
CREATE PROCEDURE sp_CustomerOrder()
BEGIN
SELECT c.first_name,
       c.last_name,
       o.order_date
FROM customers c
INNER JOIN orders o
ON c.customer_id = o.customer_id;       
END //
DELIMITER ;

CALL sp_CustomerOrder();

-- ----------------------------------------------------------------------------------
-- DROP PROCEDURES
DROP PROCEDURE spCustomersInfo;
