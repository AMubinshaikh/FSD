-- Exists:  it check dependency.

SELECT * first_name, last_name, email
FROM person
WHERE EXISTS (SELECT * FROM car WHERE model = 'xuv');

-- NOT Exists:  it check dependency. it returns reverse record 

SELECT * first_name, last_name, email
FROM person
WHERE NOT EXISTS (SELECT * FROM car WHERE model = 'xuv');