select*from Pedidos;

select count(PedidoID) as TotalPedidos, sum(Total) as Total, max(Total) as MontoMasGrande
from Pedidos;

select*from Pedidos;
select*from Clientes
select upper(c.Nombre) as Nombre, p.PedidoID, p.Total
from Clientes as c
inner join Pedidos as p
on c.ClienteID=p.ClienteID
where p.Total>1000;

select*from Pedidos;
select*from Clientes;

select c.ClienteID,c.Nombre, count(p.PedidoID) as NumeroPedidos
from  Clientes as c
inner join Pedidos as p
on c.ClienteID=p.ClienteID
group by
     c.ClienteID,
	 c.Nombre
select*from Pedidos;
select*from Productos;
select*from Clientes;

select c.Nombre, p.ProductoID,pr.Precio
from Clientes as c
inner join Pedidos as p
on c.ClienteID=p.ClienteID
inner join Productos as pr
on p.ProductoID=pr.ProductoID
where pr.Precio>(select avg(Precio) from Productos);