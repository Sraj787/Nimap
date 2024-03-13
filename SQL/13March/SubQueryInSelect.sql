
use sql_invoicing

select invoice_id,
       invoice_total,
	   (select Avg(invoice_total)from invoices) As invoice_average,
	   invoice_total - (select Avg(invoice_total)from invoices) as Differance
	   from invoices;

--To find the client_id, name ,total_sales,average differance

select client_id,
       name,
	   (select SUM(invoice_total) from invoices
	   where client_id = c.client_id) as total_sales,
	   (select AVG(invoice_total) from invoices) as average,
	   (select SUM(invoice_total) from invoices
	   where client_id = c.client_id)-(select AVG(invoice_total) from invoices) as differance
from clients c;


select * from (
       select 
       client_id,
       name,
	   (select SUM(invoice_total) 
	           from invoices
	           where client_id = c.client_id) as total_sales,
	   (select AVG(invoice_total)
	           from invoices) as average,
	   (select SUM(invoice_total) 
	           from invoices
	           where client_id = c.client_id)-(select AVG(invoice_total) 
			   from invoices) as differance
       from clients c
	   ) as summary
 where total_sales Is Not Null