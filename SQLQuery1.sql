CREATE DATABASE REGISTRO1
go

USE REGISTRO1

CREATE TABLE NI�OS
(
     CODIGO VARCHAR(5) PRIMARY KEY,
	 NOMBRE VARCHAR(100),
	 APELLIDO VARCHAR(100),
	 EDAD VARCHAR(100),
	 TELEFONO VARCHAR(100),
	 GENERO VARCHAR(100)
)

INSERT INTO NI�OS VALUES('A0001','Michael','Gonzales Mamani','5','7975343','Masculino')

SELECT * FROM NI�OS

CREATE TABLE JOVEN
(
     CODIGO VARCHAR(5) PRIMARY KEY,
	 NOMBRE VARCHAR(100),
	 APELLIDO VARCHAR(100),
	 EDAD VARCHAR(100),
	 TELEFONO VARCHAR(100),
	 GENERO VARCHAR(100)
)

INSERT INTO JOVEN VALUES('B0001','Maria','Mamani Mujica','15','5968304','Femenino')

SELECT * FROM JOVEN

CREATE TABLE ADULTO
(
     CODIGO VARCHAR(5) PRIMARY KEY,
	 NOMBRE VARCHAR(100),
	 APELLIDO VARCHAR(100),
	 EDAD VARCHAR(100),
	 TELEFONO VARCHAR(100),
	 GENERO VARCHAR(100)
)

INSERT INTO ADULTO VALUES('C0001','Ivan','Mamani Colque','25','8533954','Masculino')

SELECT * FROM ADULTO
