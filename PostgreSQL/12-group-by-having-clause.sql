-- Group By and Having clause

SELECT country COUNT(*) FROM person GROUP BY country ORDER BY country;

SELECT country, COUNT(*) FROM person GROUP BY country HAVING COUNT(*) > 5  ORDER BY COUNTRY;

SELECT email, COUNT(*) FROM person GROUP BY email;

SELECT email, COUNT(*) FROM person GROUP BY email HAVING COUNT(*) > 1;