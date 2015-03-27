CREATE DATABASE trailers;
GO
USE trailers
GO
CREATE TABLE usuarios(
id int IDENTITY PRIMARY KEY NOT NULL,
username varchar(255),
password varchar(255));
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
licencia varchar(255));