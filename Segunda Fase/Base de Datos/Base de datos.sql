CREATE DATABASE RepositorioMusica;


CREATE TABLE TIPO_USER(
Codigo_Tipo INT PRIMARY KEY,
Nombre_Tipo VARCHAR(100)

);

CREATE TABLE USUARIO(
Codigo_Usuario INT PRIMARY KEY,
Nombre VARCHAR(100),
Apellido VARCHAR(100),
Fecha_Nacimiento DATE,
Usuario VARCHAR(150), 
Contrasena VARCHAR(90),
FK_Tipo_Usuario INT
);

CREATE TABLE ESTADO(
Codigo_Estado INT PRIMARY KEY,
Nombre_Estado VARCHAR(150)
);


CREATE TABLE ARTISTA(
Codigo_Artista INT PRIMARY KEY,
Nombre VARCHAR(200),
Ano_Formacion DATE,
Codigo_Pais INT,
Descripcion_Artista VARCHAR(500),
Facebook VARCHAR(150),
Twitter VARCHAR(150),
YouTube VARCHAR(150),
PaginaWeb VARCHAR(150),
FK_Codigo_Estado INT 
);

CREATE TABLE GENERO(
Codigo_Genero INT PRIMARY KEY,
Nombre_Genero VARCHAR(100),
Imagen VARCHAR(200)
);

CREATE TABLE PAIS(
Codigo_Pais INT PRIMARY KEY,
Nombre_Pais VARCHAR(100)
);

CREATE TABLE LISTA_REPRODUCCION(
Codigo_Lista INT PRIMARY KEY,
Nombre_Lista VARCHAR(150),
FK_Codigo_Usuario INT
);



CREATE TABLE CANCION(
Numero_Cancion INT PRIMARY KEY,
Nomnbre_Cancion VARCHAR(100),
Duracion TIME, 
FK_Codigo_Album INT,
FK_Codigo_Estado INT
);


CREATE TABLE ALBUM(
Codigo_Album INT PRIMARY KEY,
Titulo VARCHAR(150),
Fecha DATE,
Resena VARCHAR(250),
Foto_Portada VARCHAR(300),
FK_Codigo_Artista INT,
FK_Codigo_Estado INT
);

CREATE TABLE GENERO_ARTISTA(
id INT PRIMARY KEY,
FK_Codigo_Genero INT NOT NULL,
FK_Codigo_Artista INT NOT NULL

);

CREATE TABLE LISTA_CANCION(
id INT PRIMARY KEY,
FK_Codigo_Lista INT NOT NULL,
FK_Codigo_Cancion INT NOT NULL

);



-- Querys 

INSERT INTO TIPO_USER(

) 





-- Solucion para cuando las llaves primarias la cagan 

--ALTER TABLE Orders
--DROP FOREIGN KEY FK_PersonOrder; 


--ALTER TABLE Orders
--DROP CONSTRAINT FK_PersonOrder; 

