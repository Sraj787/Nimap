use store

SELECT 
    order_id,
    IsNull(CONVERT(varchar(10), shipper_id), 'Not assigned') AS shipper 
FROM 
    orders
	order by shipper desc;



SELECT 
    order_id,
    Coalesce(CONVERT(varchar(10), shipper_id),comments, 'Not assigned') AS shipper 
FROM 
    orders
	order by shipper desc;

--Exercise
	select CONCAT(first_name,' ',last_name) as FullName,
	       isnull(Convert(varchar(15), phone),'Unknown') AS Phone
	from customers;
