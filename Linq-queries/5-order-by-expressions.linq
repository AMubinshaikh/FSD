
// OrderBy -- Ascending And descending order
// Ascending

Customers.OrderBy(c => c.FirstName)

Customers.OrderBy(l => l.LastName)

Customers.OrderBy(p => p.Points)

OrderItems.OrderBy(o => o.Quantity)

// Descending

Customers.OrderByDescending(c => c.FirstName)

Customers.OrderByDescending(l => l.LastName)

OrderItems.OrderByDescending(oi => oi.Quantity)

Products.OrderByDescending(p => p.UnitPrice)
