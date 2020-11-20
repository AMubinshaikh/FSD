--EXTRACTING DATA
------------------------------------------------------------------------------------------------
SELECT EXTRACT(YEAR FROM NOW());
SELECT EXTRACT(MONTH FROM NOW());
-- we can calculate age, number of years like joining date and current date
SELECT first_name,last_name, date_of_birth, AGE (NOW(), date_of_birth) AS AGE FROM person;