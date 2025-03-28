﻿-- Crear la base de datos
USE master;
DROP DATABASE TiendaDeTemporada;
CREATE DATABASE TiendaDeTemporada;
USE TiendaDeTemporada;

-- Esquemas de tablas
CREATE SCHEMA ClientesInfo AUTHORIZATION dbo;
CREATE SCHEMA ComprasInfo AUTHORIZATION dbo;
CREATE SCHEMA ProductoInfo AUTHORIZATION dbo;
CREATE SCHEMA VentasInfo AUTHORIZATION dbo;

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
    CONSTRAINT FKProductoTemporada_Temporada FOREIGN KEY (id_temporada) REFERENCES ProductoInfo.Temporada(id_temporada)
);

TRUNCATE TABLE ProductoInfo.Producto_Temporada;

ALTER TABLE ProductoInfo.Producto_Temporada
ADD CONSTRAINT UQ_ProductoTemporada UNIQUE (id_producto, id_temporada);



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


CREATE TABLE VentasInfo.Abono (
    id_abono BIGINT IDENTITY(1,1) ,
    id_apartado BIGINT NOT NULL,
    cantidad DECIMAL(10,2) NOT NULL,
    fecha_abono DATE NOT NULL,
	CONSTRAINT PKAbono PRIMARY KEY(id_abono),
    CONSTRAINT PKAbono_apartado FOREIGN KEY (id_apartado) REFERENCES VentasInfo.Apartado(id_apartado)
);


-- Triggers corregidos
-- 1. Actualizar existencias tras una venta
CREATE TRIGGER trg_AfterInsertVenta
ON VentasInfo.Detalle_Venta
AFTER INSERT
AS
BEGIN
    UPDATE ProductoInfo.Producto
    SET existencias = existencias - i.cantidad
    FROM ProductoInfo.Producto p
    INNER JOIN inserted i ON p.id_producto = i.id_producto;
END;

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

-- 4. Actualizar total_compra tras una compra
CREATE TRIGGER trg_AfterInsertDetalleCompra
ON ComprasInfo.Detalle_Compra
AFTER INSERT
AS
BEGIN
    UPDATE ComprasInfo.Compra
    SET total_compra = total_compra + (i.cantidad * p.precio_producto)
    FROM ComprasInfo.Compra c
    INNER JOIN inserted i ON c.id_compra = i.id_compra
    INNER JOIN ProductoInfo.Producto p ON i.id_producto = p.id_producto;
END;

-- 5. Convertir Apartado en Venta cuando sea liquidado
CREATE TRIGGER trg_UpdateApartadoToLiquidado
ON VentasInfo.Apartado
AFTER UPDATE
AS
BEGIN
    -- 1️⃣ Verificamos si algún apartado cambió su estado a 'Liquidado'
    IF EXISTS (
        SELECT 1 
        FROM inserted i
        JOIN deleted d ON i.id_apartado = d.id_apartado
        WHERE i.estado = 'Liquidado' AND d.estado <> 'Liquidado'
    )
    BEGIN
        -- 2️⃣ Declaramos una tabla temporal para almacenar los IDs de ventas generados
        DECLARE @ventas TABLE (id_apartado BIGINT, id_venta BIGINT);

        -- 3️⃣ Insertamos en la tabla de ventas y capturamos los IDs generados
        INSERT INTO VentasInfo.Venta (id_tarjeta_cliente, fecha_venta, total_venta)
        SELECT i.id_tarjeta_cliente, GETDATE(), i.total_apartado
        FROM inserted i
        WHERE i.estado = 'Liquidado';

        -- 4️⃣ Guardamos la relación id_apartado ↔ id_venta en la tabla temporal
        INSERT INTO @ventas (id_apartado, id_venta)
        SELECT i.id_apartado, v.id_venta
        FROM inserted i
        JOIN VentasInfo.Venta v ON i.id_tarjeta_cliente = v.id_tarjeta_cliente
        WHERE i.estado = 'Liquidado';

        -- 5️⃣ Insertamos los detalles de la venta tomando los productos del apartado
        INSERT INTO VentasInfo.Detalle_Venta (id_venta, id_producto, cantidad, subtotal_venta)
        SELECT v.id_venta, pa.id_producto, pa.cantidad, pa.subtotal_apartado
        FROM VentasInfo.Producto_Apartado pa
        JOIN @ventas v ON pa.id_apartado = v.id_apartado;
    END;
END;






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



--Regla tipos de estados
CREATE RULE Rule_EstadoApartado
	AS @valor IN ('En proceso', 'Liquidado');

sp_bindrule 'Rule_EstadoApartado', 'VentasInfo.Apartado.estado';

-- RULE PARA CANTIDADES MAYOR A 0
CREATE RULE Rule_CantidadPositiva
	as @valor > 0;

sp_bindrule 'Rule_CantidadPositiva', 'VentasInfo.Producto_Apartado.cantidad';
sp_bindrule 'Rule_CantidadPositiva', 'VentasInfo.Detalle_Venta.cantidad';


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
select * from Clientes


SELECT 
    pa.id_producto AS IdProducto, 
    t.nombre AS NombreTemporada, 
	cantidad AS Cantidad,
    pa.subtotal_apartado AS Subtotal
FROM VentasInfo.Producto_Apartado pa
INNER JOIN ProductoInfo.Producto p ON pa.id_producto = p.id_producto
INNER JOIN ProductoInfo.Producto_Temporada pt ON pa.id_producto = pt.id_producto  -- 🔥 Condición de JOIN corregida
INNER JOIN ProductoInfo.Temporada t ON pt.id_temporada = t.id_temporada;


