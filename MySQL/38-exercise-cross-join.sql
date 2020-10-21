-- DO A CROSS JOIN BETWEEN SUPLIER AND PRODUCTS
-- USING THE IMPLICIT SYNTAX
-- AND THEN USING THE EXPLICIT SYNTAX
-- implicit 
SELECT 
   s.name AS shippers,
   p.name AS products
   FROM Shippers s, products p
   ORDER BY s.name;
   
   -- explicit
   
   SELECT 
   s.name AS shippers,
   p.name AS products
   FROM Shippers s 
   CROSS JOIN products p
   ORDER BY s.name;