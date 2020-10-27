
// Aggregate functions - Statements

//SUM()
var totalPoints = (from c in Customers
                   select c.Points)
				   .Sum();

totalPoints.Dump();

//AVERAGE()

var averageUnitPrice = (from o in OrderItems
                        select o.UnitPrice)
						.Average();

averageUnitPrice.Dump();

// MIN()

var minimumQuantityInStock = (from p in Products
                              select p.QuantityInStock)
							  .Min();

minimumQuantityInStock.Dump();

//MAX()

var highestPoints = (from c in Customers
					select c.Points)
					.Max();
highestPoints.Dump();

//COUNT()

var totalNumberOfOrders = (from o in Orders
							select o.OrderId)
							.Count();
							
totalNumberOfOrders.Dump();		

