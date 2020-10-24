-- SELECT & AND
SELECT * FROM person WHERE gender='Female' AND (country='China' OR country='Poland');

SELECT * FROM person WHERE gender='Female' AND (country='China' OR country='Poland') 
         AND last_name=''Pietersma');