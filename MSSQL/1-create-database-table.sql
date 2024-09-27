--Creating database
CREATE DATABASE Amazon;

--using Database Amazon
USE Amazon;

--1 Create table Customers in Amazon 

CREATE TABLE Customers 
(
customer_id INT PRIMARY KEY,
[name] VARCHAR(50) NOT NULL,
age INT NOT NULL,
gender VARCHAR(10) NOT NULL,
[address] VARCHAR(250) NOT NULL,
pin INT NOT NULL,
);

--2 Create table Customers in Amazon 
CREATE TABLE Orders 
(
order_id INT PRIMARY KEY,
number INT UNIQUE NOT NULL,
[date] DATETIME NOT NULL,
shipping_date DATETIME NOT NULL,
customer_id INT FOREIGN KEY (customer_id) REFERENCES Customers (customer_id),
);


