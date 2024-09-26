-- VIEWS is a virtual table which can be more than one table, we can display columns as we want.
-- View is a single table , which is derived from other table(s).

CREATE VIEW viewPersonDetails
AS SELECT first_name, last_name, country
FROM person 
WHERE gender='Male' AND date_of_birth > '1990-01-01';

SELECT * FROM viewPersonDetails;