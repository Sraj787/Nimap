--Using the Case Operator
select
      CONCAT(first_name,' ',last_name) as customer,
	  points,
	  Case
	     when points > 3000 Then 'Gold'
		 when points > 2000 then 'silver'
		 else 'bronze'
	  End as Category
 From customers
