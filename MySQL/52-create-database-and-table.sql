CREATE DATABASE Amazon;
USE Amazon;

CREATE TABLE `customers` (
`customer_id` INT(11) NOT NULL AUTO_INCREMENT,
`first_name` VARCHAR(50) NOT NULL,
`last_name` VARCHAR(50) NOT NULL,
`birth_date` DATE DEFAULT NULL,
`phone` VARCHAR(50) DEFAULT NULL,
`address` VARCHAR(100) NOT NULL,
`city` VARCHAR(50) NOT NULL,
`state` VARCHAR(50) NOT NULL,
`point` INT(11) NOT NULL DEFAULT '0',
PRIMARY KEY (`customer_id`)
);



