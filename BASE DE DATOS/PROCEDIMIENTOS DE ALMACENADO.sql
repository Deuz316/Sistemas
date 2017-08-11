USE [VENTAS]
GO

CREATE PROCEDURE GUARDAR_CLIENTE
  @ID_CLIENTE INT,
  @IDENTIFICACION NVARCHAR(MAX),
  @RAZON_SOCIAL NVARCHAR(100),
  @FECHA_NACIMIENTO DATE,
  @DIRECCION NVARCHAR(MAX),
  @CONTACTO NVARCHAR(30),
  @TELEFONO NVARCHAR(MAX),
  @CORREO NVARCHAR(100),
  @VEDENDOR INT,
  @SALDO FLOAT,
  @LIMITE_CREDITO FLOAT,
  @LIMITE_DESCUENTO FLOAT,
  @PLAZO FLOAT,
  @CLASIFICACION NVARCHAR(3),
  @ACTIVO BIT
AS
  BEGIN
    INSERT CLIENTE VALUES(
    @ID_CLIENTE,
    @IDENTIFICACION,
    @RAZON_SOCIAL,
    @FECHA_NACIMIENTO,
    @DIRECCION,
    @CONTACTO,
    @TELEFONO,
    @CORREO,
    @VEDENDOR,
    @SALDO,
    @LIMITE_CREDITO,
    @LIMITE_DESCUENTO,
    @PLAZO,
    @CLASIFICACION,
    @ACTIVO)
  END
GO

CREATE PROCEDURE MODIFICAR_CLIENTE
  @ID_CLIENTE INT,
  @IDENTIFICACION NVARCHAR(MAX),
  @RAZON_SOCIAL NVARCHAR(100),
  @FECHA_NACIMIENTO DATE,
  @DIRECCION NVARCHAR(MAX),
  @CONTACTO NVARCHAR(30),
  @TELEFONO NVARCHAR(MAX),
  @CORREO NVARCHAR(100),
  @VEDENDOR INT,
  @SALDO FLOAT,
  @LIMITE_CREDITO FLOAT,
  @LIMITE_DESCUENTO FLOAT,
  @PLAZO FLOAT,
  @CLASIFICACION NVARCHAR(3),
  @ACTIVO BIT
AS
  BEGIN
    UPDATE CLIENTE SET
      ID_CLIENTE = @ID_CLIENTE,
      IDENTIFICACION = @IDENTIFICACION,
      RAZON_SOCIAL = @RAZON_SOCIAL,
      FECHA_NACIMIENTO = @FECHA_NACIMIENTO,
      DIRECCION = @DIRECCION,
      CONTACTO = @CONTACTO,
      TELEFONO = @TELEFONO,
      CORREO = @CORREO,
      VEDENDOR = @VEDENDOR,
      SALDO = @SALDO,
      LIMITE_CREDITO = @LIMITE_CREDITO,
      LIMITE_DESCUENTO = @LIMITE_DESCUENTO,
      PLAZO = @PLAZO,
      CLASIFICACION = @CLASIFICACION,
      ACTIVO = @ACTIVO
    WHERE ID_CLIENTE = @ID_CLIENTE
  END
GO

CREATE PROCEDURE ELIMINAR_CLIENTE
  @ID_CLIENTE NVARCHAR(30)
AS
  BEGIN
    DELETE CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE
  END
GO

CREATE PROCEDURE GESTIONAR_CLIENTE
  @ID_CLIENTE INT,
  @IDENTIFICACION NVARCHAR(MAX),
  @RAZON_SOCIAL NVARCHAR(100),
  @FECHA_NACIMIENTO DATE,
  @DIRECCION NVARCHAR(MAX),
  @CONTACTO NVARCHAR(30),
  @TELEFONO NVARCHAR(MAX),
  @CORREO NVARCHAR(100),
  @VEDENDOR INT,
  @SALDO FLOAT,
  @LIMITE_CREDITO FLOAT,
  @LIMITE_DESCUENTO FLOAT,
  @PLAZO FLOAT,
  @CLASIFICACION NVARCHAR(3),
  @ACTIVO BIT,
  @GESTION INT
AS
  BEGIN
    IF @GESTION = 1
      EXEC GUARDAR_CLIENTE
          @ID_CLIENTE,
          @IDENTIFICACION,
          @RAZON_SOCIAL,
          @FECHA_NACIMIENTO,
          @DIRECCION,
          @CONTACTO,
          @TELEFONO,
          @CORREO,
          @VEDENDOR,
          @SALDO,
          @LIMITE_CREDITO,
          @LIMITE_DESCUENTO,
          @PLAZO,
          @CLASIFICACION,
          @ACTIVO
    ELSE
    IF @GESTION = 2
      EXEC MODIFICAR_CLIENTE
          @ID_CLIENTE,
          @IDENTIFICACION,
          @RAZON_SOCIAL,
          @FECHA_NACIMIENTO,
          @DIRECCION,
          @CONTACTO,
          @TELEFONO,
          @CORREO,
          @VEDENDOR,
          @SALDO,
          @LIMITE_CREDITO,
          @LIMITE_DESCUENTO,
          @PLAZO,
          @CLASIFICACION,
          @ACTIVO
    ELSE
    IF @GESTION = 3
      EXEC ELIMINAR_CLIENTE @ID_CLIENTE
  END
GO

CREATE PROCEDURE GUARDAR_PAIS
  @PAIS NVARCHAR(100),
  @CAPITAL NVARCHAR(50)
AS
  BEGIN
    INSERT PAIS (PAIS, CAPITAL) VALUES (@PAIS, @CAPITAL)
  END
GO

CREATE PROCEDURE MODIFICAR_PAIS
  @ID_PAIS INT,
  @PAIS NVARCHAR(100),
  @CAPITAL NVARCHAR(50)
AS
  BEGIN
      UPDATE PAIS SET
        PAIS = @PAIS,
        CAPITAL = @CAPITAL
      WHERE ID_PAIS = @ID_PAIS
  END
GO

CREATE PROCEDURE ELIMINAR_PAIS
  @ID_PAIS INT
AS
  BEGIN
    DELETE PAIS WHERE ID_PAIS = @ID_PAIS
  END
GO

CREATE PROCEDURE GESTIONAR_PAIS
  @ID_PAIS INT,
  @PAIS NVARCHAR(100),
  @CAPITAL NVARCHAR(50),
  @GESTION INT
AS
  BEGIN
    IF @GESTION = 1
      EXEC GUARDAR_PAIS @PAIS, @CAPITAL
    ELSE
    IF @GESTION = 2
      EXEC MODIFICAR_PAIS @ID_PAIS, @PAIS, @CAPITAL
    ELSE
    IF @GESTION = 3
      EXEC ELIMINAR_PAIS @ID_PAIS
  END
GO

CREATE PROCEDURE GUARDAR_PROVEEDOR
  @ID_PROVEEDOR INT,
  @TIPO_PROVEEDOR INT,
  @IDENTIFICACION NVARCHAR(MAX),
  @RAZON_SOCIAL NVARCHAR(100),
  @PAIS INT,
  @DIRECCION NVARCHAR(MAX),
  @CONTACTO NVARCHAR(30),
  @TELEFONO NVARCHAR(MAX),
  @CORREO NVARCHAR(100),
  @SALDO FLOAT,
  @LIMITE_CREDITO FLOAT,
  @TIEMPO_ENTREGA FLOAT,
  @CLASIFICACION NVARCHAR(3),
  @ACTIVO BIT
AS
  BEGIN
    INSERT PROVEEDOR VALUES(
    @ID_PROVEEDOR,
    @TIPO_PROVEEDOR,
    @IDENTIFICACION,
    @RAZON_SOCIAL,
    @PAIS,
    @DIRECCION,
    @CONTACTO,
    @TELEFONO,
    @CORREO,
    @SALDO,
    @LIMITE_CREDITO,
    @TIEMPO_ENTREGA,
    @CLASIFICACION,
    @ACTIVO)
  END
GO

CREATE PROCEDURE MODIFICAR_PROVEEDOR
  @ID_PROVEEDOR INT,
  @TIPO_PROVEEDOR INT,
  @IDENTIFICACION NVARCHAR(MAX),
  @RAZON_SOCIAL NVARCHAR(100),
  @PAIS INT,
  @DIRECCION NVARCHAR(MAX),
  @CONTACTO NVARCHAR(30),
  @TELEFONO NVARCHAR(MAX),
  @CORREO NVARCHAR(100),
  @SALDO FLOAT,
  @LIMITE_CREDITO FLOAT,
  @TIEMPO_ENTREGA FLOAT,
  @CLASIFICACION NVARCHAR(3),
  @ACTIVO BIT
AS
  BEGIN
    UPDATE PROVEEDOR SET
      ID_PROVEEDOR = @ID_PROVEEDOR,
      TIPO_PROVEEDOR = @TIPO_PROVEEDOR,
      IDENTIFICACION = @IDENTIFICACION,
      RAZON_SOCIAL = @RAZON_SOCIAL,
      PAIS = @PAIS,
      DIRECCION = @DIRECCION,
      CONTACTO = @CONTACTO,
      TELEFONO = @TELEFONO,
      CORREO = @CORREO,
      SALDO = @SALDO,
      LIMITE_CREDITO = @LIMITE_CREDITO,
      TIEMPO_ENTREGA = @TIEMPO_ENTREGA,
      CLASIFICACION = @CLASIFICACION,
      ACTIVO = @ACTIVO
    WHERE ID_PROVEEDOR = @ID_PROVEEDOR
  END
GO

CREATE PROCEDURE ELIMINAR_PROVEEDOR
  @ID_PROVEEDOR INT
AS
  BEGIN
    DELETE PROVEEDOR WHERE ID_PROVEEDOR = @ID_PROVEEDOR
  END
GO

CREATE PROCEDURE GESTIONAR_PROVEEDOR
  @ID_PROVEEDOR INT,
  @TIPO_PROVEEDOR INT,
  @IDENTIFICACION NVARCHAR(MAX),
  @RAZON_SOCIAL NVARCHAR(100),
  @PAIS INT,
  @DIRECCION NVARCHAR(MAX),
  @CONTACTO NVARCHAR(30),
  @TELEFONO NVARCHAR(MAX),
  @CORREO NVARCHAR(100),
  @SALDO FLOAT,
  @LIMITE_CREDITO FLOAT,
  @TIEMPO_ENTREGA FLOAT,
  @CLASIFICACION NVARCHAR(3),
  @ACTIVO BIT,
  @GESTION INT
AS
  BEGIN
    IF @GESTION = 1
      EXEC GUARDAR_PROVEEDOR
        @ID_PROVEEDOR,
        @TIPO_PROVEEDOR,
        @IDENTIFICACION,
        @RAZON_SOCIAL,
        @PAIS,
        @DIRECCION,
        @CONTACTO,
        @TELEFONO,
        @CORREO,
        @SALDO,
        @LIMITE_CREDITO,
        @TIEMPO_ENTREGA,
        @CLASIFICACION,
        @ACTIVO
    ELSE
    IF @GESTION = 2
      EXEC MODIFICAR_PROVEEDOR
        @ID_PROVEEDOR,
        @TIPO_PROVEEDOR,
        @IDENTIFICACION,
        @RAZON_SOCIAL,
        @PAIS,
        @DIRECCION,
        @CONTACTO,
        @TELEFONO,
        @CORREO,
        @SALDO,
        @LIMITE_CREDITO,
        @TIEMPO_ENTREGA,
        @CLASIFICACION,
        @ACTIVO
    ELSE
    IF @GESTION = 3
      EXEC ELIMINAR_PROVEEDOR @ID_PROVEEDOR
  END
GO

CREATE PROCEDURE GUARDAR_MARCA
  @ID_MARCA INT,
  @NOMBRE NVARCHAR(100)
AS
  BEGIN
    INSERT MARCA VALUES (@ID_MARCA, @NOMBRE)
  END
GO

CREATE PROCEDURE MODIFICAR_MARCA
  @ID_MARCA INT,
  @NOMBRE NVARCHAR(30)
AS
  BEGIN
    UPDATE MARCA SET
      ID_MARCA = @ID_MARCA,
      NOMBRE = @NOMBRE
    WHERE ID_MARCA = @ID_MARCA
  END
GO

CREATE PROCEDURE ELIMINAR_MARCA
@ID_MARCA INT
AS
  BEGIN
    DELETE MARCA WHERE ID_MARCA = @ID_MARCA
  END
GO

CREATE PROCEDURE GESTIONAR_MARCA
  @ID_MARCA INT,
  @NOMBRE NVARCHAR(100),
  @GESTION INT
AS
  BEGIN
    IF @GESTION = 1
      EXEC GUARDAR_MARCA @ID_MARCA, @NOMBRE
    ELSE
    IF @GESTION = 2
      EXEC MODIFICAR_MARCA @ID_MARCA, @NOMBRE
    ELSE
    IF @GESTION = 3
      EXEC ELIMINAR_MARCA @ID_MARCA
  END
GO

CREATE PROCEDURE GUARDAR_CATEGORIA
  @ID_CATEGORIA INT,
  @NOMBRE NVARCHAR(100)
AS
  BEGIN
    INSERT CATEGORIA VALUES (@ID_CATEGORIA, @NOMBRE)
  END
GO

CREATE PROCEDURE MODIFICAR_CATEGORIA
  @ID_CATEGORIA INT,
  @NOMBRE NVARCHAR(100)
AS
  BEGIN
    UPDATE CATEGORIA SET
      ID_CATEGORIA = @ID_CATEGORIA,
      NOMBRE = @NOMBRE
    WHERE ID_CATEGORIA = @ID_CATEGORIA
  END
GO

CREATE PROCEDURE ELIMINAR_CATEGORIA
  @ID_CATEGORIA INT
AS
  BEGIN
    DELETE CATEGORIA WHERE ID_CATEGORIA = @ID_CATEGORIA
  END
GO

CREATE PROCEDURE GUARDAR_TIPO_PRODUCTO
  @ID_TIPO INT,
  @NOMBRE NVARCHAR(100)
AS
  BEGIN
    INSERT TIPO_PRODUCTO VALUES (@ID_TIPO, @NOMBRE)
  END
GO

CREATE PROCEDURE MODIFICAR_TIPO_PRODUCTO
  @ID_TIPO INT,
  @NOMBRE NVARCHAR(100)
AS
  BEGIN
    UPDATE TIPO_PRODUCTO SET
      ID_TIPO = @ID_TIPO,
      NOMBRE = @NOMBRE
    WHERE ID_TIPO = @ID_TIPO
  END
GO

CREATE PROCEDURE ELIMINAR_TIPO_PRODUCTO
  @ID_TIPO INT
AS
  BEGIN
    DELETE TIPO_PRODUCTO WHERE ID_TIPO = @ID_TIPO
  END
GO

CREATE PROCEDURE GESTIONAR_TIPO_PRODUCTO
  @ID_TIPO INT,
  @NOMBRE NVARCHAR(100),
  @GESTION INT
AS
  BEGIN
    IF @GESTION = 1
      EXEC GUARDAR_TIPO_PRODUCTO @ID_TIPO, @NOMBRE
    ELSE
    IF @GESTION = 2
      EXEC MODIFICAR_TIPO_PRODUCTO @ID_TIPO, @NOMBRE
    ELSE
    IF @GESTION = 3
      EXEC ELIMINAR_TIPO_PRODUCTO @ID_TIPO
  END
GO

CREATE PROCEDURE GUARDAR_UNIDAD_MEDIDA
  @ID_UDM INT,
  @NOMBRE NVARCHAR(100),
  @REPRESENTACION NVARCHAR(10)
AS
  BEGIN
    INSERT UNIDAD_MEDIDA VALUES (@ID_UDM, @NOMBRE, @REPRESENTACION)
  END
GO

CREATE PROCEDURE MODIFICAR_UNIDAD_MEDIDA
  @ID_UDM INT,
  @NOMBRE NVARCHAR(100),
  @REPRESENTACION NVARCHAR(10)
AS
  BEGIN
    UPDATE UNIDAD_MEDIDA SET
      ID_UDM = @ID_UDM,
      NOMBRE = @NOMBRE,
      REPRESENTACION = @REPRESENTACION
    WHERE ID_UDM = @ID_UDM
  END
GO

CREATE PROCEDURE ELIMINAR_UNIDAD_MEDIDA
  @ID_UDM INT
AS
  BEGIN
    DELETE UNIDAD_MEDIDA WHERE ID_UDM = @ID_UDM
  END
GO

CREATE PROCEDURE GESTIONAR_UNIDAD_MEDIDA
  @ID_UDM INT,
  @NOMBRE NVARCHAR(100),
  @REPRESENTACION NVARCHAR(10),
  @GESTION INT
AS
  BEGIN
    IF @GESTION = 1
      EXEC GUARDAR_UNIDAD_MEDIDA @ID_UDM, @NOMBRE, @REPRESENTACION
    ELSE
    IF @GESTION = 2
      EXEC MODIFICAR_UNIDAD_MEDIDA @ID_UDM, @NOMBRE, @REPRESENTACION
    ELSE
    IF @GESTION = 3
      EXEC ELIMINAR_UNIDAD_MEDIDA @ID_UDM
  END
GO

CREATE PROCEDURE GUARDAR_PRODUCTO
  @ID NVARCHAR(30),
  @CODIGO_COMPUESTO NVARCHAR(30),
  @CODIGO_BARRA NVARCHAR(100),
  @PRODUCTO NVARCHAR(100),
  @MARCA INT,
  @CATEGORIA INT,
  @TIPO INT,
  @UDM INT,
  @FOB FLOAT,
  @CIF FLOAT,
  @MINIMO FLOAT,
  @MAXIMO FLOAT,
  @CLASIFICACION NVARCHAR(3),
  @SERVICIO BIT,
  @IMPUESTO BIT,
  @LOCAL BIT,
  @ACTIVO BIT
AS
  BEGIN
    INSERT PRODUCTOS VALUES(
    @ID,
    @CODIGO_COMPUESTO,
    @CODIGO_BARRA,
    @PRODUCTO,
    @MARCA,
    @CATEGORIA,
    @TIPO,
    @UDM,
    @FOB,
    @CIF,
    @MINIMO,
    @MAXIMO,
    @CLASIFICACION,
    @SERVICIO,
    @IMPUESTO,
    @LOCAL,
    @ACTIVO)
  END
GO

CREATE PROCEDURE MODIFICAR_PRODUCTO
  @ID NVARCHAR(30),
  @CODIGO_COMPUESTO NVARCHAR(30),
  @CODIGO_BARRA NVARCHAR(100),
  @PRODUCTO NVARCHAR(100),
  @MARCA INT,
  @CATEGORIA INT,
  @TIPO INT,
  @UDM INT,
  @FOB FLOAT,
  @CIF FLOAT,
  @MINIMO FLOAT,
  @MAXIMO FLOAT,
  @CLASIFICACION NVARCHAR(3),
  @SERVICIO BIT,
  @IMPUESTO BIT,
  @LOCAL BIT,
  @ACTIVO BIT
AS
  BEGIN
    UPDATE PRODUCTO SET
      ID = @ID,
      CODIGO_COMPUESTO = @CODIGO_COMPUESTO,
      CODIGO_BARRA = @CODIGO_BARRA,
      PRODUCTO = @PRODUCTO,
      MARCA = @MARCA,
      CATEGORIA = @CATEGORIA,
      TIPO = @TIPO,
      UDM = @UDM,
      FOB = @FOB,
      CIF = @CIF,
      MINIMO = @MINIMO,
      MAXIMO = @MAXIMO,
      CLASIFICACION = @CLASIFICACION,
      SERVICIO = @SERVICIO,
      IMPUESTO = @IMPUESTO,
      LOCAL = @LOCAL,
      ACTIVO = @ACTIVO
    WHERE ID = @ID
  END
GO

CREATE PROCEDURE ELIMINAR_PRODUCTO
  @ID INT
AS
  BEGIN
    DELETE PRODUCTOS WHERE ID = @ID
  END
GO

CREATE PROCEDURE GESTIONAR_PRODUCTO
  @ID NVARCHAR(30),
  @CODIGO_COMPUESTO NVARCHAR(30),
  @CODIGO_BARRA NVARCHAR(100),
  @PRODUCTO NVARCHAR(100),
  @MARCA INT,
  @CATEGORIA INT,
  @TIPO INT,
  @UDM INT,
  @FOB FLOAT,
  @CIF FLOAT,
  @MINIMO FLOAT,
  @MAXIMO FLOAT,
  @CLASIFICACION NVARCHAR(3),
  @SERVICIO BIT,
  @IMPUESTO BIT,
  @LOCAL BIT,
  @ACTIVO BIT,
  @GESTION INT
AS
  BEGIN
    IF @GESTION = 1
      EXEC GUARDAR_PRODUCTO
        @ID,
        @CODIGO_COMPUESTO,
        @CODIGO_BARRA,
        @PRODUCTO,
        @MARCA,
        @CATEGORIA,
        @TIPO,
        @UDM,
        @FOB,
        @CIF,
        @MINIMO,
        @MAXIMO,
        @CLASIFICACION,
        @SERVICIO,
        @IMPUESTO,
        @LOCAL,
        @ACTIVO
    ELSE
    IF @GESTION = 2
      EXEC MODIFICAR_PRODUCTO
        @ID,
        @CODIGO_COMPUESTO,
        @CODIGO_BARRA,
        @PRODUCTO,
        @MARCA,
        @CATEGORIA,
        @TIPO,
        @UDM,
        @FOB,
        @CIF,
        @MINIMO,
        @MAXIMO,
        @CLASIFICACION,
        @SERVICIO,
        @IMPUESTO,
        @LOCAL,
        @ACTIVO
    ELSE
    IF @GESTION = 3
      EXEC ELIMINAR_PRODUCTO @ID
  END
GO

CREATE PROCEDURE GUARDAR_TIPO_BODEGA
  @ID_TIPO_BODEGA INT,
  @DESCRIPCION NVARCHAR(100)
AS
    BEGIN
      INSERT TIPO_BODEGA VALUES (@ID_TIPO_BODEGA, @DESCRIPCION)
    END
GO

CREATE PROCEDURE MODIFICAR_TIPO_BODEGA
  @ID_TIPO_BODEGA INT,
  @DESCRIPCION NVARCHAR(100)
AS
  BEGIN
    UPDATE TIPO_BODEGA SET
      ID_TIPO_BODEGA = @ID_TIPO_BODEGA,
      DESCRIPCION = @DESCRIPCION
    WHERE ID_TIPO_BODEGA = @ID_TIPO_BODEGA
  END
GO

CREATE PROCEDURE ELIMINAR_TIPO_BODEGA
  @ID_TIPO_BODEGA INT
AS
    BEGIN
      DELETE TIPO_BODEGA WHERE ID_TIPO_BODEGA = @ID_TIPO_BODEGA
    END
GO

CREATE PROCEDURE GESTIONAR_TIPO_BODEGA
  @ID_TIPO_BODEGA INT,
  @DESCRIPCION NVARCHAR(100),
  @GESTION INT
AS
  BEGIN
    IF @GESTION = 1
      EXEC GUARDAR_TIPO_BODEGA @ID_TIPO_BODEGA, @DESCRIPCION
    ELSE
    IF @GESTION = 2
      EXEC MODIFICAR_TIPO_BODEGA @ID_TIPO_BODEGA, @DESCRIPCION
    ELSE
    IF @GESTION = 3
      EXEC ELIMINAR_TIPO_BODEGA @ID_TIPO_BODEGA
  END
GO

CREATE PROCEDURE GUARDAR_BODEGA
  @ID_BODEGA NVARCHAR(30),
  @ID_TIPO_BODEGA INT,
  @DESCRIPCION NVARCHAR(100),
  @COMENTARIO NVARCHAR(MAX),
  @ACTIVO BIT
AS
  BEGIN
    INSERT BODEGA VALUES(
    @ID_BODEGA,
    @ID_TIPO_BODEGA,
    @DESCRIPCION,
    @COMENTARIO,
    @ACTIVO)
  END
GO

CREATE PROCEDURE MODIFICAR_BODEGA
  @ID_BODEGA NVARCHAR(30),
  @ID_TIPO_BODEGA INT,
  @DESCRIPCION NVARCHAR(100),
  @COMENTARIO NVARCHAR(MAX),
  @ACTIVO BIT
AS
  BEGIN
    UPDATE BODEGA SET
      ID_BODEGA = @ID_BODEGA,
      ID_TIPO_BODEGA = @ID_TIPO_BODEGA,
      DESCRIPCION = @DESCRIPCION,
      COMENTARIO = @COMENTARIO,
      ACTIVO = @ACTIVO
    WHERE ID_BODEGA = @ID_BODEGA
  END
GO

CREATE PROCEDURE ELIMINAR_BODEGA
  @ID_BODEGA INT
AS
  BEGIN
    DELETE BODEGA WHERE ID_BODEGA = @ID_BODEGA
  END
GO

CREATE PROCEDURE GUARDAR_MIGRACION_INVENTARIO
  @BODEGA NVARCHAR(100),
  @CODIGO NVARCHAR(30),
  @CODIGO_BARRA NVARCHAR(100),
  @PRODUCTO NVARCHAR(100),
  @MARCA NVARCHAR(100),
  @CATEGORIA NVARCHAR(100),
  @TIPO NVARCHAR(100),
  @UDM NVARCHAR(100),
  @FOB FLOAT,
  @CIF FLOAT,
  @PRECIO FLOAT,
  @EXISTENCIAS FLOAT,
  @RACK NVARCHAR(10),
  @COLUMNA NVARCHAR(10),
  @FILA NVARCHAR(10),
  @MINIMO FLOAT,
  @MAXIMO FLOAT,
  @CLASIFICACION NVARCHAR(3),
  @SERVICIO NVARCHAR(1),
  @IMPUESTO NVARCHAR(1),
  @ACTIVO NVARCHAR(1),
  @LOCAL NVARCHAR(1)
AS
  BEGIN
    INSERT MIGRAR_INVENTARIO VALUES(
    @BODEGA,
    @CODIGO,
    @CODIGO_BARRA,
    @PRODUCTO,
    @MARCA,
    @CATEGORIA,
    @TIPO,
    @UDM,
    @FOB,
    @CIF,
    @PRECIO,
    @EXISTENCIAS,
    @RACK,
    @COLUMNA,
    @FILA,
    @MINIMO,
    @MAXIMO,
    @CLASIFICACION,
    @SERVICIO,
    @IMPUESTO,
    @ACTIVO,
    @LOCAL)
  END
GO