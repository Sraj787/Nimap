use invoicing
 --find the invoice having invoice_total greater than client_id 3 

--Using Max Keyword
select * from invoices
where invoice_total > (
select MAX(invoice_total) from 
  invoices
  where client_id =3
  );


  --Using the ALL keyword
  Select * from invoices
  where invoice_total > ALL(
  select invoice_total
  from invoices
  where client_id =3
  )