SELECT FirstName, MiddleName, LastName 
FROM Person.Person;
GO
SELECT UnitPrice 
FROM Sales.SalesOrderDetail;
GO
SELECT BirthDate 
FROM HumanResources.Employee;
GO
SELECT Name 
FROM Production.Culture 
ORDER BY Name ASC;
GO
SELECT Name 
FROM Production.Product 
WHERE Name LIKE 'C%';
GO
SELECT COUNT(*) AS productos, color AS color 
FROM Production.Product 
GROUP BY color;
GO
SELECT Name, ListPrice 
FROM Production.Product 
ORDER BY ListPrice ASC;
GO
SELECT COUNT(*) AS piezas, size 
FROM Production.Product 
GROUP BY size;
GO
SELECT COUNT(*) AS daystomanufacture 
FROM Production.Product 
WHERE DaysToManufacture NOT LIKE '0';
GO
SELECT Name, style 
FROM Production.Product 
WHERE Name LIKE 'a%';