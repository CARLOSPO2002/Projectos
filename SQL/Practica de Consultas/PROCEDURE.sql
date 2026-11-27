CREATE OR ALTER PROCEDURE dbo.uspTotalCliente
    @ClienteID INT,
    @Total DECIMAL(18,2) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    SET @Total = 0;

    SELECT @Total = ISNULL(SUM(Total), 0)
    FROM dbo.Pedidos
    WHERE ClienteID = @ClienteID;
END;

DECLARE @TotalGastado DECIMAL(18,2);

EXEC dbo.uspTotalCliente
    @ClienteID = 2,
    @Total = @TotalGastado OUTPUT;

SELECT @TotalGastado AS TotalGastadoCliente2;

CREATE OR ALTER PROCEDURE dbo.uspDatosCliente
    @ClienteID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM dbo.Clientes WHERE ClienteID = @ClienteID)
    BEGIN
        SELECT Nombre, Ciudad
        FROM dbo.Clientes
        WHERE ClienteID = @ClienteID;
    END
    ELSE
    BEGIN
        PRINT 'El cliente no existe';
    END
END;

EXEC dbo.uspDatosCliente @ClienteID = 1;

EXEC dbo.uspDatosCliente @ClienteID = 99;