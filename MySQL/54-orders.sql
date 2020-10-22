CREATE TABLE orders(
`order_id` INT(11) NOT NULL AUTO_INCREMENT,
`customer_id` INT(11) NOT NULL,
`order_date` DATE NULL,
`status` INT(11) NOT NULL DEFAULT '1',
`comments` VARCHAR(50) NOT NULL,
`shipped_date` DATE DEFAULT NULL,
`shipper_id` INT(11) NOT NULL,
PRIMARY KEY(`order_id`),
KEY `fk_orders_customers_idx` (`customer_id`),
KEY `order_shippers_idx` (`shipper_id`),
KEY `orders_order_statuses_idx` (`status`),
CONSTRAINT `fk_orders_customers` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON UPDATE CASCADE,
CONSTRAINT `fk_orders_shippers` FOREIGN KEY (`shipper_id`) REFERENCES `shippers` (`shipper_id`) ON UPDATE CASCADE,
CONSTRAINT `fk_orders_orders_statuses` FOREIGN KEY (`status`) REFERENCES `order_statuses` (`order_status_id`) ON UPDATE CASCADE
);
