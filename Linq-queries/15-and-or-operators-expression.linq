

from c in Customers 
where c.Points > 2000 && c.Points<3000 || c.CustomerId==4
select new 
{
c.CustomerId,
c.FirstName,
c.Points
}

//////////////////////////////////////////////////////

from p in Products
 where p.ProductId == 1 || p.QuantityInStock<20 && p.UnitPrice>5
 
 select new
 {
 p.ProductId,
 p.Name,
 p.QuantityInStock,
 p.UnitPrice
 }
 
 //////////////////////////////////////////////////
 
 from o in Orders 
 where o.Status==2 || o.ShipperId !=null
 select new
 {
 o.OrderId,
 o.Status,
 o.ShipperId
 }
 

