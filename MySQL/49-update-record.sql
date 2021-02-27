
-- update table

ALTER TABLE customers ADD pin INT(11) NOT NULL;


-- update record

UPDATE `customers` SET `pin` = 400056 WHERE address = 'khar';
