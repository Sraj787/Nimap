use sql_invoicing;
CREATE TRIGGER payments_after_insert
ON payments
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE invoices
    SET payment_total = payment_total + i.amount
    FROM invoices
    JOIN inserted i ON invoices.invoice_id = i.invoice_id;
END;

execute get_payments;