select NombreProducto, Precio
from Productos
where Precio>(select AVG(Precio) from Productos);
select*from Clientes

select*from Pedidos;

select c.Nombre, p.NombreProducto, pe.Total
from Clientes as c
inner join Pedidos as pe
on c.ClienteID=pe.ClienteID
inner join Productos as p
on p.ProductoID=pe.ProductoID
where pe.Total>2000;

SELECT 
    c.Nombre,
    COUNT(pe.ClienteID) AS TotalPedidos
FROM Clientes AS c
INNER JOIN Pedidos AS pe
    ON c.ClienteID = pe.ClienteID
GROUP BY 
    c.ClienteID,
    c.Nombre
HAVING COUNT(pe.ClienteID) > 1;

select 
c.Nombre,
sum(pe.Total) as TotalComprado
from Clientes as c
inner join Pedidos as pe
on c.ClienteID=pe.ClienteID
group by
     c.ClienteID,
	 c.Nombre
having sum(pe.Total)>(select avg(Total) from Pedidos);



