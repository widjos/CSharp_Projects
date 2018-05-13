CREATE DATABASE RepositorioMusica;

CREATE TABLE TIPO_USER(
Codigo_Tipo INT PRIMARY KEY IDENTITY,
Nombre_Tipo VARCHAR(100)

);

CREATE TABLE USUARIO(
Codigo_Usuario INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(100),
Apellido VARCHAR(100),
Usuario VARCHAR(150),
Fecha_Nacimiento DATE,
Contrasena VARCHAR(90),
FK_Tipo_Usuario INT,
Correo_Electronico VARCHAR(100)
);

CREATE TABLE ESTADO(
Codigo_Estado INT PRIMARY KEY IDENTITY,
Nombre_Estado VARCHAR(150)
);


CREATE TABLE ARTISTA(
Codigo_Artista INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(200),
Ano_Formacion DATE,
Codigo_Pais INT,
Descripcion_Artista VARCHAR(500),
Facebook VARCHAR(150),
Twitter VARCHAR(150),
YouTube VARCHAR(150),
PaginaWeb VARCHAR(150),
FK_Codigo_Estado INT,
FK_Codigo_Usuario INT NOT NULL
 
);

CREATE TABLE GENERO(
Codigo_Genero INT PRIMARY KEY IDENTITY,
Nombre_Genero VARCHAR(100),
Imagen VARCHAR(200)
);

CREATE TABLE PAIS(
Codigo_Pais INT PRIMARY KEY IDENTITY, 
Nombre_Pais VARCHAR(100)
);

CREATE TABLE LISTA_REPRODUCCION(
Codigo_Lista INT PRIMARY KEY IDENTITY,
Nombre_Lista VARCHAR(150),
FK_Codigo_Usuario INT NOT NULL
);



CREATE TABLE CANCION(
Numero_Cancion INT PRIMARY KEY IDENTITY,
Nombre_Cancion VARCHAR(100),
Duracion TIME, 
FK_Codigo_Album INT,
FK_Codigo_Estado INT
);


CREATE TABLE ALBUM(
Codigo_Album INT PRIMARY KEY IDENTITY,
Titulo VARCHAR(150),
Fecha DATETIME NOT NULL DEFAULT (GETDATE()),
Resena VARCHAR(250),
Foto_Portada VARCHAR(300),
FK_Codigo_Artista INT,
FK_Codigo_Estado INT
);

CREATE TABLE GENERO_ARTISTA(
id INT PRIMARY KEY IDENTITY,
FK_Codigo_Genero INT NOT NULL,
FK_Codigo_Artista INT NOT NULL

);

CREATE TABLE LISTA_CANCION(
id INT PRIMARY KEY IDENTITY,
FK_Codigo_Lista INT NOT NULL,
FK_Codigo_Cancion INT NOT NULL

);

-- Aqui van tablas que se agregarón en la fase 2

CREATE TABLE ARTISTA_ESTADO(
Codigo_AE INT PRIMARY KEY IDENTITY,
FK_Codigo_Estado INT NOT NULL,
FK_Codigo_Artista INT NOT NULL,
Fecha_Modificacion DATETIME  NOT NULL DEFAULT (GETDATE())
);

CREATE TABLE ALBUM_ESTADO(
Codigo_ALE INT PRIMARY KEY IDENTITY,
Fecha_Modificacion DATETIME NOT NULL DEFAULT (GETDATE()),
FK_Codigo_Album INT NOT NULL,
FK_Codigo_Estado INT NOT NULL

);

CREATE TABLE CANCION_ESTADO(
Codigo_CE INT PRIMARY KEY NOT NULL IDENTITY,
Fecha_Modificacion DATETIME NOT NULL DEFAULT (GETDATE()),
FK_Codigo_Cancion INT NOT NULL,
FK_Codigo_Estado INT NOT NULL
);

CREATE TABLE USUARIO_ESTADO(
Codigo_UE INT PRIMARY KEY NOT NULL IDENTITY,
Fecha_Modificacion DATETIME NOT NULL DEFAULT (GETDATE()),
FK_Codigo_Estado INT NOT NULL,
FK_Codigo_Usuario INT NOT NULL
);







UPDATE TABLE 

-- Querys 

INSERT INTO TIPO_USER(

) 

--AGREGANDO LAS LLAVES FORANEAS 

ALTER TABLE USUARIO
ADD CONSTRAINT USUARIO_TipoUsuario FOREIGN KEY (FK_Tipo_Usuario) REFERENCES TIPO_USER(Codigo_Tipo);

ALTER TABLE ARTISTA
ADD CONSTRAINT ARTISTA_CodigoUser FOREIGN KEY (FK_Codigo_Usuario) REFERENCES USUARIO(Codigo_Usuario);

ALTER TABLE ARTISTA
ADD CONSTRAINT ARTISTA_CodigoEstado FOREIGN KEY (FK_Codigo_Estado) REFERENCES ESTADO(Codigo_Estado);

 ALTER TABLE LISTA_REPRODUCCION
 ADD CONSTRAINT LISTA_REPRODUCCION_CodigoUser FOREIGN KEY(FK_Codigo_Usuario) REFERENCES USUARIO(Codigo_Usuario);
 
 ALTER TABLE CANCION
 ADD CONSTRAINT CANCION_CodigoAlbum FOREIGN KEY(FK_Codigo_Album) REFERENCES ALBUM(Codigo_Album);
 
  ALTER TABLE CANCION
 ADD CONSTRAINT CANCION_CodigoEstado FOREIGN KEY(FK_Codigo_Estado) REFERENCES ESTADO(Codigo_Estado);
 
 ALTER TABLE ALBUM
 ADD CONSTRAINT ALBUM_CodigoArtista FOREIGN KEY(FK_Codigo_Artista) REFERENCES ARTISTA(Codigo_Artista);
 
 ALTER TABLE ALBUM
 ADD CONSTRAINt ALBUM_CodigoEstado FOREIGN KEY(FK_Codigo_Estado) REFERENCES ESTADO(Codigo_Estado);
 
 
 ALTER TABLE GENERO_ARTISTA
 ADD CONSTRAINT GENERO_ARTISTA_CodigoGenero FOREIGN KEY(FK_Codigo_Genero) REFERENCES GENERO(Codigo_Genero);
 
 ALTER TABLE GENERO_ARTISTA
 ADD CONSTRAINT GENERO_ARTISTA_CodigoArtista FOREIGN KEY(FK_Codigo_Artista) REFERENCES ARTISTA(Codigo_Artista);
 
 
 ALTER TABLE LISTA_CANCION 
 ADD CONSTRAINT LISTA_CANCION_CodigoLista FOREIGN KEY (FK_Codigo_Lista) REFERENCES LISTA_REPRODUCCION(Codigo_Lista);
 


 ALTER TABLE LISTA_CANCION
 ADD CONSTRAINT LISTA_CANCION_CodigoCancion FOREIGN KEY (FK_Codigo_Cancion) REFERENCES CANCION(Numero_Cancion);
 
 ALTER TABLE ARTISTA_ESTADO
 ADD CONSTRAINT ARTISTA_ESTADO_CodigoEstado FOREIGN KEY (FK_Codigo_Estado) REFERENCES ESTADO(Codigo_Estado);
 
 
ALTER TABLE ARTISTA_ESTADO
 ADD CONSTRAINT ARTISTA_ESTADO_CodigoArtista FOREIGN KEY (FK_Codigo_Artista) REFERENCES 	ARTISTA(Codigo_Artista);
 
ALTER TABLE ALBUM_ESTADO
ADD CONSTRAINT ALBUM_ESTADO_CodigoEstado FOREIGN KEY(FK_Codigo_Estado) REFERENCES ESTADO(Codigo_Estado);

Select * from ESTADO;

ALTER TABLE ALBUM_ESTADO
ADD CONSTRAINT ALBUM_ESTADO_CodigoAlbum FOREIGN KEY(FK_Codigo_Album) REFERENCES ALBUM(Codigo_Album);
 
 
 ALTER TABLE  CANCION_ESTADO
ADD CONSTRAINT CANCION_ESTADO_CodigoCancion FOREIGN KEY(FK_Codigo_Cancion ) REFERENCES ALBUM(Codigo_Album);
 
 
 ALTER TABLE  CANCION_ESTADO
ADD CONSTRAINT CANCION_ESTADO_CodigoeEstado FOREIGN KEY(FK_Codigo_Estado ) REFERENCES ALBUM(Codigo_Album);
 
 ALTER TABLE USUARIO_ESTADO
 ADD CONSTRAINT USUARIO_ESTADO_CodigoUsuario FOREIGN KEY(FK_Codigo_Usuario) REFERENCES USUARIO(Codigo_Usuario);
 
  ALTER TABLE USUARIO_ESTADO
 ADD CONSTRAINT USUARIO_ESTADO_CodigoEstado FOREIGN KEY(FK_Codigo_Estado) REFERENCES ESTADO(Codigo_Estado);
 
 
 ------ Comentarios vergas para recordarme que estoy haciendo.

-- Formato de fecha DD/MM/AAAA
 
 --DATABASE NAME : WINDOWS-RL87E9Q

-- INSERCION DEL  ADMINISTRADOR CREADO POR DEFECTO 
	Raton Perez 
	dioslomejor@putas.com
	casa78964/
	22/01/1995
	
	INSERT INTO TIPO_USER VALUES('Administrador');
	INSERT INTO TIPO_USER VALUES('Usuario');
	INSERT INTO TIPO_USER VALUES('Artista');
	
	
	INSERT INTO ESTADO VALUES('Activo');
	INSERT INTO ESTADO VALUES('Eliminado');
	INSERT INTO ESTADO VALUES('Bloqueado');

INSERT INTO USUARIO VALUES('Raton', 'Perez','Replicant', '01-22-1995', 'casa78964', 1 , 'dioslomejor@putas.com');

INSERT INTO USUARIO_ESTADO VALUES (GETDATE(),1,1);


-- Solucion para cuando las llaves primarias la cagan 

--ALTER TABLE Orders
--DROP FOREIGN KEY FK_PersonOrder; 


--ALTER TABLE Orders
--DROP CONSTRAINT FK_PersonOrder; 


---- LLenando los catalogos 

BULK 
INSERT PAIS 
FROM 'E:\Ipc22018\pais.csv'
WITH(
FIELDTERMINATOR=',',
ROWTERMINATOR='\n'
);
GO


BULK 
INSERT genero
FROM 'E:\Ipc22018\Generos.csv'
WITH(
FIELDTERMINATOR=',',
ROWTERMINATOR='\n'
);
GO



--   
<img src="../Imagenes/GneroImagenes/blues.jpg" />
        <img src="../Imagenes/GneroImagenes/clasica.jpg" />
        <img src="../Imagenes/GneroImagenes/dance.jpg" />
        <img src="../Imagenes/GneroImagenes/electronica.png" />
        <img src="../Imagenes/GneroImagenes/hiphop.png" />
        <img src="../Imagenes/GneroImagenes/jazz.jpg" />
        <img src="../Imagenes/GneroImagenes/metal.jpg" />
        <img src="../Imagenes/GneroImagenes/pop.jpeg" />
        <img src="../Imagenes/GneroImagenes/rap.jpg" />
        <img src="../Imagenes/GneroImagenes/reggea.jpg" />
        <img src="../Imagenes/GneroImagenes/rock.jpg" />






