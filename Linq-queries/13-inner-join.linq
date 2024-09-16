
// Inner Join

from o in Orders

        join c in Customers  

        on o.CustomerId equals c.CustomerId
        where c.Points >3000
        select new
		{
		c.FirstName,
		c.Phone,
		c.City,
		o.OrderDate,
		o.ShippedDate
		
		}