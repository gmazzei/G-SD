--Inicial

/*
Borrado de esquema y entidades, en el caso de que existan.
Esto es para facilitar el trabajo si quisiera ejecutar nuevamente el script.
*/

IF OBJECT_ID('SENIOR_DEVELOPERS.V_ClientePuntos') IS NOT NULL
	DROP VIEW SENIOR_DEVELOPERS.V_ClientePuntos
IF OBJECT_ID('SENIOR_DEVELOPERS.V_DestinoPasajeCancelado') IS NOT NULL
  DROP VIEW SENIOR_DEVELOPERS.V_DestinoPasajeCancelado
IF OBJECT_ID('SENIOR_DEVELOPERS.V_MicrosDiasFueraDeServicio') IS NOT NULL
  DROP VIEW SENIOR_DEVELOPERS.V_MicrosDiasFueraDeServicio
IF OBJECT_ID('SENIOR_DEVELOPERS.V_MicrosPorcentajeLleno') IS NOT NULL
  DROP VIEW SENIOR_DEVELOPERS.V_MicrosPorcentajeLleno
IF OBJECT_ID('SENIOR_DEVELOPERS.V_DestinosPasajes') IS NOT NULL
  DROP VIEW SENIOR_DEVELOPERS.V_DestinosPasajes
IF OBJECT_ID('SENIOR_DEVELOPERS.V_ComprasMigracion') IS NOT NULL
  DROP VIEW SENIOR_DEVELOPERS.V_ComprasMigracion
IF OBJECT_ID('SENIOR_DEVELOPERS.V_PuntosClientesALaFecha') IS NOT NULL
  DROP VIEW SENIOR_DEVELOPERS.V_PuntosClientesALaFecha
IF OBJECT_ID('SENIOR_DEVELOPERS.V_ClientePasajeEncomienda') IS NOT NULL
  DROP VIEW SENIOR_DEVELOPERS.V_ClientePasajeEncomienda
IF OBJECT_ID('SENIOR_DEVELOPERS.Butaca', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Butaca
IF OBJECT_ID('SENIOR_DEVELOPERS.RegistroMicroFueraServicio', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.RegistroMicroFueraServicio
IF OBJECT_ID('SENIOR_DEVELOPERS.Canje', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Canje
IF OBJECT_ID('SENIOR_DEVELOPERS.Producto', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Producto
IF OBJECT_ID('SENIOR_DEVELOPERS.CancelacionPasaje', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.CancelacionPasaje
IF OBJECT_ID('SENIOR_DEVELOPERS.CancelacionEncomienda', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.CancelacionEncomienda
IF OBJECT_ID('SENIOR_DEVELOPERS.Cancelacion', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Cancelacion
 IF OBJECT_ID('SENIOR_DEVELOPERS.Pasaje', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Pasaje
IF OBJECT_ID('SENIOR_DEVELOPERS.Encomienda', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Encomienda
IF OBJECT_ID('SENIOR_DEVELOPERS.RegistroCompra', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.RegistroCompra
IF OBJECT_ID('SENIOR_DEVELOPERS.TarjetaCredito', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.TarjetaCredito
IF OBJECT_ID('SENIOR_DEVELOPERS.Usuario', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Usuario
IF OBJECT_ID('SENIOR_DEVELOPERS.Viaje', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Viaje
IF OBJECT_ID('SENIOR_DEVELOPERS.Micro', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Micro
IF OBJECT_ID('SENIOR_DEVELOPERS.Recorrido', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Recorrido
IF OBJECT_ID('SENIOR_DEVELOPERS.Servicio', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Servicio
IF OBJECT_ID('SENIOR_DEVELOPERS.Ciudad', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Ciudad
IF OBJECT_ID('SENIOR_DEVELOPERS.Cliente', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Cliente
IF OBJECT_ID('SENIOR_DEVELOPERS.Rol_Funcionalidad', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Rol_Funcionalidad
IF OBJECT_ID('SENIOR_DEVELOPERS.Rol', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Rol
IF OBJECT_ID('SENIOR_DEVELOPERS.Funcionalidad', 'U') IS NOT NULL
  DROP TABLE SENIOR_DEVELOPERS.Funcionalidad


IF (SELECT schema_name FROM information_schema.schemata WHERE schema_name = 'SENIOR_DEVELOPERS') IS NOT NULL
	DROP SCHEMA SENIOR_DEVELOPERS

GO


--Creacion de Entidades

/*
Nota: Debo poner algunas constraints como NOT NULL en esta parte del script 
	  porque, de no hacerlo, no podría asignar PRIMARY KEY dichas columnas
	  en el paso siguiente.
*/


CREATE SCHEMA [SENIOR_DEVELOPERS] AUTHORIZATION [dbo]
GO

CREATE TABLE SENIOR_DEVELOPERS.Rol (ID INT IDENTITY NOT NULL, nombre NVARCHAR(255), habilitado NVARCHAR(2) NOT NULL DEFAULT 'Si')

CREATE TABLE SENIOR_DEVELOPERS.Rol_Funcionalidad (rol_ID INT NOT NULL, funcionalidad_ID INT NOT NULL)

CREATE TABLE SENIOR_DEVELOPERS.Funcionalidad (ID INT IDENTITY NOT NULL, Nombre NVARCHAR(255))


CREATE TABLE SENIOR_DEVELOPERS.Usuario (username NVARCHAR(255) NOT NULL, password NVARCHAR(255), habilitado NVARCHAR(2), rol_ID INT, intentosFallidos INT)


CREATE TABLE SENIOR_DEVELOPERS.Cliente (DNI NUMERIC(18,0) NOT NULL, nombre NVARCHAR(255), apellido NVARCHAR(255), genero NVARCHAR(1), direccion NVARCHAR(255), telefono NUMERIC(18,0), mail NVARCHAR(255), fechaNacimiento DATETIME, esDiscapacitado NVARCHAR(2),  puntos INT)


CREATE TABLE SENIOR_DEVELOPERS.Producto (ID INT IDENTITY, nombre NVARCHAR(255), puntosNecesarios INT, stock INT)

CREATE TABLE SENIOR_DEVELOPERS.Canje (ID INT IDENTITY, cliente_DNI NUMERIC(18,0), producto_ID INT, cantidad INT, fecha DATETIME)


CREATE TABLE SENIOR_DEVELOPERS.TarjetaCredito (NRO NUMERIC(18,0) NOT NULL, cliente_DNI NUMERIC(18,0), codigoSeguridad NVARCHAR(10), fechaVencimiento NUMERIC(4,0), tipo NVARCHAR(255))


CREATE TABLE SENIOR_DEVELOPERS.Ciudad (ID INT IDENTITY, nombre VARCHAR(255))

CREATE TABLE SENIOR_DEVELOPERS.Recorrido (ID NUMERIC(18,0) NOT NULL, ciudadOrigen_ID INT, ciudadDestino_ID INT, tipoServicio NVARCHAR(255), precioBasePasaje NUMERIC(18,2), precioBaseKG NUMERIC(18,2), habilitado NVARCHAR(2) NOT NULL DEFAULT 'Si')

CREATE TABLE SENIOR_DEVELOPERS.Servicio (nombre NVARCHAR(255) NOT NULL, porcentajeAdicional NUMERIC (18,2))

CREATE TABLE SENIOR_DEVELOPERS.Viaje (ID INT IDENTITY NOT NULL, recorrido_ID NUMERIC(18,0), micro_patente NVARCHAR(255), fechaSalida DATETIME, fechaLlegadaEstimada DATETIME, fechaLlegada DATETIME, estado NVARCHAR(255))


CREATE TABLE SENIOR_DEVELOPERS.Pasaje(ID NUMERIC(18,0) NOT NULL, viaje_ID INT, cliente_DNI NUMERIC(18,0), precio NUMERIC(18,2), compra_NRO INT, butaca_NRO NUMERIC(18,0))

CREATE TABLE SENIOR_DEVELOPERS.Encomienda(ID NUMERIC(18,0) NOT NULL, viaje_ID INT, cliente_DNI NUMERIC(18,0), precio NUMERIC(18,2), compra_NRO INT, KG NUMERIC(18,0))


CREATE TABLE SENIOR_DEVELOPERS.RegistroCompra(NRO INT IDENTITY, cliente_DNI NUMERIC(18,0), fecha DATETIME, medioPago NVARCHAR(255))


CREATE TABLE SENIOR_DEVELOPERS.Cancelacion (ID INT IDENTITY NOT NULL, fecha DATETIME, compra_NRO INT, motivo NVARCHAR(255))

CREATE TABLE SENIOR_DEVELOPERS.CancelacionPasaje (cancelacion_ID INT NOT NULL, pasaje_ID NUMERIC(18,0) NOT NULL, viaje_ID INT, cliente_DNI NUMERIC(18,0), precio NUMERIC(18,2), compra_NRO INT, butaca_NRO NUMERIC(18,0))
CREATE TABLE SENIOR_DEVELOPERS.CancelacionEncomienda (cancelacion_ID INT NOT NULL, encomienda_ID NUMERIC(18,0) NOT NULL, viaje_ID INT, cliente_DNI NUMERIC(18,0), precio NUMERIC(18,2), compra_NRO INT, KG NUMERIC(18,0))

CREATE TABLE SENIOR_DEVELOPERS.Micro (patente NVARCHAR(255) NOT NULL, nro INT, marca NVARCHAR(255), modelo NVARCHAR(255), tipoServicio NVARCHAR(255), bajaFueraServicio NVARCHAR(2), bajaVidaUtil NVARCHAR(2), cantidadButacas INT, KGDisponibles NUMERIC(18,0), fechaAlta DATE, fechaFueraServicio DATE, fechaReinicioServicio DATE, fechaBajaDefinitiva DATE)

CREATE TABLE SENIOR_DEVELOPERS.Butaca (NRO NUMERIC(18,0) NOT NULL, micro_patente NVARCHAR(255) NOT NULL, piso NUMERIC(18,0), tipo NVARCHAR(255))

CREATE TABLE SENIOR_DEVELOPERS.RegistroMicroFueraServicio (micro_patente NVARCHAR(255) NOT NULL, fecha DATETIME NOT NULL, fechaReinicio DATETIME)
GO


/*Creacion de Vistas*/

CREATE VIEW SENIOR_DEVELOPERS.V_ClientePasajeEncomienda AS
SELECT cliente_DNI, precio, CAST(precio/5 AS INT) AS puntos, fechaLlegada AS fecha 
FROM SENIOR_DEVELOPERS.Pasaje P INNER JOIN SENIOR_DEVELOPERS.Viaje V ON P.viaje_ID = V.ID
UNION
SELECT cliente_DNI, precio, CAST(precio/5 AS INT) AS puntos, fechaLlegada AS fecha 
FROM SENIOR_DEVELOPERS.Encomienda E INNER JOIN SENIOR_DEVELOPERS.Viaje V ON E.viaje_ID = V.ID
GO


CREATE VIEW SENIOR_DEVELOPERS.V_PuntosClientesALaFecha AS
(SELECT cliente_DNI, SUM(puntos) AS puntos FROM SENIOR_DEVELOPERS.V_ClientePasajeEncomienda
WHERE fecha > DATEADD(YEAR, -1, GETDATE())
GROUP BY cliente_DNI)
UNION
(SELECT C.cliente_DNI, ISNULL(SUM(0 - C.cantidad * P.puntosNecesarios), 0) AS puntos FROM SENIOR_DEVELOPERS.Canje C INNER JOIN SENIOR_DEVELOPERS.Producto P ON P.ID = C.producto_ID
WHERE C.fecha > DATEADD(YEAR, -1, GETDATE())
GROUP BY C.cliente_DNI)
GO

CREATE VIEW SENIOR_DEVELOPERS.V_ComprasMigracion AS
(SELECT DISTINCT Cli_Dni, Pasaje_FechaCompra AS fechaCompra, 'Efectivo' AS TipoPago
FROM gd_esquema.Maestra
UNION
SELECT DISTINCT Cli_Dni, Paquete_FechaCompra AS fechaCompra, 'Efectivo' AS TipoPago
FROM gd_esquema.Maestra)
GO



/* Vistas especiales para Listados Estadisticos*/

CREATE VIEW SENIOR_DEVELOPERS.V_ClientePuntos AS
SELECT cliente_DNI, fecha, puntos
FROM SENIOR_DEVELOPERS.V_ClientePasajeEncomienda
UNION
SELECT cliente_DNI, fecha,0 - (P.puntosNecesarios * C.cantidad) AS puntos
FROM SENIOR_DEVELOPERS.Canje C INNER JOIN SENIOR_DEVELOPERS.Producto P ON P.ID = producto_ID
GO


/*
CREATE VIEW SENIOR_DEVELOPERS.V_DestinosPasajes AS
SELECT C.nombre AS Destino, RC.fecha AS Fecha
FROM SENIOR_DEVELOPERS.Pasaje P
INNER JOIN SENIOR_DEVELOPERS.RegistroCompra RC ON P.compra_NRO = RC.NRO 
INNER JOIN SENIOR_DEVELOPERS.Viaje V ON V.ID = P.viaje_ID
INNER JOIN SENIOR_DEVELOPERS.Recorrido R ON R.ID = V.recorrido_ID
INNER JOIN SENIOR_DEVELOPERS.Ciudad C ON C.ID = R.ciudadDestino_ID
GO


CREATE VIEW SENIOR_DEVELOPERS.V_MicrosPorcentajeLleno AS
SELECT V.ID AS viajeID, C.nombre AS Destino, V.fechaLlegada AS Fecha, M.patente AS Micro, CONVERT(NUMERIC(5,2), COUNT(*))*100/M.cantidadButacas AS 'Porcentaje lleno'
FROM SENIOR_DEVELOPERS.Pasaje P
INNER JOIN SENIOR_DEVELOPERS.RegistroCompra RC ON P.compra_NRO = RC.NRO 
INNER JOIN SENIOR_DEVELOPERS.Viaje V ON V.ID = P.viaje_ID
INNER JOIN SENIOR_DEVELOPERS.Micro M ON V.micro_patente = M.patente
INNER JOIN SENIOR_DEVELOPERS.Recorrido R ON R.ID = V.recorrido_ID
INNER JOIN SENIOR_DEVELOPERS.Ciudad C ON C.ID = R.ciudadDestino_ID
GROUP BY V.ID, C.nombre, V.fechaLlegada, M.patente, M.cantidadButacas
GO


CREATE VIEW SENIOR_DEVELOPERS.V_DestinoPasajeCancelado AS
SELECT C.nombre AS Destino, CA.fecha AS Fecha
FROM SENIOR_DEVELOPERS.CancelacionPasaje CP
INNER JOIN SENIOR_DEVELOPERS.Cancelacion CA ON CA.ID = CP.cancelacion_ID 
INNER JOIN SENIOR_DEVELOPERS.Viaje V ON V.ID = CP.viaje_ID
INNER JOIN SENIOR_DEVELOPERS.Recorrido R ON R.ID = V.recorrido_ID
INNER JOIN SENIOR_DEVELOPERS.Ciudad C ON C.ID = R.ciudadDestino_ID
GO


CREATE VIEW SENIOR_DEVELOPERS.V_MicrosDiasFueraDeServicio AS
SELECT micro_patente AS Micro, fecha, DATEDIFF(DAY, fecha, fechaReinicio) AS 'Cantidad de dias fuera de servicio'
FROM SENIOR_DEVELOPERS.RegistroMicroFueraServicio
GO
*/


--Creacion de Claves primarias y foraneas


ALTER TABLE SENIOR_DEVELOPERS.Rol
ADD PRIMARY KEY (ID)

ALTER TABLE SENIOR_DEVELOPERS.Funcionalidad
ADD PRIMARY KEY (ID)

ALTER TABLE SENIOR_DEVELOPERS.Rol_Funcionalidad
ADD PRIMARY KEY (rol_ID, funcionalidad_ID)

ALTER TABLE SENIOR_DEVELOPERS.Usuario
ADD PRIMARY KEY (username)

ALTER TABLE SENIOR_DEVELOPERS.Cliente
ADD PRIMARY KEY (DNI)
 
ALTER TABLE SENIOR_DEVELOPERS.Producto
ADD PRIMARY KEY (ID)

ALTER TABLE SENIOR_DEVELOPERS.Canje
ADD PRIMARY KEY (ID)

ALTER TABLE SENIOR_DEVELOPERS.TarjetaCredito
ADD PRIMARY KEY (NRO)

ALTER TABLE SENIOR_DEVELOPERS.Ciudad
ADD PRIMARY KEY (ID)

ALTER TABLE SENIOR_DEVELOPERS.Recorrido
ADD PRIMARY KEY (ID)

ALTER TABLE SENIOR_DEVELOPERS.Servicio
ADD PRIMARY KEY (nombre)

ALTER TABLE SENIOR_DEVELOPERS.Viaje
ADD PRIMARY KEY (ID)

ALTER TABLE SENIOR_DEVELOPERS.Pasaje
ADD PRIMARY KEY (ID)

ALTER TABLE SENIOR_DEVELOPERS.Encomienda
ADD PRIMARY KEY (ID)

ALTER TABLE SENIOR_DEVELOPERS.RegistroCompra
ADD PRIMARY KEY (NRO)

ALTER TABLE SENIOR_DEVELOPERS.Cancelacion
ADD PRIMARY KEY (ID)

ALTER TABLE SENIOR_DEVELOPERS.CancelacionPasaje
ADD PRIMARY KEY (cancelacion_ID, pasaje_ID)

ALTER TABLE SENIOR_DEVELOPERS.CancelacionEncomienda
ADD PRIMARY KEY (cancelacion_ID, encomienda_ID)

ALTER TABLE SENIOR_DEVELOPERS.Micro
ADD PRIMARY KEY (patente)

ALTER TABLE SENIOR_DEVELOPERS.Butaca
ADD PRIMARY KEY (NRO, micro_patente)

ALTER TABLE SENIOR_DEVELOPERS.RegistroMicroFueraServicio
ADD PRIMARY KEY (micro_patente, fecha)


ALTER TABLE SENIOR_DEVELOPERS.Rol_Funcionalidad
ADD FOREIGN KEY (rol_ID)
REFERENCES SENIOR_DEVELOPERS.Rol(ID)

ALTER TABLE SENIOR_DEVELOPERS.Rol_Funcionalidad
ADD FOREIGN KEY (funcionalidad_ID)
REFERENCES SENIOR_DEVELOPERS.Funcionalidad(ID)

ALTER TABLE SENIOR_DEVELOPERS.Rol_Funcionalidad
ADD FOREIGN KEY (rol_ID)
REFERENCES SENIOR_DEVELOPERS.Rol(ID)

ALTER TABLE SENIOR_DEVELOPERS.Usuario
ADD FOREIGN KEY (rol_ID)
REFERENCES SENIOR_DEVELOPERS.Rol(ID)

ALTER TABLE SENIOR_DEVELOPERS.Canje
ADD FOREIGN KEY (producto_ID)
REFERENCES SENIOR_DEVELOPERS.Producto(ID)

ALTER TABLE SENIOR_DEVELOPERS.TarjetaCredito
ADD FOREIGN KEY (cliente_DNI)
REFERENCES SENIOR_DEVELOPERS.Cliente(DNI)

ALTER TABLE SENIOR_DEVELOPERS.Recorrido
ADD FOREIGN KEY (ciudadOrigen_ID)
REFERENCES SENIOR_DEVELOPERS.Ciudad(ID)

ALTER TABLE SENIOR_DEVELOPERS.Recorrido
ADD FOREIGN KEY (ciudadDestino_ID)
REFERENCES SENIOR_DEVELOPERS.Ciudad(ID)

ALTER TABLE SENIOR_DEVELOPERS.Viaje
ADD FOREIGN KEY (recorrido_ID)
REFERENCES SENIOR_DEVELOPERS.Recorrido(ID) 
ON UPDATE CASCADE

ALTER TABLE SENIOR_DEVELOPERS.Viaje
ADD FOREIGN KEY (micro_patente)
REFERENCES SENIOR_DEVELOPERS.Micro(patente)
ON UPDATE CASCADE

ALTER TABLE SENIOR_DEVELOPERS.Pasaje
ADD FOREIGN KEY (viaje_ID)
REFERENCES SENIOR_DEVELOPERS.Viaje(ID)

ALTER TABLE SENIOR_DEVELOPERS.Pasaje
ADD FOREIGN KEY (cliente_DNI)
REFERENCES SENIOR_DEVELOPERS.Cliente(DNI)
ON UPDATE CASCADE

ALTER TABLE SENIOR_DEVELOPERS.Pasaje
ADD FOREIGN KEY (compra_NRO)
REFERENCES SENIOR_DEVELOPERS.RegistroCompra(NRO)

ALTER TABLE SENIOR_DEVELOPERS.Encomienda
ADD FOREIGN KEY (viaje_ID)
REFERENCES SENIOR_DEVELOPERS.Viaje(ID)

ALTER TABLE SENIOR_DEVELOPERS.Encomienda
ADD FOREIGN KEY (cliente_DNI)
REFERENCES SENIOR_DEVELOPERS.Cliente(DNI)
ON UPDATE CASCADE

ALTER TABLE SENIOR_DEVELOPERS.Encomienda
ADD FOREIGN KEY (compra_NRO)
REFERENCES SENIOR_DEVELOPERS.RegistroCompra(NRO)

ALTER TABLE SENIOR_DEVELOPERS.RegistroCompra
ADD FOREIGN KEY (cliente_DNI)
REFERENCES SENIOR_DEVELOPERS.Cliente(DNI)
ON UPDATE CASCADE

ALTER TABLE SENIOR_DEVELOPERS.Cancelacion
ADD FOREIGN KEY (compra_NRO)
REFERENCES SENIOR_DEVELOPERS.RegistroCompra(NRO)

ALTER TABLE SENIOR_DEVELOPERS.CancelacionPasaje
ADD FOREIGN KEY (cancelacion_ID)
REFERENCES SENIOR_DEVELOPERS.Cancelacion(ID)

ALTER TABLE SENIOR_DEVELOPERS.CancelacionEncomienda
ADD FOREIGN KEY (cancelacion_ID)
REFERENCES SENIOR_DEVELOPERS.Cancelacion(ID)

ALTER TABLE SENIOR_DEVELOPERS.Micro
ADD FOREIGN KEY (tipoServicio)
REFERENCES SENIOR_DEVELOPERS.Servicio(nombre)

ALTER TABLE SENIOR_DEVELOPERS.Butaca
ADD FOREIGN KEY (micro_patente)
REFERENCES SENIOR_DEVELOPERS.Micro(patente)
ON UPDATE CASCADE

ALTER TABLE SENIOR_DEVELOPERS.RegistroMicroFueraServicio
ADD FOREIGN KEY (micro_patente)
REFERENCES SENIOR_DEVELOPERS.Micro(patente)
ON UPDATE CASCADE


--Constraints

ALTER TABLE SENIOR_DEVELOPERS.Rol ADD UNIQUE (nombre)
ALTER TABLE SENIOR_DEVELOPERS.Ciudad ADD UNIQUE (nombre)
GO


--Triggers

/*
Cancelar todos los viajes que tengan un determinado ID de recorrido
*/
create trigger SENIOR_DEVELOPERS.tr_bajaRecorrido on SENIOR_DEVELOPERS.Recorrido 
for update as
begin

	update SENIOR_DEVELOPERS.Viaje
	set	estado = 'Cancelado'
	where recorrido_ID in (select ID from inserted where habilitado = 'No')
	
end
GO


/*
Cancelar todos los pasajes y encomiendas con este ID de viaje
*/
create trigger SENIOR_DEVELOPERS.tr_cancelacionViaje on SENIOR_DEVELOPERS.Viaje 
for update as 
BEGIN
	set nocount on;
	if (select top 1 estado FROM inserted) = 'Cancelado'
	begin
		
		insert into SENIOR_DEVELOPERS.Cancelacion
		(fecha, compra_NRO, motivo)
		select GETDATE(), p.compra_NRO, 'Viaje cancelado' from SENIOR_DEVELOPERS.Pasaje p
		where viaje_ID IN (select ID from inserted)
		
		insert into SENIOR_DEVELOPERS.CancelacionPasaje
		(cancelacion_ID, pasaje_ID, viaje_ID, cliente_DNI, compra_NRO, precio, butaca_NRO)
		select c.ID, p.ID, p.viaje_ID, p.cliente_DNI, p.compra_NRO, p.precio, p.butaca_NRO 
		from SENIOR_DEVELOPERS.Pasaje p, SENIOR_DEVELOPERS.Cancelacion c
		where p.compra_NRO = c.compra_NRO
		AND p.viaje_ID in (select ID from inserted)
		
		delete from SENIOR_DEVELOPERS.Pasaje
		where ID IN (select pasaje_ID from SENIOR_DEVELOPERS.CancelacionPasaje);
		
		
		insert into SENIOR_DEVELOPERS.Cancelacion
		(fecha, compra_NRO, motivo)
		select GETDATE(), compra_NRO, 'Viaje cancelado' FROM SENIOR_DEVELOPERS.Encomienda
		where viaje_ID IN (select ID from inserted);
		
		insert into SENIOR_DEVELOPERS.CancelacionEncomienda
		(cancelacion_ID, encomienda_ID, viaje_ID, cliente_DNI, compra_NRO, KG)
		select c.ID, e.ID, e.viaje_ID, e.cliente_DNI, e.compra_NRO, e.KG 
		from SENIOR_DEVELOPERS.Encomienda e, SENIOR_DEVELOPERS.Cancelacion c
		where e.compra_NRO = c.compra_NRO
		AND e.viaje_ID IN (select ID from inserted)
		
		delete from SENIOR_DEVELOPERS.Encomienda
		where ID in (select encomienda_ID  from SENIOR_DEVELOPERS.CancelacionEncomienda);
	end
end
GO

		
create trigger SENIOR_DEVELOPERS.tr_deshabilitarRol on SENIOR_DEVELOPERS.Rol
for update as --Se inhabilitan todos los usuario con este Rol
begin
	if ((select habilitado from inserted) = 'No')
	begin
		declare @rol_ID int
		select @rol_ID = ID from inserted
	
		update SENIOR_DEVELOPERS.Usuario
		set
			habilitado = 'No'
		where rol_ID = @rol_ID;
	end
end
GO

CREATE TRIGGER SENIOR_DEVELOPERS.tr_canjeProducto ON SENIOR_DEVELOPERS.Canje
FOR INSERT AS --Se reduce el stock del producto
BEGIN
	DECLARE @producto_ID INT
	DECLARE @cantidadComprada INT
	
	SELECT @producto_ID = producto_ID FROM inserted
	SELECT @cantidadComprada = cantidad FROM inserted
	
	UPDATE SENIOR_DEVELOPERS.Producto
	SET
		stock -= @cantidadComprada
	WHERE ID = @producto_ID
END
GO

/*Si un micro pasa a estar fuera de servicio se guarda el rango de fechas*/
create trigger tr_microFueraServicio on SENIOR_DEVELOPERS.Micro
for update as
begin
	
	insert into SENIOR_DEVELOPERS.RegistroMicroFueraServicio
	(micro_patente, fecha, fechaReinicio)
	select patente, fechaFueraServicio, fechaReinicioServicio from inserted
	where fechaFueraServicio IS NOT NULL AND fechaReinicioServicio IS NOT NULL
	AND fechaFueraServicio not in (select fecha from SENIOR_DEVELOPERS.RegistroMicroFueraServicio where micro_patente = patente)
	
end
GO

/*
create trigger SENIOR_DEVELOPERS.tr_deshabilitarUsuario on SENIOR_DEVELOPERS.Usuario
for update as --Si se equivoca 3 veces, es inhabilitado
begin

	declare @username nvarchar(255)
	declare @intentosFallidos int

	declare cursorUsuario cursor for
	select username, intentosFallidos from inserted
	
	open cursorUsuario
	fetch next from cursorUsuario into @username, @intentosFallidos
	
	while (@@FETCH_STATUS = 0)
	begin
	
		if (@intentosFallidos >= 3)
		begin
			
			update SENIOR_DEVELOPERS.Usuario
			set habilitado = 'No'
			where username = @username
			
		end	
		
		fetch next from cursorUsuario into @username, @intentosFallidos
		
	end
	
	close cursorUsuario
	deallocate cursorUsuario
	
end
GO
*/



--Migracion de datos


/*Cliente*/
INSERT INTO SENIOR_DEVELOPERS.Cliente
(DNI, apellido, nombre, genero, direccion, telefono, mail, fechaNacimiento, esDiscapacitado, puntos)
SELECT DISTINCT 
	Cli_Dni, 
	Cli_Apellido, 
	Cli_Nombre, 
	NULL, 
	Cli_Dir, 
	Cli_Telefono, 
	Cli_Mail, 
	Cli_Fecha_Nac, 
	'No', 
	0
FROM gd_esquema.Maestra


/*Ciudad*/
INSERT INTO SENIOR_DEVELOPERS.Ciudad
(nombre)
SELECT DISTINCT Recorrido_Ciudad_Origen
FROM gd_esquema.Maestra


/*Tipos de Servicio*/
INSERT INTO SENIOR_DEVELOPERS.Servicio
(nombre)
SELECT DISTINCT Tipo_Servicio
FROM gd_esquema.Maestra

UPDATE SENIOR_DEVELOPERS.Servicio SET porcentajeAdicional = 1.6 WHERE nombre = 'Cama'
UPDATE SENIOR_DEVELOPERS.Servicio SET porcentajeAdicional = 1.4 WHERE nombre = 'Semi-Cama'
UPDATE SENIOR_DEVELOPERS.Servicio SET porcentajeAdicional = 1.8 WHERE nombre = 'Premium'
UPDATE SENIOR_DEVELOPERS.Servicio SET porcentajeAdicional = 2	WHERE nombre = 'Ejecutivo'
UPDATE SENIOR_DEVELOPERS.Servicio SET porcentajeAdicional = 1.2 WHERE nombre = 'Común'



/*Recorrido*/

DECLARE @recorridoPasaje TABLE (ID NUMERIC(18,0), precioBasePasaje NUMERIC(18,2))
DECLARE @recorridoEncomienda TABLE (ID NUMERIC(18,0), precioBaseKG NUMERIC(18,2))


INSERT INTO @recorridoPasaje
(ID, precioBasePasaje)
SELECT DISTINCT 
		Recorrido_Codigo, 
		Recorrido_Precio_BasePasaje
FROM gd_esquema.Maestra
WHERE Recorrido_Precio_BasePasaje != 0

INSERT INTO @recorridoEncomienda
(ID, precioBaseKG)
SELECT DISTINCT 
		Recorrido_Codigo, 
		Recorrido_Precio_BaseKG
FROM gd_esquema.Maestra
WHERE Recorrido_Precio_BaseKG != 0

INSERT INTO SENIOR_DEVELOPERS.Recorrido
(ID, ciudadOrigen_ID, ciudadDestino_ID, tipoServicio, precioBasePasaje, precioBaseKG, habilitado)
SELECT DISTINCT 
	m.Recorrido_Codigo, 
	c1.ID, 
	c2.ID, 
	m.Tipo_Servicio, 
	rPas.precioBasePasaje, 
	rEnc.precioBaseKG, 
	'Si'
FROM 
	gd_esquema.Maestra m, 
	@recorridoEncomienda rEnc, 
	@recorridoPasaje rPas, 
	SENIOR_DEVELOPERS.Ciudad c1, 
	SENIOR_DEVELOPERS.Ciudad c2
WHERE 
	c1.nombre = m.Recorrido_Ciudad_Origen 
	AND c2.nombre = m.Recorrido_Ciudad_Destino
	AND rEnc.ID = m.Recorrido_Codigo
	AND rPas.ID = m.Recorrido_Codigo




/*Micro*/

INSERT INTO SENIOR_DEVELOPERS.Micro
(patente, marca, modelo, tipoServicio, cantidadButacas, KGDisponibles, fechaAlta, fechaFueraServicio, fechaReinicioServicio, fechaBajaDefinitiva, bajaFueraServicio ,bajaVidaUtil)
SELECT DISTINCT 
		m.Micro_Patente, 
		m.Micro_Marca, 
		m.Micro_Modelo, 
		m.Tipo_Servicio, 
		(SELECT (MAX(Butaca_Nro)+1) FROM gd_esquema.Maestra m2 WHERE m2.Micro_Patente = m.Micro_Patente GROUP BY Micro_Patente), 
		m.Micro_KG_Disponibles, 
		DATEADD(YEAR, -5, CAST(GETDATE() AS SMALLDATETIME)), 
		NULL, 
		NULL, 
		NULL, 
		'No', 
		'No'
FROM gd_esquema.Maestra m

DECLARE @id INT
SET @id = 0
UPDATE SENIOR_DEVELOPERS.Micro
SET @id = nro = @id + 1

/* Viaje */

INSERT INTO SENIOR_DEVELOPERS.Viaje
(fechaSalida, fechaLlegada, fechaLlegadaEstimada, recorrido_ID, micro_patente, estado)
SELECT DISTINCT 
		m.FechaSalida, 
		m.FechaLLegada, 
		m.Fecha_LLegada_Estimada, 
		m.Recorrido_Codigo, 
		m.Micro_Patente, 
		'Vigente'
FROM gd_esquema.Maestra m




/*Registro de Compras*/

INSERT INTO SENIOR_DEVELOPERS.RegistroCompra
(cliente_DNI, fecha, medioPago)
SELECT DISTINCT Cli_Dni, fechaCompra, TipoPago
FROM SENIOR_DEVELOPERS.V_ComprasMigracion



/*Pasajes y Encomiendas*/

INSERT INTO SENIOR_DEVELOPERS.Pasaje
(ID, cliente_DNI, viaje_ID, precio, butaca_NRO, compra_NRO)
SELECT 
	m.Pasaje_Codigo, 
	m.Cli_Dni, 
	v.ID, 
	m.Pasaje_Precio, 
	m.Butaca_Nro, 
	r.NRO
FROM 
	gd_esquema.Maestra m, 
	SENIOR_DEVELOPERS.Viaje v, 
	SENIOR_DEVELOPERS.RegistroCompra r
WHERE 
	m.Pasaje_Codigo != 0
	AND m.Recorrido_Codigo = v.recorrido_ID
	AND m.Micro_Patente = v.Micro_Patente
	AND m.FechaSalida = v.fechaSalida
	AND m.Cli_Dni = r.cliente_DNI
	AND m.Pasaje_FechaCompra = r.fecha


INSERT INTO SENIOR_DEVELOPERS.Encomienda
(ID, cliente_DNI, viaje_ID, precio, KG, compra_NRO)
SELECT 
		m.Paquete_Codigo, 
		m.Cli_Dni, 
		v.ID, 
		m.Paquete_Precio, 
		m.Paquete_KG, 
		r.NRO
FROM 
	gd_esquema.Maestra m, 
	SENIOR_DEVELOPERS.Viaje v, 
	SENIOR_DEVELOPERS.RegistroCompra r
WHERE 
	m.Paquete_Codigo != 0
	AND m.Recorrido_Codigo = v.recorrido_ID
	AND m.Micro_Patente = v.Micro_Patente
	AND m.FechaSalida = v.fechaSalida
	AND m.Cli_Dni = r.cliente_DNI
	AND m.Paquete_FechaCompra = r.fecha


/* Butaca */

INSERT INTO SENIOR_DEVELOPERS.Butaca
(NRO, micro_patente, piso, tipo)
SELECT DISTINCT Butaca_Nro, Micro_Patente, Butaca_Piso, Butaca_Tipo
FROM gd_esquema.Maestra
WHERE Pasaje_Codigo != 0



/* Datos iniciales */


/* Roles y Funcionalidades */

INSERT INTO SENIOR_DEVELOPERS.Rol (Nombre, habilitado) VALUES ('Administrador', 'Si')
INSERT INTO SENIOR_DEVELOPERS.Rol (Nombre, habilitado) VALUES ('Empleado', 'Si')
INSERT INTO SENIOR_DEVELOPERS.Rol (Nombre, habilitado) VALUES ('Cliente', 'Si')


INSERT INTO SENIOR_DEVELOPERS.Funcionalidad (Nombre) VALUES ('ABM Rol')
INSERT INTO SENIOR_DEVELOPERS.Funcionalidad (Nombre) VALUES ('ABM Recorrido')
INSERT INTO SENIOR_DEVELOPERS.Funcionalidad (Nombre) VALUES ('ABM Micro')
INSERT INTO SENIOR_DEVELOPERS.Funcionalidad (Nombre) VALUES ('Generar Viaje')
INSERT INTO SENIOR_DEVELOPERS.Funcionalidad (Nombre) VALUES ('Registro de llegada a Destino')
INSERT INTO SENIOR_DEVELOPERS.Funcionalidad (Nombre) VALUES ('Listado estadistico')
INSERT INTO SENIOR_DEVELOPERS.Funcionalidad (Nombre) VALUES ('Cancelacion de pasaje/encomienda')


INSERT INTO SENIOR_DEVELOPERS.Rol_Funcionalidad
(rol_ID, funcionalidad_ID)
SELECT r.ID, f.ID
FROM SENIOR_DEVELOPERS.Rol r, SENIOR_DEVELOPERS.Funcionalidad f
WHERE r.nombre = 'Administrador'

INSERT INTO SENIOR_DEVELOPERS.Rol_Funcionalidad
(rol_ID, funcionalidad_ID)
SELECT r.ID, f.ID
FROM SENIOR_DEVELOPERS.Rol r, SENIOR_DEVELOPERS.Funcionalidad f
WHERE r.nombre = 'Empleado'
AND f.ID <= 4


/*Usuarios - ambos tiene password: w23e */

/* Usuario admin */
INSERT INTO SENIOR_DEVELOPERS.Usuario (rol_ID, username, password, intentosFallidos, habilitado) 
VALUES 
(1, 'admin', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 0, 'Si')

/*Usuario empleado*/
INSERT INTO SENIOR_DEVELOPERS.Usuario (rol_ID, username, password, intentosFallidos, habilitado) 
VALUES 
(2, 'empleado', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 0, 'Si')


/* Productos */
INSERT INTO SENIOR_DEVELOPERS.Producto (nombre, puntosNecesarios, stock) VALUES ('Mochila', 100, 100)
INSERT INTO SENIOR_DEVELOPERS.Producto (nombre, puntosNecesarios, stock) VALUES ('Bolso', 120, 100)

GO
