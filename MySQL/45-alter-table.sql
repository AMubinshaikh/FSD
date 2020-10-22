-- Alter Table Statements
-- Adding 1 column in Table Customers

ALTER TABLE Customers ADD COLUMN city VARCHAR(30); 

-- changing Table Name

ALTER TABLE Customers RENAME Customer;

-- add column at specified location
ALTER TABLE Customer ADD age INT NOT NULL AFTER email;

