
//Multiple records Statements

var customerData = from c in Customers
            where c.CustomerId==3
			select new
			{
			c.FirstName,
			c.LastName,
			c.City,
			c.Phone
			};

customerData.Dump();



var productData = from p in Products
           where p.QuantityInStock>60
		   select new
		   {
		   p.ProductId,
		   p.Name,
		   p.QuantityInStock,
		   p.UnitPrice
		   };
		   
productData.Dump();


var orderData = from o in OrderItems
           where o.UnitPrice<5
		   select new
		   {
		   o.OrderId,
		   o.ProductId,
		   o.Quantity,
		   o.UnitPrice
		   };
		   
orderData.Dump();		   
