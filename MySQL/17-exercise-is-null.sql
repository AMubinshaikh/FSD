-- EXERCISE

-- Get all orders that are not shipped

SELECT * 
FROM Orders
Where  shipped_date IS NULL;
-- OR
SELECT * 
FROM Orders
Where  shipper_id IS NULL;