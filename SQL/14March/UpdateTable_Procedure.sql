use sql_invoicing

CREATE PROCEDURE my_payments
    @invoice_id INT,
    @payment_amount DECIMAL(9,2),
    @payment_date DATE
AS

BEGIN
    UPDATE invoices
    SET 
        payment_total = payment_total + @payment_amount,
        payment_date = @payment_date
    WHERE 
        invoice_id = @invoice_id;
END

Exec my_payments @invoice_id= 3,@payment_amount=22.2,@payment_date ='2022-02-02';

