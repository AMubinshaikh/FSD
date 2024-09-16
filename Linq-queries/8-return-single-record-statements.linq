
// Return Single record Statements

var data  = from c in Customers
         where c.Points>1000
		 select c.FirstName;
		 
		 data.Dump();
		 

var data = from p in Products
         where p.UnitPrice>1
		 select p.Name;
		 
		 data.Dump();
		 
var data = from s in Shippers
           where s.ShipperId==3
		   select s.Name;
		   data.Dump();