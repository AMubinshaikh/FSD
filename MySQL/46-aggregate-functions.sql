SELECT COUNT(*) FROM city;
SELECT Count(distinct(Name)) FROM city;
SELECT max(Population) from city;
SELECT Name ,max(Population) from city;
SELECT  min(Population) from city;
SELECT COUNT(*) FROM city WHERE Name='kabul';
SELECT Name FROM city WHERE Population='10500000';
SELECT Name FROM city WHERE Population='42';