select*from(select ClienteID,
count(*) as NumPedidos,
SUM(Total) as TotalGastado
from Pedidos
group by ClienteID) as Resumen
where Resumen.NumPedidos>1;