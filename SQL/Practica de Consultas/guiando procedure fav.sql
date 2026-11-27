select*from FAVORITOS
go
CREATE PROCEDURE FAV
@us int
as
begin
select C.NOMBRE,C.CATEGORIA from FAVORITOS f
inner join CONTENIDO C
on f.ID_CONTENIDO=C.ID_CONTENIDO
where f.ID_USUARIO=@us

end;