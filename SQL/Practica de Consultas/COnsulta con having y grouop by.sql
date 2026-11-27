select ClienteID, Sum(Total) as TotalGastado
from Pedidos
group by ClienteID
having Sum(Total)>(select AVG(Total) from Pedidos);

/*siempre que se tenga un group by se debe usar el having para filtrar
