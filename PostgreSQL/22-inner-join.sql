-- INNER JOINS

SELECT first_name, last_name,email FROM person
JOIN car ON person.car_id = car.id;
\x for expanding display