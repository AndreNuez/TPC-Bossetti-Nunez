/*drop database ECOMMERCE
go*/

create database ECOMMERCE
go

create table Generos (
	IdGenero smallint primary key identity (1,1),
	Descripcion varchar(1000)
)
go

create table Libros (
	Id smallint primary Key Identity (1,1),
	Titulo varchar (200) Not Null,
	Descripcion varchar(1000), 
	Autor varchar (200) Not Null,
	Editorial varchar (100) Not Null,
	Precio money Not Null Check(Precio > 0),
	Stock int Not Null Check (Stock >=0),
	IdGenero smallint Not Null foreign key references Generos(idGenero),
	Portada varchar (1000),
	Estado bit not null
	)
go

create table Administradores (
	IdAdministrador smallint primary key identity (1,1),
	Mail varchar(500) unique, 
	Contrase�a varchar (500) Not Null,
	Nombres varchar (50) Not Null,
	Apellidos varchar (50) Not Null
)
go

create table Clientes (
	IdCliente smallint primary key identity (1,1),
	Mail varchar(500) unique, 
	Contrase�a varchar (500) Not Null,
	Nombres varchar (100) Not Null,
	Apellidos varchar (100) Not Null,
	DNI varchar (50) not null unique,
	Telefono varchar (100), 
	Celular varchar (100),
	Calle varchar (100),
	Numero varchar (10),
	Piso varchar (10),
	Departamento varchar (10),
	CP varchar (10),
	Localidad varchar (100),
	Provincia varchar (100)
)
go


create table Carrito(
	IdCarrito smallint primary key identity (1,1),
	IdCliente smallint foreign key references Clientes (IdCliente)
)
go

create table Ventas(
	IdVenta smallint primary key identity (1,1),
	IdCarrito smallint foreign key references Carrito (IdCarrito),
	FormaPago varchar (100) not null,
	Fecha date not null,
	Estado varchar (100) not null
)
go

create procedure SP_librosListar as
select l.id, l.Titulo, l.Descripcion, l.Autor, l.Editorial, l.Precio, l.Stock, g.Descripcion as Genero, l.Portada, l.estado 
from Libros l
inner join Generos g on l.IdGenero = g.IdGenero
where l.Estado = 1
go
