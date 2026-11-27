create procedure EliminarEmpleado
@idem int
as
begin
delete from EMPLEADOS
where IDempleado=@idem
end;
go
