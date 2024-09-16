
// Expression
// Aggregate functions 


//Sum()
(from c in Customers 
select c.Points).Sum()

//Average()
(from p in OrderItems
select p.Quantity).Average()

//Min()
(from o in OrderItems
select o.Quantity).Min()

//Max()
(from data in Customers 
select data.Points).Max()

//Count()
(from o in Orders 
select o.OrderId).Count()

