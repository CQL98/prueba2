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







create procedure [dbo].[pa_cliente_editar]
@codcliente int,
@apellidos varchar(50),
@nombres varchar(50),
@direccion varchar(200),
@email varchar(50),
@fecha_nacimiento date,
@telefono varchar(10)
as
update CLIENTE 
set apellido=@apellidos,
nombre=@nombres,
direccion=@direccion,
email=@email,
fecha_nacimiento=@fecha_nacimiento,
telefono=@telefono
where id_cliente=@codcliente 
go

create procedure [dbo].[pa_cliente_eliminar]
@codcliente int
as
DELETE FROM [dbo].[CLIENTE]
      WHERE id_cliente=@codcliente
go
create procedure [dbo].[pa_cliente_buscar_x_nombres]
@entrada varchar(50)
as
select distinct [id_cliente]
	,[apellido]
      ,[nombre]
      ,[direccion]
	  ,[email]
      ,[fecha_nacimiento]
      ,[telefono]
from Cliente where  (apellido like '%'+@entrada+'%') or (nombre like '%'+@entrada+'%')
go
create procedure [dbo].[pa_cliente_buscar_x_codigo]
@codcliente int
as
select distinct [id_cliente]
	,[apellido]
      ,[nombre]
      ,[direccion]
	  ,[email]
      ,[fecha_nacimiento]
      ,[telefono]
from Cliente where id_cliente=@codcliente
