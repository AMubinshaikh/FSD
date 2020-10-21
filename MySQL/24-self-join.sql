-- SELF JOINS
-- We can join table with itself is known as self joins
-- we are uses different aliases og same table to indicates another name

SELECT e.employee_id,e.first_name, m.first_name AS Manager 
FROM employees e 
JOIN employees m 
    ON e.reports_to = m.employee_id;
