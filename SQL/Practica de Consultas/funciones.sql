CREATE FUNCTION dbo.fnPrecioConIVA (@Precio DECIMAL(10,2))
RETURNS DECIMAL(10,2)
AS
BEGIN
DECLARE @IVA DECIMAL(3,2) = 0.16;
RETURN ROUND(@Precio * (1 + @IVA), 2);
END;


SELECT dbo.fnPrecioConIVA(1000) AS PrecioConIVA;

SELECT NombreProducto, Precio, dbo.fnPrecioConIVA(Precio) AS PrecioConIVA
FROM Productos;
go

SELECT NombreProducto
FROM dbo.Productos
WHERE dbo.fnPrecioConIVA(Precio) > 3000;


DECLARE @r DECIMAL(10,2) = dbo.fnPrecioConIVA(1000);
PRINT @r;

create Function dbo.fnFactorial(@n int)
returns bigint
as 
begin
declare @resultado bigint=1
while(@n>1)
begin
set @resultado=@resultado*@n
set @n=@n-1
end
return @resultado
end;
select dbo.fnFactorial(5) as Resultado;

create Function dbo.fnPedidosCliente(@ID int)
returns Table
as
return(
select p.PedidoID,pr.NombreProducto,p.Total
from Pedidos as p
inner join Productos as pr
on p.ProductoID=pr.ProductoID
where p.ClienteID=@ID
);
select*from dbo.fnPedidosCliente(1) ;
select*from Pedidos