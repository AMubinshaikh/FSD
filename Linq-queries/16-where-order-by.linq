

from c in Customers
where c.FirstName == "Elka"
orderby c.Points descending
select new
{
c.FirstName,
c.LastName,
c.Points
}

