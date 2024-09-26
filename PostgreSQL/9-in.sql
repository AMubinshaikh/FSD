-- Using IN 

test=# SELECT *
test-# FROM person
test-# WHERE country IN('Poland','China','France');

SELECT * FROM person WHERE country IN('Poland', 'China', 'Brazil') ORDER BY country;