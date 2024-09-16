
// Select All from Tables in Expression

var c = Customers.Select(c=>c);
c.Dump();

var p = Products.Select(p=>p);
p.Dump();

var o = Customers.Select(o=>o);
o.Dump();

var s = Shippers.Select(s=>s);
s.Dump();


var oi = OrderItems.Select(oi=>oi);
oi.Dump();