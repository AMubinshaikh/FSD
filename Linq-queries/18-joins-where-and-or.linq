

from c in Customers
join o in Orders
on c.CustomerId equals o.CustomerId
where c.Points> 3000 && c.FirstName == "Elka" || o.Status == 1 
select new
{
c.FirstName,
c.LastName,
c.State,
c.City,
o.OrderDate,
o.Status,
o.Comments,
o.ShipperId,
o.ShippedDate
}