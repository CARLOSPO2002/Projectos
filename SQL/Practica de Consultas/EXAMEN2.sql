select*from Sales.SalesOrderHeader
select*from Sales
create function dbo.fn_TotalVentasCliente(@CustomerID int)
returns Decimal(10,2)
as
begin
declare @Money decimal(10,2);
set @Money= (select SUM(s.TotalDue)
from Sales.SalesOrderHeader as s
where @CustomerID=s.CustomerID);
return @Money
end;
select dbo.fn_TotalVentasCliente(29825) as TOTALVENTAS


select*from Production.Product
Create procedure dbo.sp_ProductosPorPrecio
@PrecioMin decimal(10,2),
@PrecioMax decimal(10,2)
as
begin
select ProductID,Name,ListPrice
from Production.Product
where ListPrice>=@PrecioMin and ListPrice<=@PrecioMax
order by ListPrice desc;
end;
exec sp_ProductosPorPrecio 1000,2000;

create trigger production.trg_product_noeliminar
on production.product
instead of delete
as
begin
    throw 50010, 'no se permite eliminar productos.', 1;
end;

delete from Production.Product where ProductID=1;