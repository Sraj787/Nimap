--Example:1
SELECT 
    client_id,
    SUM(invoice_total) AS total_sales,
    COUNT(*) AS number_of_invoices
FROM invoices
GROUP BY client_id
HAVING SUM(invoice_total) > 500 

--Example:2
SELECT 
    client_id,
    SUM(invoice_total) AS total_sales,
    COUNT(*) AS number_of_invoices
FROM invoices
GROUP BY client_id
HAVING SUM(invoice_total) > 500 AND COUNT(*) >5;

--Exercise 
use store

SELECT c.customer_id,
       c.first_name,
	   c.last_name,
	   SUM(oi.quantity * oi.unit_price) AS Total_sales
FROM customers c
JOIN orders o ON c.customer_id = o.customer_id
JOIN order_items oi ON o.order_id = oi.order_id
WHERE c.state = 'VA'
GROUP BY c.customer_id,
       c.first_name,
	   c.last_name
HAVING SUM(oi.quantity * oi.unit_price) > 100;
	 