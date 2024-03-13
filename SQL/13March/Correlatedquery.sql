-- for each employee
--   calculate the avg salary for employee.office 
--   return the employee if salary > avg
use sql_hr
Select * from employees e
where salary > (
Select
   AVG(salary)
   from employees
   where office_id = e.office_id
)

--Get invoices that are larger than the 
-- client's average invoice amount
use sql_invoicing

Select * from invoices i
where invoice_total >(
Select AVG(invoice_total) 
From invoices
where client_id = i.client_id
)