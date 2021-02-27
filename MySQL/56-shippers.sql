-- Shippers table

CREATE TABLE `shippers`(
`shipper_id` INT(11) NOT NULL AUTO_INCREMENT,
`name` VARCHAR(50) NOT NULL,
PRIMARY KEY (`shipper_id`)
);
select * from shippers;

INSERT INTO `shippers` VALUES (default, 'xyz shaikh');
INSERT INTO `shippers` VALUES (default, 'abc khan');
INSERT INTO `shippers` VALUES (default, 'pqr demmm');

