create procedure get_invoice_data_Pagination
      @page int,
	  @size int
	  as
	  Begin
Declare @startRow int,@endRow int
set @startRow = ((@page-1) * @size)+1;--((1-1)*5)+1=1 start with 1 ||((2-1)*5)+1=6
set @endRow = @page * @size;-- 1*5=5 || 2*5=10

with getinvoice  as(
select *, ROW_NUMBER() over(order by invoice_id) as srno from invoices
)
select * from getinvoice where srno between @startRow and @endRow;
End

exec get_invoice_data_Pagination @page=2,@size=5;