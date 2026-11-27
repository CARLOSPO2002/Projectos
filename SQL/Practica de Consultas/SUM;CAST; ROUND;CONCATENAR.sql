select*from HumanResources.Employee;
select*from Person.BusinessEntity;
select*from Person.Person;

select CONCAT(p.FirstName,' ',p.LastName) as Employee ,h.HireDate
from Person.Person as p
inner join HumanResources.Employee as h
on p.BusinessEntityID=h.BusinessEntityID;

select*from Production.Product;
select*from Sales.SalesOrderDetail

select ProductID, cast(Round(SUM(LineTotal),2)as float) as TOTAL
from Sales.SalesOrderDetail as s
group by 
    ProductID
having count(ProductID)>50;
