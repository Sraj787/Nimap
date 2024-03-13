use sql_invoicing
Select * from clients c
where exists(
    select client_id
	from invoices
	where client_id = c.client_id
);

-- find the products that have never been ordered
--Using IN
use store
select * from products
where product_id not in(
      select product_id from order_items
)

--Using EXists
select * from products p
where Not exists(
      select product_id 
	  from order_items
	  where product_id = p.product_id
)