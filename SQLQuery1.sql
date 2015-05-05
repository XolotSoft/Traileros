CREATE DATABASE trailers;
GO
USE trailers
GO
CREATE TABLE usuarios(
id int IDENTITY PRIMARY KEY NOT NULL,
nombre varchar(255),
username varchar(255),
password varchar(255),
rol varchar(255));
GO
CREATE TABLE operadores(
id int IDENTITY PRIMARY KEY NOT NULL,
nombre varchar(255),
paterno varchar(255),
materno varchar(255),
nacimiento date,
calle varchar(255),
numero varchar(255),
colonia varchar(255),
delegacion varchar(255),
telefono varchar(255),
email varchar(255),
licencia varchar(255),
estado varchar(255));
GO
CREATE TABLE vehiculos(
id int IDENTITY PRIMARY KEY NOT NULL,
serie varchar(255),
marca varchar(255),
tipo varchar(255),
modelo varchar(255),
placa varchar(255),
adquicision date,
servicio date,
mantenimiento varchar(255),
estado varchar(255));
GO
CREATE TABLE destinos(
id int IDENTITY PRIMARY KEY NOT NULL,
nombre varchar(255)
);
INSERT INTO destinos(nombre)
VALUES('CD de México'),('Chihuahua'),('Monterrey'),('Hermosillo');