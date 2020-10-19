             --  USING CONSTRAINTS  --

--NOT NULL - Cannot have null values in column
-- In this case we cannot leave employee name column blank/empty
CREATE TABLE Employee (employee_name varchar(50) NOT NULL);

------------------------------------------------------------------

--UNIQUE - All values shoulb de unique(different) 
          --no duplicate value allowed
		  -- in this case we cannot insert duplicate phone number

CREATE TABLE Employee (phone varchar(10) UNIQUE NOT NULL);

----------------------------------------------------------------

--PRIMARY KEY - It is a combination of Unique and Not null
              --Constraints and only one primary key is allowed 
			  --in this case employee_id is Primary key

CREATE TABLE Employee (employee_id INT PRIMARY KEY);

----------------------------------------------------------

--FOREIGN KEY - It is referenced to another column primary key 
              --for unique identifies

CREATE TABLE Department(department_id INT PRIMARY KEY,
                        employee_id INT FOREIGN KEY (employee_id)
						REFERENCES Employee(employee_id));

--------------------------------------------------------------

--CHECK - It is a condition apply in column and if condition is true
        --then it accept value and if condition is false it will
		--not allow that value like age>=18

CREATE TABLE DriverLiscence (age INT, CHECK(age>=18)); 

--this value will inserted because condition is true
insert into DriverLiscence VALUES(18);

--this value will not inserted because condition is false
insert into DriverLiscense VALUES(16);

--------------------------------------------------------------

--DEFAULT - if colum does not have any value we can set predefined 
 
          --value like customer login status inactive
CREATE TABLE CustomerLogin
(employee_status varchar(10), default 'inactive');

--------------------------------------------------------------


--INDEX - Used to create and retrieve data from the database
        --very quickly
CREATE INDEX idx_age ON DrivingLiscense (LastName);


--we can delete index from TABLE
DROP INDEX Drivingliscense.idx_age;