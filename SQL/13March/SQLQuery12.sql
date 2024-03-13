-- Find the Customers Who have Orders lettuce (id=3)
-- Select Customer_id,First_name,Last_name

Use store

Select customer_id, first_name, last_name
      From customers
where customer_id IN(
       Select o.customer_id
	   From order_items oi
	   JOIN orders o on 
	   oi.order_id = o.order_id
	   where product_id = 3
	   )

--Using Join
Select Distinct c.customer_id, first_name, last_name
  From customers c
  Join orders o ON
  c.customer_id = o.customer_id
  Join order_items oi ON
  o.order_id = oi.order_id
  Where oi.product_id = 3

