-- LIMIT, OFFSET, FETCH 

SELECT * FROM person LIMIT 10;
SELECT * FROM person OFFSET 10 LIMIT 5; // DISPLAY RECORD AFTER 10 AND 5 RECORD WILL DISPLAY
SELECT * FROM person OFFSET 5 FETCH FIRST 5 ROW ONLY;