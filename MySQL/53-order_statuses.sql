-- Order Statuses

CREATE TABLE `order_statuses` (
`order_status_id` INT(11) NOT NULL AUTO_INCREMENT,
`name` VARCHAR(50) NOT NULL,
PRIMARY KEY(`order_status_id`)
);

INSERT INTO `order_statuses` VALUES(DEFAULT, 'PROCESSED'); 
INSERT INTO `order_statuses` VALUES(DEFAULT, 'SHIPPED'); 
INSERT INTO `order_statuses` VALUES(DEFAULT, 'DELIVERED'); 

SELECT * FROM order_statuses;


