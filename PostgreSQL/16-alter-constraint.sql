-- Alter constraints

ALTER TABLE person DROP CONSTRAINT person_pkey;

ALTER TABLE person ADD PRIMARY KEY (id) ;