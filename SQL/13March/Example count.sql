--Using if Fuction

Select
     p.product_id,
	 name,
	 COUNT(*) as orders
	 
from products p
join order_items o on 
      p.product_id = o.product_id

	  group by p.product_id,name;

