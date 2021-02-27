-- STORED PROCEDURES WITH IN PARAMETER

DELIMITER //
CREATE PROCEDURE getCustomerDetailById(IN id INT)
BEGIN
SELECT * FROM customers WHERE customer_id = id;
END //
DELIMITER ;

CALL getCustomerDetailById(1);

-- ----------------------------------------------------------------------

DELIMITER //
CREATE PROCEDURE getCustomerDetailByName(IN name VARCHAR(50))
BEGIN
SELECT * FROM customers WHERE first_name = name;
END //
DELIMITER ;

CALL  getCustomerDetailByName('Elka');

-- ----------------------------------------------------------------------

DELIMITER //
CREATE PROCEDURE getCustomerDetailByNameAndState(name VARCHAR(50), states VARCHAR(50))
BEGIN
SELECT * FROM customers WHERE first_name = name AND state=states;
END //
DELIMITER ;

CALL  getCustomerDetailByNameAndState('Elka','IL');

-- ------------------------------------------------------------------------

-- STORED PROCEDURE USING IF, END IF

DELIMITER //
CREATE PROCEDURE sp_EvenOrOdd(number INT)
BEGIN

IF number%2=0 THEN
SELECT 'Even Number' AS Result ;
ELSE 
SELECT 'Odd Number' AS Result ;
END IF;
END //
DELIMITER ;

CALL sp_EvenOrOdd(6);