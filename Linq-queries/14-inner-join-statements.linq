

  var q =(from o in Orders

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
		
		}).ToList();
		
		q.Dump();
		
		
		from c in Customers
		join o in Orders
		on c.CustomerId equals o.CustomerId
		where c.CustomerId == 2
		select new
		{
		c,o
		}
		
		
		
		
		
		
		(from c in Customers
		select c.City).Distinct()