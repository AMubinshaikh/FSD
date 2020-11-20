-- RIGHT JOINS

SELECT * FROM person
LEFT JOIN car ON person.car_id = car.id;