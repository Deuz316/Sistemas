CREATE DATABASE [VENTAS]
GO

USE [VENTAS]
GO

CREATE TABLE EMPRESAS
(
  ID_EMPRESA INT PRIMARY KEY NOT NULL,
  RAZON_SOCIAL NVARCHAR(100) NOT NULL,
  SLOGAN NVARCHAR(100) NULL,
  DIRRECCION NVARCHAR(500) NULL,
  TELEFONO NVARCHAR(30) NULL,
  ENCARGADO NVARCHAR(30) NOT NULL,
  CORREO NVARCHAR(100) NULL,
  LOGO NVARCHAR(500) NULL
)
GO

CREATE TABLE USUARIO
(
  COD_USUARIO INT PRIMARY KEY NOT NULL,
  NOMBRE NVARCHAR(30) NOT NULL,
  APELLIDOS NVARCHAR(50) NOT NULL,
  USUARIO NVARCHAR(50) NOT NULL,
  CORREO NVARCHAR(30) NULL,
  TELEFONO NVARCHAR(30) NULL,
  FOTO NVARCHAR(MAX)
)
GO

CREATE TABLE USUARIO_EMPRESA
(
  COD_USUARIO INT FOREIGN KEY REFERENCES USUARIO (COD_USUARIO) ON DELETE CASCADE ON UPDATE CASCADE NOT NULL,
  ID_EMPRESA INT FOREIGN KEY REFERENCES EMPRESAS (ID_EMPRESA) ON DELETE CASCADE ON UPDATE CASCADE NOT NULL,
  FECHA_REGISTRO DATETIME DEFAULT GETDATE()
)
GO

CREATE TABLE CLIENTE
(
  ID_CLIENTE INT PRIMARY KEY NOT NULL,
  IDENTIFICACION NVARCHAR(MAX) NULL,
  RAZON_SOCIAL NVARCHAR(100) NOT NULL,
  FECHA_NACIMIENTO DATE NULL,
  DIRECCION NVARCHAR(MAX) NULL,
  CONTACTO NVARCHAR(30) NULL,
  TELEFONO NVARCHAR(MAX) NULL,
  CORREO NVARCHAR(100) NULL,
  VEDENDOR INT NOT NULL,
  SALDO FLOAT DEFAULT 0 NOT NULL,
  LIMITE_CREDITO FLOAT DEFAULT 0 NOT NULL,
  LIMITE_DESCUENTO FLOAT DEFAULT 0 NOT NULL,
  PLAZO FLOAT DEFAULT 0 NOT NULL,
  CLASIFICACION NVARCHAR(3) DEFAULT 'N/A' NOT NULL,
  ACTIVO BIT NOT NULL
)
GO

CREATE TABLE PAIS
(
  ID_PAIS INT PRIMARY KEY NOT NULL,
  PAIS NVARCHAR(100) NOT NULL,
  CAPITAL NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE PROVEEDOR
(
  ID_PROVEEDOR INT PRIMARY KEY NOT NULL,
  TIPO_PROVEEDOR INT DEFAULT 0 NOT NULL,
  IDENTIFICACION NVARCHAR(MAX) NULL,
  RAZON_SOCIAL NVARCHAR(100) NOT NULL,
  PAIS INT FOREIGN KEY REFERENCES PAIS (ID_PAIS) ON DELETE CASCADE ON UPDATE CASCADE NOT NULL,
  DIRECCION NVARCHAR(MAX) NULL,
  CONTACTO NVARCHAR(30) NULL,
  TELEFONO NVARCHAR(MAX) NULL,
  CORREO NVARCHAR(100) NULL,
  SALDO FLOAT DEFAULT 0 NOT NULL,
  LIMITE_CREDITO FLOAT DEFAULT 0 NOT NULL,
  TIEMPO_ENTREGA FLOAT DEFAULT 0 NOT NULL,
  CLASIFICACION NVARCHAR(3) DEFAULT 'N/A' NOT NULL,
  ACTIVO BIT NOT NULL
)
GO

CREATE TABLE MARCA
(
  ID_MARCA INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  NOMBRE NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE CATEGORIA
(
  ID_CATEGORIA INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  NOMBRE NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE TIPO_PRODUCTO
(
 ID_TIPO INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
 NOMBRE NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE UNIDAD_MEDIDA
(
 ID_UDM INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
 NOMBRE NVARCHAR(100) NOT NULL,
 REPRESENTACION NVARCHAR(10) NULL
)
GO

CREATE TABLE PRODUCTOS
(
  ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  CODIGO_COMPUESTO NVARCHAR(30) NULL,
  CODIGO_BARRA NVARCHAR(100) NULL,
  PRODUCTO NVARCHAR(100) NOT NULL,
  MARCA INT FOREIGN KEY REFERENCES MARCA (ID_MARCA) ON DELETE CASCADE ON UPDATE CASCADE NOT NULL,
  CATEGORIA INT FOREIGN KEY REFERENCES CATEGORIA (ID_CATEGORIA) NOT NULL,
  TIPO INT FOREIGN KEY REFERENCES TIPO_PRODUCTO (ID_TIPO) NOT NULL,
  UDM INT FOREIGN KEY REFERENCES UNIDAD_MEDIDA (ID_UDM) NOT NULL,
  FOB FLOAT DEFAULT 0 NOT NULL,
  CIF FLOAT DEFAULT 0 NOT NULL,
  MINIMO FLOAT DEFAULT 0 NOT NULL,
  MAXIMO FLOAT DEFAULT 0 NOT NULL,
  CLASIFICACION NVARCHAR(3) DEFAULT 'N/A' NOT NULL,
  SERVICIO BIT DEFAULT 0 NOT NULL,
  IMPUESTO BIT DEFAULT 0 NOT NULL,
  LOCAL BIT DEFAULT 0 NOT NULL,
  ACTIVO BIT DEFAULT 0 NOT NULL
)
GO

CREATE TABLE BODEGA
(
  ID_BODEGA INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  DESCRIPCION NVARCHAR(100) NOT NULL,
  ACTIVO BIT DEFAULT 0 NOT NULL
)
GO

CREATE TABLE PEB
(
  ID INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
  ID_BODEGA NVARCHAR(30) NOT NULL,
  CODIGO_COMPUESTO NVARCHAR(30) NOT NULL,
  PRECIO FLOAT DEFAULT 0 NOT NULL,
  EXISTENCIAS FLOAT DEFAULT 0 NOT NULL,
  DISPONIBILIDAD FLOAT DEFAULT 0 NOT NULL,
  UBICACION NVARCHAR(30) NULL
)
GO

CREATE TABLE MIGRAR_INVENTARIO
(
BODEGA NVARCHAR(100) NOT NULL,
CODIGO NVARCHAR(30) NOT NULL,
CODIGO_BARRA NVARCHAR(100) NULL,
PRODUCTO NVARCHAR(100) NOT NULL,
MARCA NVARCHAR(100) NOT NULL,
CATEGORIA NVARCHAR(100) NOT NULL,
TIPO NVARCHAR(100) NOT NULL,
UDM NVARCHAR(100) NOT NULL,
FOB FLOAT DEFAULT 0 NOT NULL,
CIF FLOAT DEFAULT 0 NOT NULL,
PRECIO FLOAT DEFAULT 0 NOT NULL,
EXISTENCIAS FLOAT DEFAULT 0 NOT NULL,
RACK NVARCHAR(10) DEFAULT '00' NOT NULL,
COLUMNA NVARCHAR(10) DEFAULT '00' NOT NULL,
FILA NVARCHAR(10) DEFAULT '00' NOT NULL,
MINIMO FLOAT DEFAULT 0 NOT NULL,
MAXIMO FLOAT DEFAULT 0 NOT NULL,
CLASIFICACION NVARCHAR(3) DEFAULT 'N/A' NOT NULL,
SERVICIO NVARCHAR(1) DEFAULT '0' NOT NULL,
IMPUESTO NVARCHAR(1) DEFAULT '0' NOT NULL,
ACTIVO NVARCHAR(1) DEFAULT '0' NOT NULL,
LOCAL NVARCHAR(1) DEFAULT '0' NOT NULL,
)
GO
