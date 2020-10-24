-- ADDING FOREIGN KEY

person_id BIGINT REFERENCES car(id),
UNIQUE (car_id);