--       DELETE STATEMENTS

DELETE FROM Customers Where 
[address]= 'Bandra' and pin= '400051' OR gender='Male';

DELETE FROM Customers Where 
     age>= 40 AND gender='Male';

DELETE FROM Customers Where 
gender= 'Female' and pin= '400051' OR age<=19;



