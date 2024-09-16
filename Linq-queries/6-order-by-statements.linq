
// Order BY Ascending Statements 
var c = Customers.OrderBy(o => o.FirstName);
c.Dump();

var p = Products.OrderBy(p => p.UnitPrice);
p.Dump();

var oi = OrderItems.OrderBy(oi => oi.Quantity);
oi.Dump();

// Order By Descending statements

var c = Customers.OrderByDescending(c => c.FirstName);
c.Dump();

var p = Products.OrderByDescending(p => p.QuantityInStock);
p.Dump();

var o = Orders.OrderByDescending(o => o.ShipperId);
o.Dump();