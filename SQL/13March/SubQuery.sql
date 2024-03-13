--Example: To find the prduct details Having Price greater than id 3
Use store
SELECT * FROM products
WHERE unit_price>(
     SELECT unit_price
	 FROM products
	 WHERE product_id = 3
);

--Exercise: Find Employee Whose earn more tha average
use sql_hr
Select AVG(salary) as AverageSalary from employees;

Select * From employees
WHERE salary>(Select AVG(salary)
              From employees)