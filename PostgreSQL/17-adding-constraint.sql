-- adding constraints

ALTER TABLE person ADD CONSTRAINT unique_email_address UNIQUE (email);
ALTER TABLE person ADD UNIQUE (email);
ALTER TABLE person ADD CONSTRAINT gender_constraint CHECK ( gender ='female' OR gender='male');