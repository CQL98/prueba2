use Plantilla
go
create procedure [dbo].[pa_cliente_listarTodos]
as
select [id_cliente]
	,[apellido]
      ,[nombre]
      ,[direccion]
	  ,[email]
      ,[fecha_nacimiento]
      ,[telefono]
      
from CLIENTE
go
create procedure [dbo].[pa_cliente_agregar]

@apellidos varchar(50),
@nombres varchar(50),
@direccion varchar(200),
@email varchar(50),
@fecha_nacimiento date,
@telefono varchar(10)
as
insert into cliente ([nombre]
           ,[apellido]
           ,[direccion]
           ,[fecha_nacimiento]
           ,[telefono]
           ,[email])
values
(@nombres,@apellidos,@direccion,@fecha_nacimiento,@telefono,@email)
GO
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
from Cliente where  apellido = '%'+@entrada+'%' or nombre = '%'+@entrada+'%'
