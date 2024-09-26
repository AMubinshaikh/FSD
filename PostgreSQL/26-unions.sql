-- UNIONS : Combinig result sets of multiple queries

SELECT DISTINCT(country)
FROM person, car
WHERE make='Honda' AND price>500000 OR price <1000000
UNION
(
SELECT DISTINCT(make) 
FROM person
WHERE email='jakejones@gmail.com' OR first_name='Jake' AND last_name='Jones';
);