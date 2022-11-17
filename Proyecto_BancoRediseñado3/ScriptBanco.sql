CREATE DATABASE Banco
go
USE Banco

go
CREATE TABLE TipoCuenta
(
id_cuenta int not null,
tipoCuenta varchar(70),
constraint pk_tipoCuenta primary key (id_cuenta)
)

go
CREATE TABLE Cliente
(
dni int not null,
nombre varchar(70),
apellido varchar(70),
constraint pk_cliente primary key (dni)
)

go
CREATE TABLE Cuenta
(
cbu bigint identity (1,1) not null,
saldo money,
id_cuenta int,
ultMov datetime,
dni int not null,
constraint pk_Cuenta primary key(cbu),
constraint fk_tipoCuenta foreign key (id_cuenta)
references TipoCuenta (id_cuenta),
constraint fk_Cliente foreign key (dni)
references Cliente (dni)
)

INSERT INTO TipoCuenta VALUES (1,'Caja de Ahoro')
INSERT INTO TipoCuenta VALUES (2, 'Cuenta Corriente')

