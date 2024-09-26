--COALESCE statement provide string where empty

SELECT COALESCE(email, 'Email not provided') FROM person;