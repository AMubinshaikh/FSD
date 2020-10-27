
// Multiple records expressions

from c in Customers
where c.Points>2000
select new
{
c.FirstName,
c.LastName,
c.City,
c.BirthDate,
c.Phone,
c.Points
}


from p in Products
where p.QuantityInStock>=50
select new
{
p.ProductId,
p.Name,
p.QuantityInStock,
p.UnitPrice
}


from o in OrderItems
where o.UnitPrice>5
select new
{
o.OrderId,
o.ProductId,
o.Quantity,
o.UnitPrice
}






