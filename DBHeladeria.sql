CREATE DATABASE DBHeladeria;
USE DBHeladeria;

CREATE TABLE Usuario (
	Nombre VARCHAR(60),
	Contrasenia VARCHAR(30) NOT NULL,
	PRIMARY KEY(Nombre)
);

CREATE TABLE Producto (
	Nombre VARCHAR(50)
	PrecioVenta INT
	Stock INT NOT NULL,
	StockMinimo INT NOT NULL,
	PRIMARY KEY(Nombre)
);

CREATE TABLE Pedido (
	ID INT,
	FechaHora DATETIME NOT NULL,
	Delivery BIT DEFAULT(0),
	PRIMARY KEY(ID)
);

CREATE TABLE Producto_Pedido (
	IDPedido INT FOREIGN KEY REFERENCES Pedido(ID),
	NombreProducto VARCHAR(50) FOREIGN KEY REFERENCES Producto(Nombre),
	PRIMARY KEY(IDPedido, NombreProducto),
	
);

CREATE TABLE MovimientoCaja (
	FechaHora DATETIME,
	Razon VARCHAR(150) NOT NULL,
	Monto DOUBLE NOT NULL,
	NombreUsuario VARCHAR(60) FOREIGN KEY REFERENCES Usuario(Nombre) NOT NULL,
	PRIMARY KEY(FechaHora)
);