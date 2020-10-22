-- Create Database Objects
CREATE DATABASE Sales;

-- create table name Customers

CREATE TABLE Customers
( 
customer_id INT PRIMARY KEY,
first_name VARCHAR(30) NOT NULL,
last_name VARCHAR(30) NOT NULL,
email VARCHAR(30) NOT NULL,
address VARCHAR(100) NOT NULL,
pin VARCHAR(10) NOT NULL,
phone VARCHAR(10) NOT NULL
);

