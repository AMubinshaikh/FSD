
// Where clause statements

var c = Customers.Where(c => c.CustomerId ==7);
c.Dump();

var p = Customers.Where(p => p.Points<3000);
p.Dump();