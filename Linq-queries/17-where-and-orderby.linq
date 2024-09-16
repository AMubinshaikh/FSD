
void Main()
{
	var data = from c in Customers 
	orderby c.Points descending
	where c.Points>3000 || c.CustomerId==2 && c.Points<1000 
	select new
	{
	c.CustomerId,
	c.FirstName,
	c.LastName,
	c.City,
	c.Points
	};
	
	data.Dump();
}

// You can define other methods, fields, classes and namespaces here
