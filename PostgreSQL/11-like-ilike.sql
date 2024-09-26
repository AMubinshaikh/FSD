--LIKE & ILIKE LIKE is an case sensitive where ILIKE is not

SELECT * FROM person WHERE email LIKE '%@bloomberg.com';

SELECT * FROM person WHERE email ILIKE '%@BLOOMBERG.com';

