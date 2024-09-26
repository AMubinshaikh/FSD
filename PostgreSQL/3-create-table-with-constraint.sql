-- CREATING TABLE WITH CONSTRAINTS

CREATE TABLE person (
id BIGSERIAL NOT NULL PRIMARY KEY, -- bigserial is auto generate data type like AUTO_INCREMENT
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
gender VARCHAR(7) NOT NULL,
date_of_birth DATE NOT NULL,
email VARCHAR(150) );