CREATE TABLE Orders 
(
order_id INT PRIMARY KEY,
number INT UNIQUE NOT NULL,
[date] DATETIME NOT NULL,
shipping_date DATETIME NOT NULL,
customer_id INT FOREIGN KEY (customer_id) REFERENCES Customers (customer_id),
);

--Above Existing Table does not have total(column)
--Adding column named Total in table Orders

ALTER TABLE Orders ADD Total FLoat
-- Adding one column(Total) in Orders table name


ALTER TABLE Orders ADD Total FLOAT,

-- Now we can alter TABLE by Delete column Using DROP Command

ALTER TABLE Orders DROP Column Total

--Reaname DATABASE name
ALTER DATABASE Amazon MODIFY NAME = AmazonPrime ;

