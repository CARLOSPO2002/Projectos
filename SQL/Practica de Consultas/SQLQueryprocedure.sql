create procedure ConsultarData
@primnom varchar(50),
@primape varchar(50)
as
begin
select*from EMPLEADOS
where PrimerApe=@primape or PrimerNom=@primnom
end
exec ConsultarData 'carlos','perez';
select*from EMPLEADOS
exec ConsultarData 'jua','';