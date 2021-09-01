--Structured Query Language (SQL)

--SQL - Basic Operations
--? Work with the SQL Data Definition Language (DDL)
--? Work with the SQL Data Manipulation Language (DML)
--? Write Queries using SQL select statements
--? Work with SQL Operators
--? Work with SQL Functions

--Data Definition Language (DDL)
--? Data Definition Language (DDL) is a standard for commands that define the different structures
--in a database
--? DDL Statements are
--? CREATE :Use to create objects like CREATE TABLE, CREATE FUNCTION,
--CREATE SYNONYM, CREATE VIEW. Etc.
--? ALTER :Use to Alter Objects like ALTER TABLE, ALTER USER, ALTER DATABASE.
--? DROP :Use to Drop Objects like DROP TABLE, DROP USER,
--DROP FUNCTION. Etc.
--? TRUNCATE :Use to truncate (delete all rows) a table

--Data Manipulation Language (DML)
--? Data Manipulation Language is used to edit the data present in the database.DDL Statements
--are:
--? INSERT- It is used to enter the data into the records of the table.
--? UPDATE- It is used to update the records in the table
--? DELETE- It is used to delete the existing records in the table.

--Data Manipulation Language (DML)
--? Data Manipulation Language is used to edit the data present in the database.DDL Statements
--are:
--? INSERT- It is used to enter the data into the records of the table.
--? UPDATE- It is used to update the records in the table
--? DELETE- It is used to delete the existing records in the table.
--? MERGE- Merging data from multiple tables.

--Data Query Language (DQL) and Data Control Language(DCL)
--? Data Query Language is used to retrieve the data present in the database. DQL Statements are:
--? SELECT
--? Data Control language is used to control access to the database. DCL statements are:
--? GRANT
--? REVOKE

--Selecting data from columns
--? SQL statement to display all the information of all employees.
select * from Employees;

--? SQL statement to display firstname all employees.
select firstname,lastname from employees;

--? SQL statement to display derived data:

select firstname+' '+lastname as 'Name' from employees
select min(salary) as average_salary from hrdb.dbo.tblemployeeinfo
--? DISTINCT: get only distinct values in a specified column of a table
select distinct(city) from employees

--Filtering rows
--? Where clause is used to get the rows from the table that satisfy one or more conditions
--SELECT select_list FROM table_name WHERE search_condition;
--? Retrieve all products with the category id 1
SELECT productid, productname, categoryid, unitprice FROM
products WHERE categoryid = 1
--? Retrieve all products category id is 1 and the model is 2018.
--SELECT productid, productname, categoryid, modelyear, list_price FROM
--products WHERE categoryid = 1 AND modelyear = 2018

SELECT productid, productname, categoryid, unitprice FROM
products WHERE categoryid = 1 and unitprice>10

--? Get the product whose categoryid  is one or two and unit price is larger than 1,00:
SELECT * FROM products WHERE (categoryid = 1 OR
categoryid = 2) AND unitprice > 100
--? Find the products whose list price is less than 200 or greater than 6,000:
SELECT productname, unitprice FROM products WHERE
unitprice < 200 OR unitprice > 600

--Filtering rows Between and Not Between:
--? Find the products whose list prices are between 1,899 and 1,999.99
SELECT productid, productname, categoryid,
unitprice FROM products WHERE unitprice BETWEEN
18.00 AND 99.99
--? Get the products whose list prices are in the range 149.99 and 199.99
SELECT productid, productname, unitprice FROM
products WHERE unitprice NOT BETWEEN 149.99 AND 199.99

--Filtering rows IN and Not IN:
--? Find the products whose list price is one of the following values: 89.99, 109.99, and
--159.99:
SELECT productname, unitprice FROM products WHERE
unitprice IN (89.99, 109.99, 159.99)
--? Find the products whose list prices are not one of the prices above:
SELECT productname, unitprice FROM products WHERE
unitprice NOT IN (89.99, 109.99, 159.99)



--Filtering rows NULL and Not NULL:
--? Find the customers who do not have phone number recorded in the customers
--table:
SELECT customerid, contactname, phone FROM
customers WHERE phone = NULL
SELECT customerid, contactname, phone FROM
customers WHERE phone IS NULL
--? Find the customers who do have the phone information:
SELECT customerid, contactname, phone FROM
customers WHERE phone IS NOT NULL



--Filtering rows using wild cards:
--? Find products whose name contains the string “Cruiser”
SELECT productid, productname, categoryid, unitprice
FROM products WHERE productname LIKE '%Cruiser%'

--? Find the customers whose  name starts with the letter z:
SELECT customerid, contactname FROM customers
WHERE contactname LIKE 'z%'
--? Find customers whose last name ends with the string “er”:
SELECT customerid, contactname FROM customers
WHERE contactname LIKE '%er'


--Filtering rows using wild cards:
--? Find the customers where the second character is the letter u:
SELECT customerid, contactname FROM customers
WHERE contactname LIKE '_u%'
--Find the customers where the first character in the last name is Y or Z:
SELECT customerid, contactname FROM customers
WHERE contactname LIKE '[YZ]%'
--? Find the customers where the first character in the last name is the letter in the
--range A through C:
SELECT customerid, contactname FROM customers
WHERE contactname LIKE '[A-C]%'



--Filtering rows using wild cards:
--? Find customers where the first character in the last name is not the letter in the
--range A through X:
SELECT customerid, contactname FROM customers
WHERE contactname LIKE '[^A-X]%'
--? Find customers where the first character in the first name is not the letter A:
SELECT customerid, contactname FROM customers
WHERE contactname NOT LIKE 'A%'



--Filtering rows with TOP:
SELECT TOP 10 productname, unitprice FROM products
ORDER BY unitprice DESC;
SELECT TOP 1 PERCENT productname, unitprice FROM
products ORDER BY unitprice DESC;
SELECT TOP 3 WITH TIES productname, unitprice FROM
products ORDER BY unitprice DESC;



--With SQL, how do you select all the records from a table named
--“Persons” where the value of the column “FirstName” ends
--with an “a”?
SELECT * FROM Employees WHERE FirstName='%a%'
SELECT * FROM Employees WHERE FirstName LIKE 'a%'
SELECT * FROM Employees WHERE FirstName='a'
SELECT * FROM Employees WHERE FirstName LIKE '%a'



--Sql Server Built-in functiontions:
--? Number functions:
--? ABS Returns the absolute value of a number
--? CEILING Returns the smallest integer value that is >= a number
--? FLOOR Returns the largest integer value that is <= to a number
--? PI Returns the value of PI
--? POWER Returns the value of a number raised to the power of another
--number
--? RAND Returns a random number
--? ROUND Rounds a number to a specified number of decimal places
--? SQRT Returns the square root of a number
--? SQUARE Returns the square of a number



--Sql Server Built-in functiontions:
--? Character functions:
--? ASCII Returns the ASCII value for the specific character
--? CHAR Returns the character based on the ASCII code
--? CHARINDEX Returns the position of a substring in a string
--? CONCAT Adds two or more strings together
--? LEFT Extracts a number of characters from a string (starting from left)
--? LEN Returns the length of a string
--? LOWER Converts a string to lower-case
--? LTRIM Removes leading spaces from a string
--? RTRIM Removes trailing spaces from a string
--? STR Returns a number as string
--? SUBSTRING Extracts some characters from a string



--Sql Server Built-in functiontions:
--? Date functions:
--? CURRENT_TIMESTAMP Returns the current date and time
--? DATEADD Adds a time/date interval to a date and then returns the date
--? DATEDIFF Returns the difference between two dates
--? DATENAME Returns a specified part of a date (as string)
--? DATEPART Returns a specified part of a date (as integer)
--? DAY Returns the day of the month for a specified date
--? GETDATE Returns the current database system date and time
--? ISDATE Checks an expression and returns 1 if it is a valid date, otherwise 0
--? MONTH Returns the month part for a specified date (a number from 1 to 12)
--? SYSDATETIME Returns the date and time of the SQL Server
--? YEAR Returns the year part for a specified date



--Sql Server Built-in functiontions:
--? Aggregate functions:
--? AVG The AVG() aggregate function calculates the average of non-NULL
--values in a set.
--? COUNT The COUNT() aggregate function returns the number of rows in a
--group, including rows with NULL values.
--? MAX The MAX() aggregate function returns the highest value
--(maximum) in a set of non-NULL values.
--? MIN The MIN() aggregate function returns the lowest value
--(minimum) in a set of non-NULL values.
--? SUM The SUM() aggregate function returns the summation of all nonNULL values a set.




--Sql Server Built-in functiontions:
--? Aggregate functions:
--? AVG The AVG() aggregate function calculates the average of non-NULL
--values in a set.
--? COUNT The COUNT() aggregate function returns the number of rows in a
--group, including rows with NULL values.
--? MAX The MAX() aggregate function returns the highest value
--(maximum) in a set of non-NULL values.
--? MIN The MIN() aggregate function returns the lowest value
--(minimum) in a set of non-NULL values.
--? SUM The SUM() aggregate function returns the summation of all nonNULL values a set.



--Sql Server Built-in function:
--? Aggregate functions:
--? Find the average list price of all products in the products table:
 SELECT AVG(unitprice) avg_product_price FROM products
--? Find the number of products whose price is greater than 500:
 SELECT COUNT(*) product_count FROM products WHERE unitprice > 500
--? Find the highest list price of all products:
 SELECT MAX(unitprice) max_list_price FROM products;
--? Find the lowest list price of all products:
 SELECT MIN(unitprice) min_list_price FROM products;
--? Calculate the total stock by product:
 SELECT SUM(unitsinstock) stock_count FROM products



--Which SQL function is used to count the number of rows in a
--SQL query?
--COUNT(*)
--NUMBER()
--COUNT()
--SUM()



--Order by clause:
--? Display employees list by the first name in ascending order:
SELECT firstname, lastname FROM employees
ORDER BY firstname;
--? Display employees list by the first name in descending order:
SELECT firstname, lastname FROM employees 
ORDER BY firstname DESC;
--? Retrieve first name, last name, and city of the employees sorted by the city first and
--then by the first name.
SELECT city, firstname, lastname FROM employees
ORDER BY city, firstname;



--Order by clause:
--? Sort the employees by the city in descending order and the sort the sorted result set by the first
--name in ascending order.
SELECT city, firstname, lastname FROM employees
ORDER BY city DESC, firstname ASC;
--? Sort the employees by the state even though the state column does not appear on the select list.
--SELECT city, firstname, lastname FROM employees ORDER BY state;
--? Retrieve a customer list sorted by the length of the first name.
SELECT firstname, lastname FROM employees 
ORDER BY LEN(firstname) DESC;



--Group by clause:
--? The GROUP BY clause allows you to arrange the rows of a query in groups. The groups are
--determined by the columns that you specify in the GROUP BY clause.
--? Retrieve customer id and the year of the customers with the customer id one and two.
SELECT customerid, max (orderdate) order_year FROM orders WHERE
customerid IN (1, 2) GROUP BY customerid 
ORDER BY customerid;
--? Retrieve customer id and the ordered year of the customers with the customer id one and two, the
--number of orders placed by the customer by year:
SELECT customerid, YEAR (orderdate) order_year FROM orders WHERE
customerid IN (1, 2) GROUP BY customerid, YEAR (orderdate) 
ORDER BY customerid;



--? Return the number of customers in every city:
SELECT city, COUNT (customerid) customer_count FROM
customers GROUP BY city ORDER BY city;
--? Return number of customers by region and city:
SELECT city, region, COUNT (customerid) customer_count FROM
customers GROUP BY region, city ORDER BY city, region;



--? The HAVING clause is often used with the GROUP BY clause to filter groups based on a specified list
--of conditions.
--? Find the customers who placed at least two orders per year:
SELECT customerid, YEAR (orderdate), COUNT (orderid) order_count
FROM orders
GROUP BY customerid,YEAR (orderdate)
HAVING COUNT (orderid) >= 2
ORDER BY customerid;



--Group by .. having clause:
--? Find sales orders whose net values are greater than 20,000:
SELECT orderid,SUM(quantity * unitprice * (1 - discount)) net_value
FROM "order details"
GROUP BY orderid 
HAVING SUM(quantity * unitprice * (1 - discount)) > 15000 
ORDER BY net_value;



--Group by .. having clause:
--? Filter out the category which has the maximum list price greater than 4,000 or the minimum
--list price less than 500:
SELECT categoryid, MAX (unitprice) max_unitprice, MIN (unitprice) min_unitprice
FROM products
where UnitPrice>100
GROUP BY categoryid
HAVING MAX (unitprice) > 4000 OR MIN (unitprice) < 200;

select employeeid,count(orderid) 'Totl Orders'  from orders
group by employeeid


--Group by .. having clause:
--? Find product categories whose average list prices are between 500 and 1,000:
SELECT categoryid, AVG (unitprice) avg_unitprice
FROM products
GROUP BY categoryid
HAVING AVG (unitprice) BETWEEN 500 AND 1000;



--What is the meaning of “HAVING” clause in Sql?
--None of the mentioned
--To filter out the column values
--To filter out the row values
--To filter out the row and column values



--Joins:
--? In a relational database, data is distributed in multiple logical tables.
--? To get a complete meaningful set of data, you need to query data from these tables by using
--joins.
--? SQL Server supports many kinds of joins:
--? Inner join
--? Left join
--? Right join
--? Full outer join and
--? Cross join.
--? Each join type specifies how SQL Server uses data from one table to select rows in another
--table.



--Joins:
--? Inner join:
--? produces a data set that includes rows from the left table which have matching rows from the
--right table.
--? Get the rows from the candidates table that have the corresponding rows with the same
--values in the fullname column of the employees table:

--SELECT c.id candidate_id, c.fullname candidate_name, e.id employee_id,
--e.fullname employee_name
--FROM
--hr.candidates c
--INNER JOIN
--hr.employees e
--ON e.fullname = c.fullname;


--Joins:
--? Left join:
--? Selects data starting from the left table and matching rows in the right table.
--? The left join returns all rows from the left table and the matching rows from the
--right table.
--? If a row in the left table does not have a matching row in the right table, the
--columns of the right table will have nulls.
--SELECT
--c.id candidate_id, c.fullname candidate_name, e.id
--employee_id, e.fullname employee_name
--FROM
--hr.candidates c
--LEFT JOIN
--hr.employees e
--ON e.fullname = c.fullname;


--Joins:
--? Right join:
--? selects data starting from the right table. It is a reversed version of the left join.
--? The right join returns a result set that contains all rows from the right table and the
--matching rows in the left table.
--? If a row in the right table that does not have a matching row in the left table, all
--columns in the left table will contain nulls.
--SELECT
--c.id candidate_id, c.fullname candidate_name, e.id
--employee_id, e.fullname employee_name
--FROM hr.candidates c
--RIGHT JOIN hr.employees e ON e.fullname = c.fullname;


--Joins:
--? Full join:
--? Returns a result set that contains all rows from both left and right tables, with
--the matching rows from both sides where available.
--? In case there is no match, the missing side will have NULL values.
--SELECT
--c.id candidate_id, c.fullname candidate_name, e.id
--employee_id, e.fullname employee_name
--FROM
--hr.candidates c
--FULL JOIN
--hr.employees e

--Joins:
--? Self join:
--? A self join allows you to join a table to itself.
--? It is useful for querying hierarchical data or comparing rows within the same table.
--? A self join uses the inner join or left join clause.
--? Because the query that uses self join references the same table, the table alias is
--used to assign different names to the same table within the query.
--SELECT
--e.first_name + ' ' + e.last_name employee, m.first_name + ' '
--+ m.last_name manager
--FROM sales.staffs e
--INNER JOIN sales.staffs m ON m.staff_id = e.manager_id ORDER
--BY manager;


--Joins:
--? Self join:
--? Find customers who locate in the same city.
--SELECT
--c1.city, c1.first_name + ' ' + c1.last_name customer_1,
--c2.first_name + ' ' + c2.last_name customer_2
--FROM sales.customers c1
--INNER JOIN sales.customers c2
--ON c1.customer_id > c2.customer_id AND c1.city = c2.city
--ORDER BY city, customer_1, customer_2;



--Joins:
--? Cross join:
--? The CROSS JOIN joined every row from the first table (T1) with every row from
--the second table (T2). In other words, the cross join returns a Cartesian product
--of rows from both tables.
--? Return combinations of all products and stores:
SELECT
p.productid,ProductName,companyname,categoryname
FROM suppliers s ,products p,categories c
where s.SupplierID=p.SupplierID
 and  p.categoryid=c.categoryid
--new syntax
SELECT
p.productid,ProductName,companyname,categoryname
from products p join suppliers s
on p.supplierid=s.SupplierID
join categories c
on c.CategoryID=p.CategoryID
where c.CategoryName like 'S%'
--Equi Join...It will fetch only the matching rows between the two tables
select e.employeeid,e.name,e.depid,d.name
from tblemployeeinfo e right outer join tblDepartment d
on e.DepId=d.DepId
select depid from tbldepartment
select employeeid from tblemployeeinfo
insert tblemployeeinfo(employeeid,name)
values(4,'Saadhana')
update tblemployeeinfo set depid=2 where employeeid=3

--old syntax
select e.employeeid,e.name,e.depid,d.name
from tblemployeeinfo e , tblDepartment d
where e.DepId=d.DepId

CROSS JOIN sales.stores



--Which product is returned in a join query have no join
--condition?
--None of the mentioned
--Cartesian
--Equijoins
--Both Equijoins and Cartesian

--Subquery:
--? A subquery is a query nested inside another statement:
--SELECT order_id, order_date, customer_id
--FROM sales.orders
--WHERE customer_id
--IN ( SELECT customer_id FROM sales.customers WHERE city =
--'New York')
--ORDER BY order_date DESC;


--Subquery:
--? SQL Server supports up to 32 levels of nesting.
--SELECT product_name, list_price
--FROM production.products
--WHERE
--list_price >
--( SELECT AVG (list_price) FROM production.products WHERE brand_id
--IN
--( SELECT brand_id FROM production.brands WHERE brand_name = 'Strider' OR
--brand_name = 'Trek' ) )
--ORDER BY list_price;


--Subquery IN operator:
--SELECT
--product_id, product_name
--FROM production.products
--WHERE category_id
--IN
--( SELECT category_id FROM production.categories WHERE category_name =
--'Mountain Bikes' OR category_name = 'Road Bikes' );

--Subquery ANY operator:
--SELECT
--product_name, list_price
--FROM production.products
--WHERE list_price >=
--ANY
--( SELECT AVG (list_price) FROM production.products GROUP BY brand_id )



--Subquery ALL operator:
--SELECT
--product_name, list_price
--FROM production.products
--WHERE list_price >=
--ALL
--( SELECT AVG (list_price) FROM production.products GROUP BY brand_id )



--Subquery EXISTS and NOT EXISTS operator:
--SELECT
--customer_id, first_name, last_name, city
--FROM sales.customers c
--WHERE
--EXISTS
--( SELECT customer_id FROM sales.orders o WHERE o.customer_id
--= c.customer_id AND YEAR (order_date) = 2017 )
--ORDER BY first_name, last_name;



--Subquery EXISTS and NOT EXISTS operator:
--SELECT
--customer_id, first_name, last_name, city
--FROM sales.customers c
--WHERE
--NOT EXISTS
--( SELECT customer_id FROM sales.orders o WHERE o.customer_id
--= c.customer_id AND YEAR (order_date) = 2017 )
--ORDER BY first_name, last_name;


--Which of the following statement(s) is TRUE regarding
--subqueries?
--Inner queries cannot contain GROUP BY clause
--Outer query and inner query can get data from different tables
--Inner queries in WHERE clause can contain ORDER BY
--Outer query and inner query must get data from the same table

SQL-For all RDBMS
transact-SQL for MS SQL Server,Sybase
PLSQL-Oracle

begin
declare @marks int,@maxscore int,@percent float
set @marks=75
set @maxscore=80
set  @percent= @marks / @maxscore
print 'The marks obtained is '+ CONVERT(varchar(20), @marks)
end




--Transaction Management
--? What is Transaction?
--? A transaction is a unit of work that is performed against a database.
--? This work can be performed manually, such as an UPDATE statement you issue in SQL
--Server Management Studio or an application that INSERTS data into the database.
--? These are all transactions.

--Transaction Management
--? SQL Server supports the following transaction modes:
--? Autocommit transactions- Each individual statement is a transaction.
--? Explicit transactions - Each transaction is explicitly started with the BEGIN
--TRANSACTION statement and explicitly ended with a COMMIT or ROLLBACK
--statement.
--? Implicit transactions – A new transaction is implicitly started when the prior transaction
--completes, but each transaction is explicitly completed with a COMMIT or ROLLBACK
--statement.

--Transaction Management
--? ACID properties:
--? Atomicity - ensures that all operations within the work unit are completed successfully,
--otherwise the transaction is aborted at the point of failure and previous operations are
--rolled back to their former state.
--? Consistency - ensures that the database properly changes states upon a successfully
--committed transaction.
--? Isolation – enables transactions to operate independently of and transparent to each
--other.
--? Durability - ensures that the result or effect of a committed transaction persists in case
--of a system failure.

--Transaction Management
--? SQL Server supports transaction control commands:
--? BEGIN TRANSACTION- the starting point of a transaction
--? ROLLBACK TRANSACTION - roll back a transaction either because of a mistake or a
--failure
--? COMMIT TRANSACTION - save changes to the database

--Transaction Management
--DECLARE @intErrorCode INT
--BEGIN TRAN
--UPDATE Authors
--SET Phone = '415 354-9866'
--WHERE au_id = '724-80-9391'
--SELECT @intErrorCode = @@ERROR
--IF (@intErrorCode <> 0) GOTO PROBLEM
--UPDATE Publishers
--SET city = 'Calcutta', country = 'India'
--WHERE pub_id = '9999'
--SELECT @intErrorCode = @@ERROR
--IF (@intErrorCode <> 0) GOTO PROBLEM
--COMMIT TRAN
--PROBLEM:
--IF (@intErrorCode <> 0) BEGIN
--PRINT 'Unexpected error occurred!'
--ROLLBACK TRAN
--END

--Transaction Management
--SELECT 'Before BEGIN TRAN', @@TRANCOUNT -- The value of @@TRANCOUNT is 0
--BEGIN TRAN
--SELECT 'After BEGIN TRAN', @@TRANCOUNT -- The value of @@TRANCOUNT is 1
--DELETE sales
--BEGIN TRAN nested
--SELECT 'After BEGIN TRAN nested', @@TRANCOUNT
---- The value of @@TRANCOUNT is 2
--DELETE titleauthor
--COMMIT TRAN nested
---- Does nothing except decrement the value of @@TRANCOUNT
--SELECT 'After COMMIT TRAN nested', @@TRANCOUNT
---- The value of @@TRANCOUNT is 1
--ROLLBACK TRAN
--SELECT 'After ROLLBACK TRAN', @@TRANCOUNT -- The value of @@TRANCOUNT is 0
---- because ROLLBACK TRAN always rolls back all transactions and sets
---- @@TRANCOUNT to 0

--__________ marks the end of a successful implicit or explicit
--transaction.
--All of the mentioned
--ROLLBACK TRANSACTION
--COMMIT TRANSACTION
--COMMIT WORK

--Views
--? A view is a named query stored in the database catalog that allows you to refer to it
--later.
--? A view may consist of columns from multiple tables using joins or just a subset of
--columns of a single table.
--? Views is useful for abstracting or hiding complex queries.
--? DML operations can not be performed if view contains multiple tables data( using joins).
--? With Check Option: WITH CHECK OPTION will make sure that all INSERT and UPDATE
--statements executed against the view meet the restrictions in the WHERE clause, and
--that the modified data in the view remains visible after INSERT and UPDATE statements.
--CREATE VIEW [OR ALTER] schema_name.view_name [(column_list)] AS
--select_statement;

--Views
--CREATE VIEW customerInfo_View
--AS
--Select CustID,
--FNAME,
--LASTNME,
--UserID
--FROM dbo.Customer
--select * from customerInfo_View

--Views
--CREATE VIEW sales.daily_sales
--AS
--SELECT
--year(order_date) AS y,
--month(order_date) AS m,
--day(order_date) AS d,
--p.product_id,
--product_name,
--quantity * i.list_price AS sales
--FROM sales.orders AS o
--INNER JOIN sales.order_items AS i
--ON o.order_id = i.order_id
--INNER JOIN production.products AS p ON p.product_id =
--i.product_id;


--Views
--? Renaming a View:
--EXEC sp_rename ‘old name’,’new name’;
--? Drop a View:
--DROP VIEW [IF EXISTS] schema_name.view_name;
--? List all the views in the database:
--select schema_name(schema_id) as schema_name, name as view_name
--from sys.views order by schema_name, view_name

--Syntax for creating views is __________
--CREATE VIEW AS UPDATE
--CREATE VIEW AS UPDATE
--CREATE VIEW AS SELECT
--DROP VIEW AS SELECT
