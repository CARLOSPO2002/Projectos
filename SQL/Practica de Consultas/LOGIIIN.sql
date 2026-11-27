USE master;
GO

-- Crear el login a nivel de servidor
CREATE LOGIN lg_vendedor
WITH PASSWORD = 'Vendedor123*',
DEFAULT_DATABASE = Practic;
GO

-- Seleccionar la base de datos
USE Practic;
GO

-- Crear el usuario asociado al login
CREATE USER usr_vendedor
FOR LOGIN lg_vendedor;
GO

-- Crear el rol
CREATE ROLE rol_ventas;
GO

-- Otorgar permiso SELECT sobre las tres tablas
GRANT SELECT ON dbo.Clientes TO rol_ventas;
GRANT SELECT ON dbo.Productos TO rol_ventas;
GRANT SELECT ON dbo.Pedidos TO rol_ventas;
GO

-- Agregar el usuario al rol
ALTER ROLE rol_ventas
ADD MEMBER usr_vendedor;
GO