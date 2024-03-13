--Find The Clients with at least two invoices

--Using IN keyword
use sql_invoicing
Select *
From clients
where client_id in(
select client_id From invoices
Group by client_id
having Count(*)>=2
)

--Using ANY keword
select * from clients
where client_id = any(
   select client_id 
   from invoices
   group by client_id
   having COUNT(*)>=2
)


