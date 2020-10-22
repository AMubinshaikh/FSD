CREATE TABLE `products`(
`product_id` INT(11) NOT NULL AUTO_INCREMENT,
`name` VARCHAR(50) NOT NULL,
`quantity_in_stock` INT(11) NOT NULL,
`unit_price` DECIMAL(4,2) NOT NULL,
PRIMARY KEY (`product_id`)
);
SELECT * FROM products;
SELECT * FROM customers;

INSERT INTO products VALUES (default,'Chair',500,4.79);
INSERT INTO products VALUES (default,'Mobile',100,5.78);
INSERT INTO products VALUES (default,'Bottle',50,20.50);
INSERT INTO products VALUES (default,'Glass',230,40.89);
INSERT INTO products VALUES (default,'Basket',300,10.00);
INSERT INTO products VALUES (default,'knife',500,40.00);
INSERT INTO products VALUES (default,'pen',670,60.00);
INSERT INTO products VALUES (default,'sleeper',30,30.00);
INSERT INTO products VALUES (default,'can',130,6.00);
INSERT INTO products VALUES (default,'bag',550,4.00);