-- MATHEMATICAL calculations combine expression

SELECT id,make,model,price, price * .10 FROM car;
SELECT id,make,model,price, ROUND(price* .10, 2 ) FROM car;
SELECT id,make,model,price, ROUND(price* .10, 2 ), ROUND (price - (price* .10)) FROM car;
SELECT id,make,model,price, ROUND(price* .10, 2 ), ROUND (price - (price* .10),2) FROM car;