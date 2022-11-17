GO

CREATE PROC [dbo].[SP_tipoCuenta]
AS
Select * from TipoCuenta

GO

CREATE PROC [dbo].[SP_retirarDinero]
@cbu int,
@saldo money,
@ultMov datetime
As
update Cuenta
set saldo = saldo - @saldo, ultMov = @ultMov
where cbu = @cbu

GO

CREATE PROC [dbo].[SP_Reporte]
@estado char
as
SELECT c.dni 'DNI', nombre + ' ' + apellido 'Cliente' , tipocuenta, count(cbu) 'Cantidad'
FROM Cuenta cta join Cliente c on cta.dni = c.dni 
join TipoCuenta t on cta.id_cuenta = t.id_cuenta
where estado = @estado
Group By c.dni, nombre + ' ' + apellido , tipoCuenta

GO

CREATE PROC [dbo].[SP_lstCuentas]
AS
SELECT * FROM Cuenta

GO

CREATE PROC [dbo].[SP_lstClientes]
AS
SELECT * FROM Cliente

GO

CREATE PROC [dbo].[SP_insertCuenta]
@saldo money,
@tipoCuenta int, 
@ultMov datetime,
@dni int,
@estado char
AS
INSERT INTO Cuenta (saldo,id_cuenta,ultMov,dni,estado) VALUES (@saldo,@tipoCuenta,@ultMov,@dni,@estado)


GO

CREATE PROC [dbo].[SP_insertCliente]
@dni int,
@nombre varchar(60),
@apellido varchar(60)
AS
INSERT INTO Cliente (dni,nombre,apellido) VALUES (@dni,@nombre,@apellido)

GO

CREATE PROC [dbo].[SP_ingresarDinero]
@cbu int,
@saldo money,
@ultMov datetime
AS
update Cuenta
set saldo = (saldo + @saldo), ultMov = @ultMov
where cbu = @cbu

GO

CREATE PROC [dbo].[SP_deleteCuenta]
@cbu int 
as
DELETE Cuenta where cbu = @cbu

GO

CREATE Proc [dbo].[SP_cuentaTipo]
AS
select c.dni,cbu,saldo,tipoCuenta,ultMov
from Cuenta c join TipoCuenta t on c.id_cuenta = t.id_cuenta

GO

CREATE proc [dbo].[cargarCuentaCliente]
@dni int
AS
SELECT cbu,saldo,tipoCuenta,ultMov,estado 
FROM cuenta c join TipoCuenta t on c.id_cuenta = t.id_cuenta
WHERE dni = @dni;

GO


create proc [dbo].[cargarCliente]
@dni int 
as
select * from Cliente where dni = @dni

GO

Create Proc [dbo].[BajaLogica]
@cbu int,
@estado char
as
update Cuenta
set estado = @estado
where cbu = @cbu