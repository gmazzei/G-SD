/*Procedimientos y Funciones*/


IF OBJECT_ID('SENIOR_DEVELOPERS.SP_darBajaFueraServicio') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_darBajaFueraServicio
IF OBJECT_ID('SENIOR_DEVELOPERS.FN_ListadoDestinosConMasPasajesCancelados') IS NOT NULL
  DROP FUNCTION SENIOR_DEVELOPERS.FN_ListadoDestinosConMasPasajesCancelados
IF OBJECT_ID('SENIOR_DEVELOPERS.FN_ListadoDestinosConMicrosMasVacios') IS NOT NULL
  DROP FUNCTION SENIOR_DEVELOPERS.FN_ListadoDestinosConMicrosMasVacios
IF OBJECT_ID('SENIOR_DEVELOPERS.FN_ListadoDestinosConMasPasajesComprados') IS NOT NULL
  DROP FUNCTION SENIOR_DEVELOPERS.FN_ListadoDestinosConMasPasajesComprados
IF OBJECT_ID('SENIOR_DEVELOPERS.FN_ListadoMicrosFueraServicio') IS NOT NULL
  DROP FUNCTION SENIOR_DEVELOPERS.FN_ListadoMicrosFueraServicio
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_modificarRecorrido') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_modificarRecorrido
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_modificarRol') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_modificarRol
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_modificarMicro') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_modificarMicro
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_altaMicro') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_altaMicro
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_insertarCompra') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_insertarCompra
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_registrarLlegada') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_registrarLlegada
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_agregarEncomiendaDeDevolucion') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_agregarEncomiendaDeDevolucion
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_agregarPasajeDeDevolucion') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_agregarPasajeDeDevolucion
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_agregarDevolucion') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_agregarDevolucion
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_realizarCanje') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_realizarCanje
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_generarViaje') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_generarViaje
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_preLogin') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_preLogin
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_altaRecorrido ') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_altaRecorrido 
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_altaRol') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_altaRol
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_guardarPasaje') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_guardarPasaje
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_guardarEncomienda') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_guardarEncomienda
IF OBJECT_ID('SENIOR_DEVELOPERS.FN_calcularPrecio') IS NOT NULL
  DROP FUNCTION SENIOR_DEVELOPERS.FN_calcularPrecio
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_insertarOActualizarCliente') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_insertarOActualizarCliente
IF OBJECT_ID('SENIOR_DEVELOPERS.SP_copiarMicro') IS NOT NULL
  DROP PROCEDURE SENIOR_DEVELOPERS.SP_copiarMicro
IF OBJECT_ID('SENIOR_DEVELOPERS.FN_reemplazoDe') IS NOT NULL
  DROP FUNCTION SENIOR_DEVELOPERS.FN_reemplazoDe
IF OBJECT_ID('SENIOR_DEVELOPERS.FN_reemplazoDe2') IS NOT NULL
  DROP FUNCTION SENIOR_DEVELOPERS.FN_reemplazoDe2
IF OBJECT_ID('SENIOR_DEVELOPERS.FN_fechaEsDeSemestre') IS NOT NULL
  DROP FUNCTION SENIOR_DEVELOPERS.FN_fechaEsDeSemestre

GO


/* Definiciones */

CREATE FUNCTION SENIOR_DEVELOPERS.FN_fechaEsDeSemestre (@fecha DATE)
RETURNS INT AS
BEGIN

	DECLARE @resultado INT
	
	IF (MONTH(@fecha) BETWEEN 1 AND 6)
		SELECT @resultado = 1	
	ELSE
		SELECT @resultado = 2
	
	RETURN @resultado
	
END
GO


CREATE FUNCTION SENIOR_DEVELOPERS.FN_reemplazoDe(@patente NVARCHAR(255), @fechaVidaUtil DATETIME) RETURNS NVARCHAR(255) AS
Begin 
	declare @otraPatente NVARCHAR(255)
	declare @cantidad INT
	declare @resultado NVARCHAR(255)

	declare cursorMicro CURSOR for
	select patente from SENIOR_DEVELOPERS.Micro
	where patente != @patente
	
	open cursorMicro
	fetch next from cursorMicro into @otraPatente
	
	while @@FETCH_STATUS = 0
	begin
		
		select @cantidad = COUNT(*) from SENIOR_DEVELOPERS.Viaje v1, SENIOR_DEVELOPERS.Viaje v2
		where v1.micro_patente = @patente and v1.fechaLlegadaEstimada > @fechaVidaUtil
		and v2.micro_patente = @otraPatente and v2.fechaLlegadaEstimada > @fechaVidaUtil
		and 
		(v1.fechaSalida between v2.fechaSalida and v2.fechaLlegadaEstimada
		or v1.fechaLlegadaEstimada between v1.fechaSalida and v2.fechaLlegadaEstimada)
		
		if (@cantidad = 0)
		begin
			select @resultado = @otraPatente
			break
		end
		
		fetch next from cursorMicro into @otraPatente
	end
	
	close cursorMicro
	deallocate cursorMicro
	
	return @resultado	
end
GO


CREATE FUNCTION SENIOR_DEVELOPERS.FN_reemplazoDe2(@patente NVARCHAR(255), @fechaFueraServicio nvarchar(255), @fechaReinicioServicio nvarchar(255)) RETURNS NVARCHAR(255) AS
Begin 
	declare @otraPatente NVARCHAR(255)
	declare @cantidad INT
	declare @resultado NVARCHAR(255)
	declare @dtFechaFueraServicio date
	declare @dtFechaReinicioServicio date
	
	select @dtFechaFueraServicio = CONVERT(date, @fechaFueraServicio)
	select @dtFechaReinicioServicio = CONVERT(date, @fechaReinicioServicio)

	declare cursorMicro CURSOR for
	select patente from SENIOR_DEVELOPERS.Micro
	where patente != @patente
	
	open cursorMicro
	fetch next from cursorMicro into @otraPatente
	
	while @@FETCH_STATUS = 0
	begin
		
		select @cantidad = COUNT(*) from SENIOR_DEVELOPERS.Viaje v1, SENIOR_DEVELOPERS.Viaje v2
		where v1.micro_patente = @patente and v1.fechaLlegadaEstimada > @dtFechaFueraServicio and v1.fechaLlegadaEstimada < @dtFechaReinicioServicio
		and v2.micro_patente = @otraPatente and v2.fechaLlegadaEstimada > @dtFechaFueraServicio and v1.fechaLlegadaEstimada < @dtFechaReinicioServicio
		and 
		(v1.fechaSalida between v2.fechaSalida and v2.fechaLlegadaEstimada
		or v1.fechaLlegadaEstimada between v1.fechaSalida and v2.fechaLlegadaEstimada)
		
		if (@cantidad = 0)
		begin
			select @resultado = @otraPatente
			break
		end
		
		fetch next from cursorMicro into @otraPatente
	end
	
	close cursorMicro
	deallocate cursorMicro
	
	return @resultado	
end
GO

create function SENIOR_DEVELOPERS.FN_calcularPrecio(@compraNro int)
returns numeric(12,2)
as
begin

	declare @totalPasajes numeric(12,2)
	declare @totalEncomiendas numeric(12,2)
	declare @total numeric(12,2)
	
	select @totalPasajes = ISNULL(SUM(precio), 0) from SENIOR_DEVELOPERS.Pasaje
	where compra_NRO = @compraNro
	
	select @totalEncomiendas = ISNULL(SUM(precio), 0) from SENIOR_DEVELOPERS.Encomienda
	where compra_NRO = @compraNro
	
	select @total = @totalPasajes + @totalEncomiendas
	
	return @total
	
end
GO

create procedure SENIOR_DEVELOPERS.SP_copiarMicro @patente nvarchar(255), @otraPatente nvarchar(255), @fechaAlta nvarchar(255)
as
begin

	declare @dtFechaAlta date
	select @dtFechaAlta = CONVERT(date, @fechaAlta)

	insert into SENIOR_DEVELOPERS.Micro
	(patente, nro, marca, modelo, tipoServicio, bajaFueraServicio, bajaVidaUtil, cantidadButacas, KGDisponibles, fechaAlta, fechaFueraServicio, fechaReinicioServicio, fechaBajaDefinitiva)
	select @otraPatente, nro, marca, modelo, tipoServicio, 'No', 'No', cantidadButacas, KGDisponibles, @dtFechaAlta, NULL, NULL, NULL 
	from SENIOR_DEVELOPERS.Micro
	where patente = @patente
	
	insert into SENIOR_DEVELOPERS.Butaca
	(micro_patente, NRO, piso, tipo)
	select @otraPatente, NRO, piso, tipo
	from SENIOR_DEVELOPERS.Butaca
	where micro_patente = @patente
end
GO


create procedure SENIOR_DEVELOPERS.SP_insertarOActualizarCliente(@DNI NUMERIC(18,0), @nuevoDNI NUMERIC(18,0), @nombre NVARCHAR(255), @apellido NVARCHAR(255), @direccion NVARCHAR(255), @fechaNacimiento NVARCHAR(30), @mail NVARCHAR(255), @genero NVARCHAR(1), @esDiscapacitado NVARCHAR(2), @telefono NUMERIC(18,0))  as
begin
	
	declare @cantidad int
	declare @fechaNacimientoDatetime DATETIME
	
	select @fechaNacimientoDatetime = CONVERT(datetime, @fechaNacimiento, 120)
	
	/*Controlo si existe*/	
	select @cantidad = COUNT(*) from SENIOR_DEVELOPERS.Cliente
	where DNI = @DNI
	
	if (@cantidad = 0)
	begin
	
		insert into SENIOR_DEVELOPERS.Cliente
		(DNI, nombre, apellido, direccion, telefono, mail, fechaNacimiento, esDiscapacitado, genero, puntos)
		values
		(@nuevoDNI, @nombre, @apellido, @direccion, @telefono, @mail, @fechaNacimientoDatetime, @esDiscapacitado, @genero, 0)
		
	end
	else 
	begin
	
		update SENIOR_DEVELOPERS.Cliente
		set
			DNI = @nuevoDNI,
			nombre = @nombre,
			apellido = @apellido,
			telefono = @telefono,
			direccion = @direccion,
			mail = @mail,
			fechaNacimiento = @fechaNacimientoDatetime,
			esDiscapacitado = @esDiscapacitado,
			genero = @genero
		where DNI = @DNI
		
	end
	
	
end
GO


create procedure SENIOR_DEVELOPERS.SP_guardarPasaje(@viajeID int, @clienteDNI numeric(18,0), @compraNro int, @butacaNro numeric(18,0)) as
begin
	
	declare @pasajeID numeric(18,0)
	declare @cantidadDiscapacitados int
	declare @precio numeric(12,2)
	declare @esDiscapacitado nvarchar(3)
	declare @edad int
	declare @genero nvarchar(2)
	declare @cantidadClientesCompra int
	declare @viajesSimultaneos int
	declare @fechaSalidaViaje datetime
	declare @fechaLlegadaViaje datetime
	declare @mensajeError nvarchar(100)
	
	/*Controlo viajes simultaneos del cliente*/
	
	select @fechaSalidaViaje = fechaSalida, @fechaLlegadaViaje = fechaLlegadaEstimada 
	from SENIOR_DEVELOPERS.Viaje where ID = @viajeID
	
	select @viajesSimultaneos = COUNT(*) 
	from SENIOR_DEVELOPERS.Pasaje P
	inner join SENIOR_DEVELOPERS.Viaje V on V.ID = P.viaje_ID
	where P.cliente_DNI = @clienteDNI
	AND V.fechaSalida between @fechaSalidaViaje AND @fechaLlegadaViaje
	AND V.fechaLlegadaEstimada between @fechaSalidaViaje AND @fechaLlegadaViaje
	
	if (@viajesSimultaneos > 0)
	begin
		select @mensajeError = 'El cliente con DNI ' + convert(nvarchar(50), @clienteDNI) + ' ya esta realizando un viaje en esa fecha.' 
		rollback
		raiserror(@mensajeError,16,1)
		return
	end
	
	select @cantidadDiscapacitados = COUNT(*)
	from SENIOR_DEVELOPERS.Pasaje P, 
		 SENIOR_DEVELOPERS.Cliente C
	where P.cliente_DNI = C.DNI AND
		  P.compra_NRO = @compraNro AND
		  C.esDiscapacitado is not null AND
		  C.esDiscapacitado = 'Si'
	
	select @cantidadClientesCompra = COUNT(*)
	from SENIOR_DEVELOPERS.Pasaje P, 
		 SENIOR_DEVELOPERS.Cliente C
	where P.cliente_DNI = C.DNI AND
		  P.compra_NRO = @compraNro
	
	select @esDiscapacitado = esDiscapacitado, 
		   @genero = genero, 
		   @edad = DATEDIFF(year, fechaNacimiento, GETDATE()) 
	from SENIOR_DEVELOPERS.Cliente 
	where DNI = @clienteDNI
	
	
	/*Controlo que no haya mas de un discapacitado por compra*/
	if(@cantidadDiscapacitados = 1 AND @esDiscapacitado = 'Si')
	begin
		rollback
		raiserror('No puede haber más de un discapacitado por compra.',16,1)
		return
	end
	
	
	/*Calculo de precio*/
	select @precio = R.precioBasePasaje * S.porcentajeAdicional
	from SENIOR_DEVELOPERS.Viaje V
	inner join SENIOR_DEVELOPERS.Recorrido R on R.ID = V.recorrido_ID
	inner join SENIOR_DEVELOPERS.Servicio S on R.tipoServicio = S.nombre
	where V.ID = @viajeID 
	
	/*Si es jubilado/pensionado, el precio es la mitad de lo normal*/
	if ((@genero = 'M' AND @edad >= 65) OR (@genero = 'F' AND @edad >= 60))
	begin
		select @precio = @precio/2
	end
	
	/*Si ya hay un discapacitado, no se cobran mas de 2 pasajes por compra*/
	if (@cantidadClientesCompra >= 2 AND @cantidadDiscapacitados = 1)
	begin
		select @precio = 0
	end
	
	select @pasajeID = MAX(ID)+1 from SENIOR_DEVELOPERS.Pasaje
	
	insert into SENIOR_DEVELOPERS.Pasaje
	(ID, cliente_DNI, viaje_ID, compra_NRO, precio, butaca_NRO)
	values
	(@pasajeID, @clienteDNI, @viajeID, @compraNro, @precio, @butacaNro)
	
end
GO

create procedure SENIOR_DEVELOPERS.SP_guardarEncomienda(@viajeID int, @clienteDNI numeric(18,8), @compraNro int, @kg numeric(18,0)) as
begin
	
	declare @encomiendaID numeric(18,0)
	declare @precio numeric(10,2)

	select @precio = R.precioBaseKG * @kg
	from SENIOR_DEVELOPERS.Viaje V
	inner join SENIOR_DEVELOPERS.Recorrido R on R.ID = V.recorrido_ID
	where V.ID = @viajeID
	
	select @encomiendaID = MAX(ID)+1 from SENIOR_DEVELOPERS.Encomienda
	
	insert into SENIOR_DEVELOPERS.Encomienda
	(ID, cliente_DNI, viaje_ID, compra_NRO, precio, KG)
	values
	(@encomiendaID, @clienteDNI, @viajeID, @compraNro, @precio, @kg)
	
end
GO



create procedure SENIOR_DEVELOPERS.SP_altaRol @nombre NVARCHAR(255), @habilitado NVARCHAR(2) as
begin 
	declare @cantidad int 

	select @cantidad = COUNT(*) from SENIOR_DEVELOPERS.Rol 
	where nombre = @nombre

	if (@cantidad > 0)
	begin
		raiserror('El nombre del rol se encuentra en uso, debe elegir otro.',16,1)
		return
	end

	insert into SENIOR_DEVELOPERS.Rol 
	(nombre, habilitado) 
	values 
	(@nombre, @habilitado)
	
end
GO


create procedure SENIOR_DEVELOPERS.SP_altaRecorrido 
@codigo NUMERIC(18,0), @ciudadOrigenID int, @ciudadDestinoID int, @tipoServicio nvarchar(255), @precioBasePasaje numeric(18,2),
@precioBaseKG numeric(18,2), @habilitado nvarchar(2) as
begin
	
	
	if (exists(select 1 from SENIOR_DEVELOPERS.Recorrido where ID = @codigo))
	begin
		raiserror('Ya existe otro recorrido con el mismo codigo, debe elegir otro.',16,1)
		return
	end
	
	if (exists(select 1 from SENIOR_DEVELOPERS.Recorrido where ID != @codigo AND tipoServicio = @tipoServicio AND ciudadOrigen_ID = @ciudadOrigenID AND ciudadDestino_ID = @ciudadDestinoID))
	begin
		raiserror('Ya existe otro recorrido con las mismas ciudad de origen, ciudad de destino y tipo de servicio.',16,1)
		return
	end
	
	insert into SENIOR_DEVELOPERS.Recorrido
	(ID, ciudadOrigen_ID, ciudadDestino_ID, tipoServicio, precioBasePasaje, precioBaseKg, habilitado)
    values
    (@codigo, @ciudadOrigenID, @ciudadDestinoID, @tipoServicio, @precioBasePasaje, @precioBaseKg, @habilitado)
		
end
GO
/*
create procedure SENIOR_DEVELOPERS.SP_preLogin @username nvarchar(255), @password nvarchar(255) as
begin
	
	declare @cantidad nvarchar(255)
	declare @passwordEncontrada nvarchar(255)
	
	select @cantidad = COUNT(*) from SENIOR_DEVELOPERS.Usuario
	where username = @username and habilitado = 'Si'
	
	if (@cantidad = 1)
	begin
		
		select @passwordEncontrada = password from SENIOR_DEVELOPERS.Usuario
		where username = @username
		
		if (@password = @passwordEncontrada)
		begin
		
			update SENIOR_DEVELOPERS.Usuario
			set
				intentosFallidos = 0
			where username = @username
			
		end
		else
		begin
		
			update SENIOR_DEVELOPERS.Usuario
			set
				intentosFallidos = intentosFallidos + 1
			where username = @username
			
		end
	end

end
GO
*/
create procedure SENIOR_DEVELOPERS.SP_generarViaje @recorridoID int, @microPatente varchar(255), @fechaSalida nvarchar(255), @fechaLlegadaEstimada nvarchar(255) as
begin
	
	declare @tipoServicioRecorrido nvarchar(255)
	declare @tipoServicioMicro nvarchar(255)
	declare @fechaBajaVidaUtil datetime
	declare @fechaFueraServicio datetime
	declare @fechaReinicioServicio datetime
	declare @dtFechaSalida datetime
	declare @dtFechaLlegadaEstimada datetime
	declare @viajesSimultaneos int
	
	select @dtFechaSalida = CONVERT(datetime, @fechaSalida, 120)
	select @dtFechaLlegadaEstimada = CONVERT(datetime, @fechaLlegadaEstimada, 120)
	
	select @tipoServicioRecorrido = tipoServicio FROM SENIOR_DEVELOPERS.Recorrido WHERE ID = @recorridoID
	
	select	@tipoServicioMicro = tipoServicio, 
			@fechaBajaVidaUtil = fechaBajaDefinitiva, 
			@fechaFueraServicio = fechaFueraServicio,
			@fechaReinicioServicio = fechaReinicioServicio 
	from SENIOR_DEVELOPERS.Micro 
	where patente = @microPatente
	
	select @viajesSimultaneos = ISNULL(COUNT(*),0) from SENIOR_DEVELOPERS.Viaje
	where
	micro_patente = @microPatente and
	estado = 'Vigente' and
	((fechaSalida between @dtFechaSalida and @dtFechaLlegadaEstimada) or (fechaLlegadaEstimada between @dtFechaSalida and @dtFechaLlegadaEstimada))
	
	

	if(@dtFechaLlegadaEstimada > DATEADD(DAY,1,@dtFechaSalida))
	begin
		raiserror('Un viaje no puede durar más de 24 horas.',16,1)
		return
	end

	if(@tipoServicioRecorrido != @tipoServicioMicro)
	begin
		raiserror('El tipo de servicio del micro y del recorrido deben ser iguales.',16,1)
		return
	end
	
	if (@fechaBajaVidaUtil IS NOT NULL and GETDATE() >= @fechaBajaVidaUtil)
	begin
		raiserror('El micro seleccionado esta fuera de servicio por vida util',16,1)
		return
	end
	
	if (@fechaFueraServicio IS NOT NULL and GETDATE() between @fechaFueraServicio and @fechaReinicioServicio)
	begin
		raiserror('El micro seleccionado esta fuera de servicio temporalmente.',16,1)
		return
	end
	
	if (@viajesSimultaneos > 0)
	begin
		raiserror('Existen viajes simultaneos de ese micro en esa fecha.',16,1)
		return
	end
		
	insert into SENIOR_DEVELOPERS.Viaje
    (recorrido_ID, micro_patente, fechaSalida, fechaLlegadaEstimada, estado)
    values
    (@recorridoID, @microPatente, @dtFechaSalida, @dtFechaLlegadaEstimada, 'Vigente')
			
end
GO

create procedure SENIOR_DEVELOPERS.SP_realizarCanje @dni numeric(18,0), @productoID int, @cantidad int as
begin
	
	declare @stock int
	declare @puntosCliente int
	declare @puntosUnitarios int
	
	if(NOT EXISTS(SELECT 1 FROM SENIOR_DEVELOPERS.Cliente WHERE DNI = @dni))
	begin
		raiserror('No existe ningún cliente con el DNI que ha ingresado.',16,1)
		return
	end
	
	select @puntosCliente = puntos from SENIOR_DEVELOPERS.V_PuntosClientesALaFecha where cliente_DNI = @dni
	
	select @stock = stock, @puntosUnitarios = puntosNecesarios from SENIOR_DEVELOPERS.Producto where ID = @productoID
	
	if( @puntosCliente < (@puntosUnitarios * @cantidad) )
	begin
		raiserror('Lo sentimos, no tiene puntos suficientes.',16,1)
		return
	end
	
	
	if(@stock < @cantidad)
	begin
		raiserror('Lo sentimos, no hay suficiente stock del producto.',16,1)
		return
	end
	
	insert into SENIOR_DEVELOPERS.Canje
	(cliente_DNI, producto_ID, cantidad, fecha)
	values
	(@dni, @productoID, @cantidad, GETDATE())
	
end
GO

create procedure SENIOR_DEVELOPERS.SP_agregarDevolucion @nroCompra int, @motivo nvarchar(255) as
begin

	if(NOT EXISTS(select 1 from SENIOR_DEVELOPERS.RegistroCompra where NRO = @nroCompra))
	begin
		rollback
		raiserror('No existe compra con dicho NRO',16,1)
		return
	end

	insert into SENIOR_DEVELOPERS.Cancelacion
	(fecha, compra_NRO, motivo)
	values
	(GETDATE(), @nroCompra, @motivo)
end
GO

create procedure SENIOR_DEVELOPERS.SP_agregarPasajeDeDevolucion @nroPasaje numeric(18,0), @compraNro int as
begin
	
	declare @nroDevolucion int
	declare @mensajeError nvarchar(100)
	declare @precio numeric(12,2)
	declare @butacaNro numeric(18,0)
	declare @viajeID int
	declare @clienteDNI numeric(18,0)
	declare @compraPasaje int
	
		
	if (NOT EXISTS(select 1 from SENIOR_DEVELOPERS.Pasaje where ID = @nroPasaje))
	begin
		select @mensajeError = 'El pasaje ' + convert(varchar, @nroPasaje) + ' no existe'
		rollback
		raiserror(@mensajeError,16,1)
		return
	end
	
	
	select @precio = precio, @viajeID = viaje_ID, @butacaNro = butaca_NRO, @clienteDNI = cliente_DNI, @compraPasaje = compra_NRO
	from SENIOR_DEVELOPERS.Pasaje where ID = @nroPasaje
	
	if (@compraNro != @compraPasaje)
	begin
		select @mensajeError = 'El pasaje ' + convert(varchar, @nroPasaje) + ' corresponde a otro nro de compra'
		rollback
		raiserror(@mensajeError,16,1)
		return
	end
	
	
	select @nroDevolucion = ID from SENIOR_DEVELOPERS.Cancelacion 
	where fecha = (select MAX(fecha) from SENIOR_DEVELOPERS.Cancelacion)
		
	insert into SENIOR_DEVELOPERS.CancelacionPasaje
	(cancelacion_ID, pasaje_ID, viaje_ID, cliente_DNI, precio, compra_NRO, butaca_NRO)
	values
	(@nroDevolucion, @nroPasaje, @viajeID, @clienteDNI, @precio, @compraNro, @butacaNro)
	
	delete from SENIOR_DEVELOPERS.Pasaje where ID = @nroPasaje
	
end

GO

create procedure SENIOR_DEVELOPERS.SP_agregarEncomiendaDeDevolucion @nroEncomienda numeric(18,0), @compraNro int as
begin
	
	declare @nroDevolucion int
	declare @mensajeError nvarchar(100)
	declare @precio numeric(12,2)
	declare @kg numeric(18,0)
	declare @viajeID int
	declare @clienteDNI numeric(18,0)
	declare @compraEncomienda int
	
	if (NOT EXISTS(select 1 from SENIOR_DEVELOPERS.Encomienda where ID = @nroEncomienda))
	begin
		select @mensajeError = 'La encomienda ' + convert(varchar, @nroEncomienda) + ' no existe.'
		rollback
		raiserror(@mensajeError,16,1)
		return
	end
	
	
	select @precio = precio, @viajeID = viaje_ID, @kg = KG, @clienteDNI = cliente_DNI, @compraEncomienda = compra_NRO
	from SENIOR_DEVELOPERS.Encomienda where ID = @nroEncomienda
	
	if (@compraNro != @compraEncomienda)
	begin
		select @mensajeError = 'La encomienda ' + convert(varchar, @nroEncomienda) + ' corresponde a otro nro de compra.'
		rollback
		raiserror(@mensajeError,16,1)
		return
	end
	
	
	select @nroDevolucion = ID from SENIOR_DEVELOPERS.Cancelacion 
	where fecha = (select MAX(fecha) from SENIOR_DEVELOPERS.Cancelacion)
		
	insert into SENIOR_DEVELOPERS.CancelacionEncomienda
	(cancelacion_ID, encomienda_ID, viaje_ID, cliente_DNI, precio, compra_NRO, KG)
	values
	(@nroDevolucion, @nroEncomienda, @viajeID, @clienteDNI, @precio, @compraNro, @kg)
	
	delete from SENIOR_DEVELOPERS.Encomienda where ID = @nroEncomienda
	
end
GO


create procedure SENIOR_DEVELOPERS.SP_registrarLlegada @microPatente nvarchar(255), @fecha nvarchar(200), @ciudadOrigenID int, @ciudadDestinoID int as
begin
	
	declare @viajeID int
	declare @dtFecha datetime
	select @dtFecha = convert(datetime, @fecha, 120)
	
	select top 1 @viajeID = V.ID  from SENIOR_DEVELOPERS.Viaje V 
	INNER JOIN SENIOR_DEVELOPERS.Recorrido R ON V.recorrido_ID = R.ID 
	where 
	V.micro_patente = @microPatente AND 
	R.ciudadOrigen_ID = @ciudadOrigenID AND 
	R.ciudadDestino_ID = @ciudadDestinoID AND 
	@dtFecha BETWEEN fechaSalida AND DATEADD(DAY,1,fechaSalida) /*un viaje no puede durar mas de 24 horas*/
	order by fechaSalida
	
	if (@viajeID IS NOT NULL)
	begin
		
		update SENIOR_DEVELOPERS.Viaje
		set fechaLlegada = @dtFecha
		where ID = @viajeID
		
	end
	else
	begin
	
		raiserror('No existe viaje con esas especificaciones.',16,1)
		return
		
	end
	
end
GO


create procedure SENIOR_DEVELOPERS.SP_insertarCompra @clienteDNI numeric(18,0), @medioPago nvarchar(20) as
begin
	
	declare @nro int
	select @nro = MAX(NRO)+1 from SENIOR_DEVELOPERS.RegistroCompra
	
	SET IDENTITY_INSERT SENIOR_DEVELOPERS.RegistroCompra ON
	
	insert into SENIOR_DEVELOPERS.RegistroCompra
	(NRO, cliente_DNI, fecha, medioPago) 
	values
	(@nro, @clienteDNI, GETDATE(), @medioPago)
	
	SET IDENTITY_INSERT SENIOR_DEVELOPERS.RegistroCompra OFF

end
GO

create procedure SENIOR_DEVELOPERS.SP_altaMicro @patente nvarchar(255), @nro int, @marca nvarchar(255), @modelo nvarchar(255), @tipoServicio nvarchar(255), @cantidadButacas numeric(18,0), @kgDisponibles numeric(18,0), @fechaAlta nvarchar(200) as
begin
	
	declare @mensajeError nvarchar(200)
	declare @dtFechaAlta datetime
	
	
	if (exists(select 1 from SENIOR_DEVELOPERS.Micro where patente = @patente))
	begin
		select @mensajeError = 'Ya existe un micro con la patente ' + @patente + ' asignada.'
		raiserror(@mensajeError ,16,1)
		return
	end
	
	if (exists(select 1 from SENIOR_DEVELOPERS.Micro where nro = @nro))
	begin
		select @mensajeError = 'Ya existe un micro con el nro ' + CONVERT(nvarchar(20), @nro) + ' asignado.'
		raiserror(@mensajeError ,16,1)
		return
	end

	select @dtFechaAlta = CONVERT(datetime, @fechaAlta, 120)

	insert into SENIOR_DEVELOPERS.Micro
    (patente, nro, marca, modelo, tipoServicio, bajaFueraServicio, bajaVidaUtil, cantidadButacas, KGDisponibles, fechaAlta, fechaFueraServicio, fechaReinicioServicio, fechaBajaDefinitiva)
    values
    (@patente, @nro, @marca, @modelo, @tipoServicio, 'No', 'No', @cantidadButacas, @kgDisponibles, @dtfechaAlta, NULL, NULL, NULL)
            
end
GO

create procedure SENIOR_DEVELOPERS.SP_modificarMicro @patente nvarchar(255), @patenteAnt nvarchar(255), @nro int, @tipoServicio nvarchar(255), @marca nvarchar(255), @modelo nvarchar(255), @bajaFueraServicio nvarchar(2), @bajaVidaUtil nvarchar(2) as
begin

	declare @mensajeError nvarchar(100)
	
	if (exists(select 1 from SENIOR_DEVELOPERS.Micro where patente = @patente AND patente != @patenteAnt))
	begin
		select @mensajeError = 'Ya existe un micro con la patente ' + @patente + ' asignada.'
		raiserror(@mensajeError ,16,1)
		return
	end
	
	if (exists(select 1 from SENIOR_DEVELOPERS.Micro where nro = @nro AND patente != @patenteAnt))
	begin
		select @mensajeError = 'Ya existe un micro con el nro ' + CONVERT(nvarchar(20), @nro) + ' asignado.'
		raiserror(@mensajeError ,16,1)
		return
	end
	
	
	declare @tipoServicioAnt nvarchar(255)
	select @tipoServicioAnt = tipoServicio from SENIOR_DEVELOPERS.Micro where patente = @patenteAnt
	
	if((@tipoServicio != @tipoServicioAnt) AND exists(select 1 from SENIOR_DEVELOPERS.Viaje where micro_patente = @patenteAnt))
	begin
		select @mensajeError = 'No es posible cambiar el tipo de servicio del micro ya que tiene viajes asignados.'
		raiserror(@mensajeError,16,1)
		return
	end

	if(@bajaFueraServicio = 'No')
	begin
		update SENIOR_DEVELOPERS.Micro
		set fechaFueraServicio = NULL
		where patente = @patenteAnt
	end

	if(@bajaVidaUtil = 'No')
	begin
		update SENIOR_DEVELOPERS.Micro
		set fechaBajaDefinitiva  = NULL
		where patente = @patenteAnt
	end
	
	update SENIOR_DEVELOPERS.Micro
	set
		patente = @patente,
		modelo = @modelo,
		marca = @marca, 
		tipoServicio = @tipoServicio,
		nro = @nro,
		bajaFueraServicio = @bajaFueraServicio,
		bajaVidaUtil = @bajaVidaUtil
	where
		patente = @patenteAnt
	
end
GO

create procedure SENIOR_DEVELOPERS.SP_modificarRol @rolID int, @nombre nvarchar(255), @habilitado nvarchar(2) as
begin

	if(exists(select 1 from SENIOR_DEVELOPERS.Rol where nombre = @nombre AND ID != @rolID))
	begin
		raiserror('Ya existe un rol con ese nombre. Debe elegir otro para realizar la modificacion.',16,1)
	end
	
	
	update SENIOR_DEVELOPERS.Rol
	set nombre = @nombre,
		habilitado = @habilitado
	where ID = @rolID
		
end
GO

create procedure SENIOR_DEVELOPERS.SP_modificarRecorrido @codigo numeric(18,0), @codigoAnterior numeric(18,0), @ciudadOrigenID int, @ciudadDestinoID int, @tipoServicio nvarchar(255), @precioBasePasaje numeric(18,2), @precioBaseKg numeric(18,2), @habilitado nvarchar(2) as
begin

	if (exists(select 1 from SENIOR_DEVELOPERS.Recorrido where ID != @codigoAnterior AND tipoServicio = @tipoServicio AND ciudadOrigen_ID = @ciudadOrigenID AND ciudadDestino_ID = @ciudadDestinoID))
	begin
		raiserror('Ya existe otro recorrido con las mismas ciudad de origen, ciudad de destino y tipo de servicio.',16,1)
		return
	end

	if(@codigo = @codigoAnterior)
	begin
		
		update SENIOR_DEVELOPERS.Recorrido
		set
			ciudadOrigen_ID = @ciudadOrigenID,
			ciudadDestino_ID = @ciudadDestinoID,
			tipoServicio = @tipoServicio,
			precioBasePasaje = @precioBasePasaje,
			precioBaseKG = @precioBaseKg,
			habilitado = @habilitado
		where ID = @codigo
		
	end
	else
	begin
		
		if(exists(select 1 from SENIOR_DEVELOPERS.Recorrido where ID = @codigo))
		begin
			raiserror('Ya existe un recorrido con el mismo codigo. Debe elegir otro.',16,1)
		end
		
		update SENIOR_DEVELOPERS.Recorrido
		set
			ID = @codigo,
			ciudadOrigen_ID = @ciudadOrigenID,
			ciudadDestino_ID = @ciudadDestinoID,
			tipoServicio = @tipoServicio,
			precioBasePasaje = @precioBasePasaje,
			precioBaseKG = @precioBaseKg,
			habilitado = @habilitado
		where ID = @codigoAnterior
			
	end

end
GO


create function SENIOR_DEVELOPERS.FN_ListadoMicrosFueraServicio(@anio int, @semestre int) 
returns @resultado table (Micro nvarchar(255), Dias int) as
begin

	declare @microsFueraServicio table (patente nvarchar(255), fecha date, fechaReinicio date)
	
	declare @fechaLimiteInferior date
	declare @fechaLimiteSuperior date
	
	if(@semestre = 1)
	begin
		select @fechaLimiteInferior = CONVERT(date, CONVERT(char(4), @anio - 1) + '-12-31')
		select @fechaLimiteSuperior = CONVERT(date, CONVERT(char(4), @anio) + '-07-01')
	end
	else 
	begin
		select @fechaLimiteInferior = CONVERT(date, CONVERT(char(4), @anio) + '-06-30')
		select @fechaLimiteSuperior = CONVERT(date, CONVERT(char(4), @anio + 1) + '-01-01')
	end
	
	
	insert into @microsFueraServicio
	(patente, fecha, fechaReinicio)
	select micro_patente, fecha, fechaReinicio 
	from SENIOR_DEVELOPERS.RegistroMicroFueraServicio
	where 
	(fecha between @fechaLimiteInferior AND @fechaLimiteSuperior) OR
	(fechaReinicio between @fechaLimiteInferior AND @fechaLimiteSuperior)
	
	
	
	update @microsFueraServicio
	set fecha = @fechaLimiteInferior
	where fecha < @fechaLimiteInferior
	
	update @microsFueraServicio
	set fechaReinicio = @fechaLimiteSuperior
	where fechaReinicio > @fechaLimiteSuperior
	
	insert into @resultado
	(Micro, Dias)
	select top 5 patente, SUM(DATEDIFF(DAY, fecha, fechaReinicio))
	from @microsFueraServicio
	group by patente
	order by 2 DESC
	
	return
	
end
GO


create function SENIOR_DEVELOPERS.FN_ListadoDestinosConMasPasajesComprados(@anio int, @semestre int) 
returns @resultado table (Destino nvarchar(255), Cantidad int) as
begin
	
	declare @fechaLimiteInferior date
	declare @fechaLimiteSuperior date
	
	if(@semestre = 1)
	begin
		select @fechaLimiteInferior = CONVERT(date, CONVERT(char(4), @anio - 1) + '-12-31')
		select @fechaLimiteSuperior = CONVERT(date, CONVERT(char(4), @anio) + '-07-01')
	end
	else 
	begin
		select @fechaLimiteInferior = CONVERT(date, CONVERT(char(4), @anio) + '-06-30')
		select @fechaLimiteSuperior = CONVERT(date, CONVERT(char(4), @anio + 1) + '-01-01')
	end
	
	insert into @resultado
	(Destino, Cantidad)
	select top 5 C.nombre, COUNT(*)
	from SENIOR_DEVELOPERS.Pasaje P
	inner join SENIOR_DEVELOPERS.RegistroCompra RC ON P.compra_NRO = RC.NRO 
	inner join SENIOR_DEVELOPERS.Viaje V ON V.ID = P.viaje_ID
	inner join SENIOR_DEVELOPERS.Recorrido R ON R.ID = V.recorrido_ID
	inner join SENIOR_DEVELOPERS.Ciudad C ON C.ID = R.ciudadDestino_ID
	where RC.fecha between @fechaLimiteInferior AND @fechaLimiteSuperior
	group by C.nombre
	order by COUNT(*) DESC
	
	
	return
	
end
GO

create function SENIOR_DEVELOPERS.FN_ListadoDestinosConMicrosMasVacios(@anio int, @semestre int) 
returns @resultado table (Destino nvarchar(255), Fecha date, Micro nvarchar(255), Porcentaje_Lleno decimal(5,2)) as
begin
	
	declare @fechaLimiteInferior date
	declare @fechaLimiteSuperior date
	
	if(@semestre = 1)
	begin
		select @fechaLimiteInferior = CONVERT(date, CONVERT(char(4), @anio - 1) + '-12-31')
		select @fechaLimiteSuperior = CONVERT(date, CONVERT(char(4), @anio) + '-07-01')
	end
	else 
	begin
		select @fechaLimiteInferior = CONVERT(date, CONVERT(char(4), @anio) + '-06-30')
		select @fechaLimiteSuperior = CONVERT(date, CONVERT(char(4), @anio + 1) + '-01-01')
	end
	
	insert into @resultado
	(Destino, Fecha, Micro, Porcentaje_Lleno)
	select top 5 C.nombre, V.fechaLlegada, M.patente, CONVERT(decimal(5,2), COUNT(*))* 100/M.cantidadButacas AS Porcentaje
	from SENIOR_DEVELOPERS.Pasaje P
	inner join SENIOR_DEVELOPERS.RegistroCompra RC ON P.compra_NRO = RC.NRO 
	inner join SENIOR_DEVELOPERS.Viaje V ON V.ID = P.viaje_ID
	inner join SENIOR_DEVELOPERS.Micro M ON V.micro_patente = M.patente
	inner join SENIOR_DEVELOPERS.Recorrido R ON R.ID = V.recorrido_ID
	inner join SENIOR_DEVELOPERS.Ciudad C ON C.ID = R.ciudadDestino_ID
	where fechaLlegada between @fechaLimiteInferior AND @fechaLimiteSuperior
	group by V.ID, C.nombre, V.fechaLlegada, M.patente, M.cantidadButacas
	order by Porcentaje
	
	return
	
end
GO


create function SENIOR_DEVELOPERS.FN_ListadoDestinosConMasPasajesCancelados(@anio int, @semestre int) 
returns @resultado table (Destino nvarchar(255), Cantidad_de_pasajes_cancelados int) as
begin
	
	declare @fechaLimiteInferior date
	declare @fechaLimiteSuperior date
	
	if(@semestre = 1)
	begin
		select @fechaLimiteInferior = CONVERT(date, CONVERT(char(4), @anio - 1) + '-12-31')
		select @fechaLimiteSuperior = CONVERT(date, CONVERT(char(4), @anio) + '-07-01')
	end
	else 
	begin
		select @fechaLimiteInferior = CONVERT(date, CONVERT(char(4), @anio) + '-06-30')
		select @fechaLimiteSuperior = CONVERT(date, CONVERT(char(4), @anio + 1) + '-01-01')
	end
	
	
	insert into @resultado
	(Destino, Cantidad_de_pasajes_cancelados) 
	select top 5 C.nombre AS Destino, COUNT(*) as Cantidad
	from SENIOR_DEVELOPERS.CancelacionPasaje CP
	inner join SENIOR_DEVELOPERS.Cancelacion CA ON CA.ID = CP.cancelacion_ID 
	inner join SENIOR_DEVELOPERS.Viaje V ON V.ID = CP.viaje_ID
	inner join SENIOR_DEVELOPERS.Recorrido R ON R.ID = V.recorrido_ID
	inner join SENIOR_DEVELOPERS.Ciudad C ON C.ID = R.ciudadDestino_ID
	where CA.fecha between @fechaLimiteInferior AND @fechaLimiteSuperior
	group by C.nombre
	order by Cantidad DESC
	
		
	return
	
end
GO


create procedure SENIOR_DEVELOPERS.SP_darBajaFueraServicio @patente nvarchar(255), @fechaInicio nvarchar(255), @fechaReinicio nvarchar(255) as
begin

	declare @dtFechaInicio date
	declare @dtFechaReinicio date
	
	select @dtFechaInicio = CONVERT(DATE, @fechaInicio)
	select @dtFechaReinicio = CONVERT(DATE, @fechaReinicio)
	
	
	update SENIOR_DEVELOPERS.Micro 
	set 
		bajaFueraServicio = 'Si',
		fechaFueraServicio = @dtFechaInicio,
		fechaReinicioServicio = @dtFechaReinicio
	where patente = @patente

end
GO