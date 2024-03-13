-- Find The Products that Have Never Orders

use store;
Select * from products
  WHERE product_id NOT IN(
  Select Distinct product_id 
  from order_items
  )
  
--Find client Without invoices
Use sql_invoicing;
Select * From clients
   Where client_id not in(
        Select
        Distinct client_id
        from invoices
)