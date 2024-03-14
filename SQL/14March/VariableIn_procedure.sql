
Create Procedure get_risk_factor
AS
BEGIN 
     DECLARE @risk_factor Decimal(9, 2) = 0;
	 DECLARE @invoices_total Decimal(9, 2);
	 DECLARE @invoices_count INT;

	 SELECT @invoices_count= COUNT(*),@invoices_total = SUM(invoice_total) 
	 from invoices;

	IF @invoices_count > 0
    BEGIN
        SET @risk_factor = @invoices_total / @invoices_count * 5;
    END

    SELECT @risk_factor AS risk_factor;

	 END

	EXEC get_risk_factor;