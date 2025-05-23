﻿-- Usar master para poder eliminar la BD si existe
USE master;
GO

-- Crear la base de datos
CREATE DATABASE TiendaDeTemporada;
GO

-- Usar la nueva base de datos
USE TiendaDeTemporada;
GO

-- Crear esquemas
CREATE SCHEMA ClientesInfo AUTHORIZATION dbo;
go
CREATE SCHEMA ComprasInfo AUTHORIZATION dbo;
go
CREATE SCHEMA ProductoInfo AUTHORIZATION dbo;
go
CREATE SCHEMA VentasInfo AUTHORIZATION dbo;
GO


-- Tablas ClienteInfo
CREATE TABLE ClientesInfo.Cliente(
    id_cliente BIGINT IDENTITY(1,1) NOT NULL,
    nombre_cliente VARCHAR(200) NOT NULL,
    direccion_cliente VARCHAR(300) NOT NULL,
    telefono_cliente VARCHAR(20),
    correo_cliente VARCHAR(100),
    CONSTRAINT PKCliente PRIMARY KEY(id_cliente)
);

CREATE TABLE ClientesInfo.Tarjeta_Cliente(
    id_tarjeta_cliente BIGINT IDENTITY(1,1) NOT NULL,
    id_cliente BIGINT NOT NULL,
    numero_tarjeta VARCHAR(20) UNIQUE NOT NULL,
    tipo VARCHAR(20) NOT NULL,
    banco VARCHAR(50) NOT NULL,
    codigo_seguridad VARCHAR(10) NOT NULL,
    fecha_vencimiento DATE NOT NULL,
    CONSTRAINT PKTarjetaCliente PRIMARY KEY (id_tarjeta_cliente),
    CONSTRAINT FKTarjeta_Cliente FOREIGN KEY(id_cliente) 
        REFERENCES ClientesInfo.Cliente(id_cliente)
);

-- Tablas ProductoInfo
CREATE TABLE ProductoInfo.Producto (
    id_producto BIGINT IDENTITY(1,1),
    nombre_producto VARCHAR(200) NOT NULL,
    precio_producto DECIMAL(10,2) NOT NULL,
    existencias INT NOT NULL DEFAULT 0,
    CONSTRAINT PKProducto PRIMARY KEY (id_producto)
);

-- Tablas ComprasInfo
CREATE TABLE ComprasInfo.Proveedor (
    id_proveedor BIGINT IDENTITY(1,1),
    nombre_proveedor VARCHAR(200) NOT NULL,
    direccion_proveedor VARCHAR(300) NOT NULL,
    telefono_proveedor VARCHAR(20),
    correo_proveedor VARCHAR(100),
    CONSTRAINT PKProvedor PRIMARY KEY (id_proveedor)
);

CREATE TABLE ProductoInfo.Temporada (
    id_temporada BIGINT IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE NOT NULL,
	CONSTRAINT PKTemporada PRIMARY KEY (id_temporada)
);

CREATE TABLE ProductoInfo.Producto_Temporada (
    id_producto_temporada BIGINT IDENTITY(1,1),
    id_producto BIGINT NOT NULL,
    id_temporada BIGINT NOT NULL,
	CONSTRAINT PKProductoTemporada PRIMARY KEY (id_producto_temporada),
    CONSTRAINT FKProductoTemporada_Producto FOREIGN KEY (id_producto) REFERENCES ProductoInfo.Producto(id_producto),
    CONSTRAINT FKProductoTemporada_Temporada FOREIGN KEY (id_temporada) REFERENCES ProductoInfo.Temporada(id_temporada),
	CONSTRAINT UQ_Producto_Temporada UNIQUE (id_producto, id_temporada)
);


CREATE TABLE ComprasInfo.Compra (
    id_compra BIGINT IDENTITY(1,1),
    id_proveedor BIGINT NOT NULL,
    fecha_compra DATE NOT NULL,
    total_compra DECIMAL(10,2) NOT NULL DEFAULT 0,
    CONSTRAINT PKCompra PRIMARY KEY (id_compra),
    CONSTRAINT FKProvedorCompras FOREIGN KEY (id_proveedor) REFERENCES ComprasInfo.Proveedor(id_proveedor)
);

CREATE TABLE ComprasInfo.Detalle_Compra (
    id_compra BIGINT NOT NULL,
    id_producto BIGINT NOT NULL,
    cantidad INT NOT NULL,
    subtotal_compra DECIMAL(10,2) NOT NULL DEFAULT 0,
    CONSTRAINT PKDetalleCompra PRIMARY KEY (id_compra, id_producto),
    CONSTRAINT FKDetalleCompra_Compra FOREIGN KEY (id_compra) REFERENCES ComprasInfo.Compra(id_compra),
    CONSTRAINT FKDetalleCompra_Producto FOREIGN KEY (id_producto) REFERENCES ProductoInfo.Producto(id_producto)
);

-- Tablas VentasInfo
CREATE TABLE VentasInfo.Venta (
    id_venta BIGINT IDENTITY(1,1) NOT NULL,
    id_tarjeta_cliente BIGINT NOT NULL,
    fecha_venta DATE NOT NULL,
    total_venta DECIMAL(10,2) NOT NULL DEFAULT 0,
    CONSTRAINT PKVenta PRIMARY KEY (id_venta),
    CONSTRAINT FKVenta_Tarjeta FOREIGN KEY (id_tarjeta_cliente) REFERENCES ClientesInfo.Tarjeta_Cliente(id_tarjeta_cliente)
);

CREATE TABLE VentasInfo.Detalle_Venta (
    id_venta BIGINT NOT NULL,
    id_producto BIGINT NOT NULL,
    cantidad INT NOT NULL,
    subtotal_venta DECIMAL(10,2) NOT NULL DEFAULT 0,
    CONSTRAINT PKDetalleVenta PRIMARY KEY (id_venta, id_producto),
    CONSTRAINT FKDetalleVenta_Venta FOREIGN KEY (id_venta) REFERENCES VentasInfo.Venta(id_venta),
    CONSTRAINT FKDetalleVenta_Producto FOREIGN KEY (id_producto) REFERENCES ProductoInfo.Producto(id_producto)
);


--Utiliza disparador
CREATE TABLE VentasInfo.Apartado (
    id_apartado BIGINT IDENTITY(1,1) NOT NULL,
    id_tarjeta_cliente BIGINT NOT NULL,
    total_apartado DECIMAL(10,2) NOT NULL,
    fecha_creacion DATE NOT NULL,
    fecha_vencimiento DATE NOT NULL,
    saldo_pendiente DECIMAL(10,2), --Ponerle default el total_apartado inicial, Cambia con disparador de abonos (saldo_pendoiente -= abono.cantidad)
    estado VARCHAR(50) NOT NULL, --Se actualiza a liquidado cuando saldo_pendiente sea 0, ver debajo mas instrucciones
	CONSTRAINT PKApartado PRIMARY KEY (id_apartado),
    CONSTRAINT FKApartado_tarjeta FOREIGN KEY (id_tarjeta_cliente) REFERENCES ClientesInfo.Tarjeta_Cliente(id_tarjeta_cliente)
);
--Cuando sea un estado liquitado, se generara una tupla en venta y los respectivos detalles venta

CREATE TABLE VentasInfo.Producto_Apartado (
    id_producto BIGINT NOT NULL,
    id_apartado BIGINT NOT NULL,
    cantidad INT NOT NULL,
    subtotal_apartado DECIMAL(10,2), --Con disparador (cantidad * producto.precio) 
    CONSTRAINT PKProductoApartado PRIMARY KEY (id_producto, id_apartado),
    CONSTRAINT PKProductoApartado_Producto FOREIGN KEY (id_producto) REFERENCES ProductoInfo.Producto(id_producto),
    CONSTRAINT PKProductoApartado_Apartado FOREIGN KEY (id_apartado) REFERENCES VentasInfo.Apartado(id_apartado)
);
ALTER TABLE VentasInfo.Producto_Apartado
ADD CONSTRAINT CHK_Cantidad_Positive CHECK (cantidad > 0);
-- 1. Elimina solo la FK que apunta a Apartado
ALTER TABLE VentasInfo.Producto_Apartado
DROP CONSTRAINT PKProductoApartado_Apartado;
-- 2. Vuelve a crearla con ON DELETE CASCADE
ALTER TABLE VentasInfo.Producto_Apartado
ADD CONSTRAINT FK_ProductoApartado_Apartado
FOREIGN KEY (id_apartado)
REFERENCES VentasInfo.Apartado(id_apartado)
ON DELETE CASCADE;

CREATE TABLE VentasInfo.Abono (
    id_abono BIGINT IDENTITY(1,1) ,
    id_apartado BIGINT NOT NULL,
    cantidad DECIMAL(10,2) NOT NULL,
    fecha_abono DATE NOT NULL,
	CONSTRAINT PKAbono PRIMARY KEY(id_abono),
    CONSTRAINT PKAbono_apartado FOREIGN KEY (id_apartado) REFERENCES VentasInfo.Apartado(id_apartado)
);
-- Elimina la FK actual
ALTER TABLE VentasInfo.Abono
DROP CONSTRAINT PKAbono_apartado;
-- Agrega de nuevo con cascada
ALTER TABLE VentasInfo.Abono
ADD CONSTRAINT FK_Abono_Apartado
FOREIGN KEY (id_apartado)
REFERENCES VentasInfo.Apartado(id_apartado)
ON DELETE CASCADE;


-- Triggers corregidos
-- 1. Comprobar que la cantidad del abono no sea mayor al saldo pendiente
CREATE TRIGGER trg_validar_abono
ON VentasInfo.Abono
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Validar cada fila que se intenta insertar
    IF EXISTS (
        SELECT 1
        FROM INSERTED i
        JOIN VentasInfo.Apartado a ON i.id_apartado = a.id_apartado
        WHERE i.cantidad > a.saldo_pendiente
    )
    BEGIN
        RAISERROR('No se puede abonar más de lo que se debe.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    -- Si todo está bien, hacer el insert manual
    INSERT INTO VentasInfo.Abono (id_apartado, cantidad, fecha_abono)
    SELECT id_apartado, cantidad, fecha_abono
    FROM INSERTED;
END;
Go
--Para UPDATE

CREATE TRIGGER trg_validar_abono_update
ON VentasInfo.Abono
INSTEAD OF UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Validar que la nueva cantidad no exceda el saldo real (sumando la anterior)
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN deleted d ON i.id_abono = d.id_abono
        JOIN VentasInfo.Apartado a ON i.id_apartado = a.id_apartado
        WHERE i.cantidad > (a.saldo_pendiente + d.cantidad)
    )
    BEGIN
        RAISERROR('No puedes actualizar el abono a una cantidad mayor al saldo pendiente.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    -- Hacer el update del abono
    UPDATE ab
    SET ab.cantidad = i.cantidad,
        ab.fecha_abono = i.fecha_abono
    FROM VentasInfo.Abono ab
    JOIN inserted i ON ab.id_abono = i.id_abono;

    -- Recalcular el saldo pendiente con la diferencia
    UPDATE a
    SET saldo_pendiente = saldo_pendiente - (i.cantidad - d.cantidad),
        estado = CASE 
                    WHEN saldo_pendiente - (i.cantidad - d.cantidad) = 0 THEN 'Liquidado'
                    ELSE estado 
                 END
    FROM VentasInfo.Apartado a
    JOIN inserted i ON a.id_apartado = i.id_apartado
    JOIN deleted d ON d.id_abono = i.id_abono;
END;
GO

Go

------

--DROP TRIGGER VentasInfo.trg_AfterInsertProductoApartado;
--Triggers de Apartado y Producto_Apartado
--Triggers de Apartado y Producto_Apartado
--Triggers de Apartado y Producto_Apartado
--Triggers de Apartado y Producto_Apartado
CREATE TRIGGER trg_AfterInsertProductoApartado
ON VentasInfo.Producto_Apartado
AFTER INSERT
AS
BEGIN
    -- 1️⃣ Restar la cantidad apartada de las existencias del producto
    UPDATE p
    SET p.existencias = p.existencias - i.cantidad
    FROM ProductoInfo.Producto p
    INNER JOIN inserted i ON p.id_producto = i.id_producto;

    -- 2️⃣ Aumentar el total y el saldo pendiente del apartado
   UPDATE a
	SET 
		a.total_apartado = a.total_apartado + (i.cantidad * p.precio_producto),
		a.saldo_pendiente = a.saldo_pendiente + (i.cantidad * p.precio_producto)
	FROM VentasInfo.Apartado a
	INNER JOIN inserted i ON a.id_apartado = i.id_apartado
	INNER JOIN ProductoInfo.Producto p ON i.id_producto = p.id_producto;

END;
GO
--DELETE
CREATE TRIGGER trg_AfterDeleteProductoApartado
ON VentasInfo.Producto_Apartado
AFTER DELETE
AS
BEGIN
    -- 1️⃣ Devolver existencias al producto
    UPDATE p
    SET p.existencias = p.existencias + d.cantidad
    FROM ProductoInfo.Producto p
    INNER JOIN deleted d ON p.id_producto = d.id_producto;

    -- 2️⃣ Aumentar el total y el saldo pendiente del apartado
    UPDATE a
	SET 
	a.total_apartado = a.total_apartado - d.subtotal_apartado,
	a.saldo_pendiente = a.saldo_pendiente - d.subtotal_apartado
	FROM VentasInfo.Apartado a
	INNER JOIN deleted d ON a.id_apartado = d.id_apartado;

END;
GO
--UPDATE
CREATE TRIGGER trg_AfterUpdateProductoApartado
ON VentasInfo.Producto_Apartado
AFTER UPDATE
AS
BEGIN
    -- 1️⃣ Si el producto cambió: devolver existencias al anterior y restar al nuevo
    UPDATE p
    SET p.existencias = p.existencias + d.cantidad
    FROM ProductoInfo.Producto p
    INNER JOIN deleted d ON p.id_producto = d.id_producto
    INNER JOIN inserted i ON d.id_apartado = i.id_apartado
    WHERE d.id_producto <> i.id_producto;

    UPDATE p
    SET p.existencias = p.existencias - i.cantidad
    FROM ProductoInfo.Producto p
    INNER JOIN inserted i ON p.id_producto = i.id_producto
    INNER JOIN deleted d ON i.id_apartado = d.id_apartado
    WHERE d.id_producto <> i.id_producto;

    -- 2️⃣ Si solo cambió la cantidad (mismo producto), ajustar la diferencia
    UPDATE p
    SET p.existencias = p.existencias + d.cantidad - i.cantidad
    FROM ProductoInfo.Producto p
    INNER JOIN inserted i ON p.id_producto = i.id_producto
    INNER JOIN deleted d ON i.id_apartado = d.id_apartado
    WHERE d.id_producto = i.id_producto AND d.cantidad <> i.cantidad;

    -- 3️⃣ Ajustar total_apartado y saldo_pendiente
    -- Restamos el subtotal anterior y sumamos el nuevo
    UPDATE a
    SET 
        a.total_apartado = a.total_apartado - d.subtotal_apartado + (i.cantidad * p.precio_producto),
        a.saldo_pendiente = a.saldo_pendiente - d.subtotal_apartado + (i.cantidad * p.precio_producto)
    FROM VentasInfo.Apartado a
    INNER JOIN inserted i ON a.id_apartado = i.id_apartado
    INNER JOIN deleted d ON i.id_apartado = d.id_apartado
    INNER JOIN ProductoInfo.Producto p ON i.id_producto = p.id_producto;
END;
GO


--Triggers de Apartado y Producto_Apartado
--Triggers de Apartado y Producto_Apartado
--Triggers de Apartado y Producto_Apartado
--Triggers de Apartado y Producto_Apartado
-- 2. Actualizar saldo pendiente tras un abono
CREATE TRIGGER trg_AfterInsertAbono
ON VentasInfo.Abono
AFTER INSERT
AS
BEGIN
    UPDATE VentasInfo.Apartado
    SET saldo_pendiente = saldo_pendiente - i.cantidad
    FROM VentasInfo.Apartado a
    INNER JOIN inserted i ON a.id_apartado = i.id_apartado;

	-- Si el saldo pendiente llega a 0, cambiar el estado a "Liquidado"
    UPDATE VentasInfo.Apartado
    SET estado = 'Liquidado'
    WHERE saldo_pendiente = 0;
END;
GO
--En UPDAtE
SELECT name
FROM sys.triggers
WHERE parent_id = OBJECT_ID('VentasInfo.Abono');

CREATE TRIGGER trg_ValidarUpdateAbono
ON VentasInfo.Abono
INSTEAD OF UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Validar que la nueva cantidad no exceda el saldo real
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN deleted d ON i.id_abono = d.id_abono
        JOIN VentasInfo.Apartado a ON i.id_apartado = a.id_apartado
        WHERE i.cantidad > (a.saldo_pendiente + d.cantidad)
    )
    BEGIN
        RAISERROR('No puedes actualizar el abono a una cantidad mayor al saldo pendiente.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    -- Hacer el update del abono
    UPDATE ab
    SET ab.cantidad = i.cantidad,
        ab.fecha_abono = i.fecha_abono
    FROM VentasInfo.Abono ab
    JOIN inserted i ON ab.id_abono = i.id_abono;

    -- Recalcular el saldo pendiente con la diferencia
    UPDATE a
    SET saldo_pendiente = saldo_pendiente - (i.cantidad - d.cantidad),
        estado = CASE WHEN saldo_pendiente - (i.cantidad - d.cantidad) = 0 THEN 'Liquidado' ELSE estado END
    FROM VentasInfo.Apartado a
    JOIN inserted i ON a.id_apartado = i.id_apartado
    JOIN deleted d ON d.id_abono = i.id_abono;
END;
GO

-- Trigger para inicializar saldo_pendiente con total_apartado
CREATE TRIGGER trg_SetSaldoPendiente
ON VentasInfo.Apartado
AFTER INSERT
AS
BEGIN
    UPDATE a
    SET a.saldo_pendiente = a.total_apartado
    FROM VentasInfo.Apartado a
    INNER JOIN inserted i ON a.id_apartado = i.id_apartado;
END;
GO

/*
VENTASVENTASVENTASVENTASVENTASVENTASVENTASVENTASVENTASVENTASVENTAS

VENTASVENTASVENTASVENTASVENTASVENTASVENTASVENTASVENTASVENTASVENTAS
*/
GO
CREATE TRIGGER VentasInfo.trg_AfterInsertVenta
ON VentasInfo.Detalle_Venta
AFTER INSERT
AS
BEGIN
    -- Restar existencias SOLO si la venta NO proviene de un apartado
    UPDATE ProductoInfo.Producto
    SET existencias = existencias - i.cantidad
    FROM ProductoInfo.Producto p
    INNER JOIN inserted i ON p.id_producto = i.id_producto
    LEFT JOIN VentasInfo.Producto_Apartado pa ON i.id_producto = pa.id_producto AND pa.id_apartado = i.id_venta
    WHERE pa.id_apartado IS NULL; -- 🔹 Solo afecta productos que NO provienen de un apartado
	
END;
GO


-- 3. Actualizar total_venta tras una venta
CREATE TRIGGER trg_AfterInsertDetalleVenta
ON VentasInfo.Detalle_Venta
AFTER INSERT
AS
BEGIN
    UPDATE VentasInfo.Venta
    SET total_venta = total_venta + (i.cantidad * p.precio_producto)
    FROM VentasInfo.Venta v
    INNER JOIN inserted i ON v.id_venta = i.id_venta
    INNER JOIN ProductoInfo.Producto p ON i.id_producto = p.id_producto;
END;
GO
-- 4. Actualizar total_compra tras una compra
DROP TRIGGER VentasInfo.trg_AfterInsertDetalleVenta;
GO

CREATE TRIGGER trg_AfterInsertDetalleVenta
ON VentasInfo.Detalle_Venta
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE v
    SET total_venta = (
        SELECT SUM(dv.cantidad * p.precio_producto)
        FROM VentasInfo.Detalle_Venta dv
        INNER JOIN ProductoInfo.Producto p ON dv.id_producto = p.id_producto
        WHERE dv.id_venta = v.id_venta
    )
    FROM VentasInfo.Venta v
    INNER JOIN inserted i ON v.id_venta = i.id_venta;
END;
Go

select * from VentasInfo.Venta
select * from VentasInfo.Detalle_Venta

-- 5. Convertir Apartado en Venta cuando sea liquidado
--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO
--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO
--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO
--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO
--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO--LISTO
DROP TRIGGER VentasInfo.trg_UpdateApartadoToLiquidado;
GO

CREATE TRIGGER trg_UpdateApartadoToLiquidado
ON VentasInfo.Apartado
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificamos que SOLO se haya cambiado un apartado a 'Liquidado'
    IF EXISTS (
        SELECT 1 
        FROM inserted i
        JOIN deleted d ON i.id_apartado = d.id_apartado
        WHERE i.estado = 'Liquidado' AND d.estado <> 'Liquidado'
    )
    BEGIN
        DECLARE @id_apartado BIGINT;
        DECLARE @id_tarjeta_cliente BIGINT;
        DECLARE @total_apartado DECIMAL(10, 2);
        DECLARE @id_venta BIGINT;

        -- Obtenemos los datos del apartado que se acaba de liquidar
        SELECT 
            @id_apartado = i.id_apartado,
            @id_tarjeta_cliente = i.id_tarjeta_cliente,
            @total_apartado = i.total_apartado
        FROM inserted i
        JOIN deleted d ON i.id_apartado = d.id_apartado
        WHERE i.estado = 'Liquidado' AND d.estado <> 'Liquidado';

		-- Reponer existencias antes de convertir el producto apartado a venta
		UPDATE p
		SET p.existencias = p.existencias + pa.cantidad
		FROM ProductoInfo.Producto p
		INNER JOIN VentasInfo.Producto_Apartado pa ON p.id_producto = pa.id_producto
		WHERE pa.id_apartado = @id_apartado;

        -- Insertamos en Venta
        INSERT INTO VentasInfo.Venta (id_tarjeta_cliente, fecha_venta, total_venta)
        VALUES (@id_tarjeta_cliente, GETDATE(), 0);

        -- Capturamos el ID de venta recién generado
        SET @id_venta = SCOPE_IDENTITY();

        -- Insertamos los productos del apartado en Detalle_Venta
        INSERT INTO VentasInfo.Detalle_Venta (id_venta, id_producto, cantidad, subtotal_venta)
        SELECT @id_venta, pa.id_producto, pa.cantidad, pa.subtotal_apartado
        FROM VentasInfo.Producto_Apartado pa
        WHERE pa.id_apartado = @id_apartado;
    END;
END;
GO


--Regla tipos de estados
GO
CREATE RULE Rule_EstadoApartado
	AS @valor IN ('En proceso', 'Liquidado');
GO

sp_bindrule 'Rule_EstadoApartado', 'VentasInfo.Apartado.estado';
GO

-- RULE PARA CANTIDADES MAYOR A 0
CREATE RULE Rule_CantidadPositiva
	as @valor > 0;
GO

sp_bindrule 'Rule_CantidadPositiva', 'VentasInfo.Producto_Apartado.cantidad';
GO

sp_bindrule 'Rule_CantidadPositiva', 'VentasInfo.Detalle_Venta.cantidad';
GO







--Productos
INSERT INTO ProductoInfo.Producto (nombre_producto, precio_producto, existencias) VALUES
('Calabaza', 100, 50),
('Rosca', 500, 30),
('Pie de Zanahora', 200, 20)

INSERT INTO ProductoInfo.Producto (nombre_producto, precio_producto, existencias) VALUES
('Conejo Pascua Grande', 500, 10)

--Temporadas
INSERT INTO ProductoInfo.Temporada (nombre, fecha_inicio, fecha_fin) VALUES
('Primavera 2025', '2025-03-01', '2025-05-31'),
('Verano 2025', '2025-06-01', '2025-08-31'),
('Otoño 2025', '2025-09-01', '2025-11-30')

INSERT INTO ProductoInfo.Temporada (nombre, fecha_inicio, fecha_fin) VALUES
('Pascua', '2025-02-17', '2025-05-31')
--Producto Temporada
INSERT INTO ProductoInfo.Producto_Temporada (id_producto, id_temporada) VALUES
(1, 1), -- Camiseta Dry-Fit en Primavera
(2, 2), -- Pantalones Deportivos en Verano
(3, 3) -- Sudadera Oversize en Otoño


--Clientes
INSERT INTO ClientesInfo.Cliente (nombre_cliente, direccion_cliente, telefono_cliente, correo_cliente)
VALUES ('Juan Pérez', 'Calle Falsa 123, Ciudad', '555-123-4567', 'juan.perez@email.com');

INSERT INTO ClientesInfo.Cliente (nombre_cliente, direccion_cliente, telefono_cliente, correo_cliente)
VALUES ('María González', 'Avenida Central 456, Ciudad', '555-987-6543', 'maria.gonzalez@email.com');

--Tarjetas
INSERT INTO ClientesInfo.Tarjeta_Cliente (id_cliente, numero_tarjeta, tipo, banco, codigo_seguridad, fecha_vencimiento)
VALUES (1, '1234567890123456', 'Crédito', 'BBVA', '123', '2026-07-01');

INSERT INTO ClientesInfo.Tarjeta_Cliente (id_cliente, numero_tarjeta, tipo, banco, codigo_seguridad, fecha_vencimiento)
VALUES (2, '9876543210987654', 'Débito', 'Santander', '456', '2025-12-01');

select * from ClientesInfo.Tarjeta_Cliente


--Apartado
select * from VentasInfo.Apartado

select * from ProductoInfo.Producto

SELECT id_producto, id_apartado, cantidad, subtotal_apartado FROM VentasInfo.Producto_Apartado

select * from ClientesInfo.Tarjeta_Cliente


select * from VentasInfo.Producto_Apartado

update VentasInfo.Apartado set saldo_pendiente = 5500 where id_apartado = 2
delete from VentasInfo.Abono where id_apartado = 2

INSERT INTO VentasInfo.Abono (id_apartado, cantidad, fecha_abono)
VALUES (3, 100, GETDATE());



select * from VentasInfo.Apartado

select * from VentasInfo.Producto_Apartado

select * from VentasInfo.Venta

select * from VentasInfo.Detalle_Venta
