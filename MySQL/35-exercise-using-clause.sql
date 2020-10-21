-- EXERCISE USING CLAUSE

SELECT 
     p.date,
     c.name AS 'client Name',
     p.amount,
     pm.name AS 'payment method'
FROM payments p 
JOIN clients c
USING (client_id)
JOIN payment_methods pm
ON p.payment_method = pm.payment_method_id