-- EXERCISE

-- get 3 loyal customers based on highest points
SELECT * 
FROM Customers
ORDER BY points DESC
LIMIT 3;