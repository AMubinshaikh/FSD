-- ON CONFLICT DO NOTHING
-- it is like exception handling we can assign error name
INSERT INTO person (id, first_name, last_name, gender, email, date_of_birth, country) 
VALUES (2017, 'RUSS' ,'Ruddoch', 'Male', 'rruddoch@gmail.com', DATE '1952-01-01' , 'Norwat')
ON CONFLICT (id) DO NOTHING; 