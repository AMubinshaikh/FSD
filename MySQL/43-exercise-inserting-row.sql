-- EXERCISE

-- INSERT THREE RECORD INTO PRODUCTS TABLE

SELECT * FROM products;
INSERT INTO products
VALUES (default,'chairs', '45', 1.25 );
INSERT INTO products
VALUES (default,'zip', '67', 1.50 );
INSERT INTO products
VALUES (default,'mop', '45', 1.75 );

-- ---------------------------------------

INSERT INTO products (name, quantity_in_stock, unit_price)
VALUES ('product1', 10, 1.98),
       ('product2', 20, 2.98),
       ('product3', 30, 3.98)
