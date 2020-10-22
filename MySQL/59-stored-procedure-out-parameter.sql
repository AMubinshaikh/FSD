-- STORED PROCEDURES WITH OUT PARAMETERS

DELIMITER //
CREATE PROCEDURE sp_GetCustomerCount(OUT countCustomer INT)
BEGIN
SELECT COUNT(*) INTO countCustomer FROM customers;
END //
DELIMITER ;

CALL sp_GetCustomerCount(@count);
SELECT @count AS 'Total Number of Customers';

-- ------------------------------------------------------------------------------------

-- highest points in customers table using max()

DELIMITER //
CREATE PROCEDURE sp_GetCustomerHighestPoints(OUT highPoint INT)
BEGIN
SELECT MAX(points) INTO highPoint FROM customers;
END //
DELIMITER ;

CALL sp_GetCustomerHighestPoints(@highPoint);
SELECT @highPoint AS 'Highest Points of Customers';
