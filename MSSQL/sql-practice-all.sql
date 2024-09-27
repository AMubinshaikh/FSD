CREATE DATABASE Amazon;
USE Amazon;

ALTER TABLE Customers 
(
customer_id INT PRIMARY KEY,
customer_name VARCHAR(50) NOT NULL,
customer_age INT NOT NULL,
customer_gender VARCHAR(10) NOT NULL,
customer_address VARCHAR(250) NOT NULL,
customer_pin INT NOT NULL,
);

CREATE TABLE Products 
(
product_id INT PRIMARY KEY,
product_category VARCHAR(50) NOT NULL ,
product_name VARCHAR(50) NOT NULL,
product_qty INT NOT NULL,
product_price INT NOT NULL

);
DROP TABLE Orders;
SELECT * FROM Orders;

CREATE TABLE Orders (
    order_id INT NOT NULL,
    order_number INT NOT NULL,
    customer_id int,
    PRIMARY KEY (order_id),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id),
 );

 INSERT INTO Orders VALUES
 ( 5,5555,5 );

 /* DELETE RECORD */
 DELETE FROM Customers WHERE customer_id = 5;
 

/* CREATE VIEW */
 CREATE VIEW TestView2 AS SELECT customer_name,customer_address, customer_pin FROM Customers;
 
 SELECT * FROM TestView2;
 
 /* UPDATE */
 UPDATE Customers SET customer_name = 'Nazim Shaikh' WHERE customer_id = 3;

/* uSE DISTINCT FOR UNIQUE*/ 
 SELECT COUNT(DISTINCT customer_name) FROM Customers;

SELECT * FROM Customers ORDER BY customer_age;
/* USE LOGICAL > AND < */

SELECT * FROM Customers WHERE customer_age>25 and customer_age<40;
 
 /*  USE BETWEEN  */

SELECT * FROM Customers WHERE customer_age BETWEEN 25 and 40;

/*  USE NOT IN  */
SELECT * FROM Customers WHERE customer_address NOT IN ('Bandra');
/*LIKE ends with*/
SELECT * FROM Customers WHERE customer_name LIKE'%H';
/*LIKE Strarts with*/
SELECT * FROM Customers WHERE customer_name LIKE'Z%';
/* LIKE Strarts and ends with */
SELECT * FROM Customers WHERE customer_name LIKE'Z%H';
SELECT * FROM Customers;
/* IF ELSE OR SELECT CASE */
SELECT CASE (customer_address)
WHEN 'Bandra' THEN 'MUMBAI'
WHEN 'Santacruz' THEN 'MUMBAI'
WHEN 'Byculla' THEN 'SOUTH MUMBAI'
WHEN 'Thane' THEN 'OUT OF MUMBAI'
ELSE 'NOT IN RANGE'
END
FROM Customers
/* INNER JOIN */
SELECT * FROM Customers AS T1 FULL JOIN Orders AS T2
ON T1.customer_id = T2.customer_id
/* AGGREGATE FUNCTIONS */
/* COUNT */
SELECT COUNT(customer_age) from Customers

/* SUM */
SELECT SUM(customer_age) from Customers

/* MAX */
SELECT MAX(customer_age) from Customers

/* MIN */
SELECT MIN(customer_age) from Customers

/* AVG */
SELECT AVG(customer_age) from Customers

SELECT COUNT(*)
FROM Customers GROUP BY customer_name;

UPDATE Customers set customer_pin= 400051 WHERE customer_id=5;