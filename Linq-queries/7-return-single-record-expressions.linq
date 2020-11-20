
// Get single record using where

from c in Customers
where c.Points>2000
select c.FirstName

from p in Products
where p.QuantityInStock>10
select p.Name

from o in OrderItems
where o.UnitPrice>1
select o.Quantity

