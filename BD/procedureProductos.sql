use Plantilla
go
create procedure [dbo].[pa_producto_listarTodos]
as
select [id_producto]

      ,[nombre]
      ,[precio]
	  ,[stock]
      ,[id_categoria]
      
from PRODUCTO
go
alter procedure [dbo].[pa_producto_agregar]

@nombre varchar(50),
@precio numeric(18,2),
@stock int,
@id_categoria int
as
insert into producto ([nombre]
           ,[precio]
           ,[stock]
           ,[id_categoria])
values
(@nombre ,@precio ,@stock,@id_categoria )


GO
create procedure [dbo].[pa_categoria_listarTodos]
as
select 
id_categoria, nombre,descripcion
from CATEGORIA



go


go







create procedure [dbo].[pa_producto_editar]
@codProducto int,
@nombre varchar(50),
@precio numeric(18,2),
@stock int,
@id_categoria int
as
update PRODUCTO
set nombre= @nombre,
precio= @precio ,
stock=@stock ,
id_categoria=@id_categoria 
where id_producto=@codProducto 
go

create procedure [dbo].[pa_producto_eliminar]
@id_producto int
as
DELETE FROM [dbo].[PRODUCTO]
      WHERE id_producto=@id_producto
go


create procedure [dbo].[pa_producto_buscar_x_nombres]
@entrada varchar(50)
as
select distinct [id_producto]

      ,[nombre]
      ,[precio]
	  ,[stock]
      ,[id_categoria]
      
from PRODUCTO where nombre like '%'+@entrada+'%'

go


create procedure [dbo].[pa_producto_buscar_x_codigo]
@codcliente int
as
select distinct [id_producto]

      ,[nombre]
      ,[precio]
	  ,[stock]
      ,[id_categoria]
      
from PRODUCTO where id_producto=@codcliente
