DELIMITER //
CREATE PROCEDURE sp_GetSum(IN firstNumber INT, IN secondNumber INT , OUT Result INT)
BEGIN
SET Result = firstNumber + secondNumber;
END //
DELIMITER ;

CALL sp_GetSum(25,30,@Result);
SELECT @Result AS 'Sum Of Two Numbers';