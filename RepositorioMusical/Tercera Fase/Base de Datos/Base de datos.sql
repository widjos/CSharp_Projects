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
FK_Codigo_Album INT
);


CREATE TABLE ALBUM(
Codigo_Album INT PRIMARY KEY IDENTITY,
Titulo VARCHAR(150),
Fecha DATETIME NOT NULL DEFAULT (GETDATE()),
Resena VARCHAR(250),
Foto_Portada VARCHAR(300),
FK_Codigo_Artista INT
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


--- TABLAS AGREGADAS EN LA TERCERA FASE 

CREATE TABLE NOVEDAD(
Codigo_Novedad INT PRIMARY KEY NOT NULL IDENTITY,
Titulo VARCHAR(100),
Contenido VARCHAR(100),
Imagen VARCHAR(200) 
);


CREATE TABLE CANCION_MEGUSTA(
Codigo_MegustaC INT PRIMARY KEY NOT NULL IDENTITY,
Me_Gusta INT NOT NULL,
FK_Numero_Cancion INT NOT NULL


);


CREATE TABLE ALBUM_MEGUSTA(
Codigo_Megusta INT PRIMARY KEY NOT NULL IDENTITY,
Me_Gusta INT NOT NULL,
FK_Codigo_Album INT NOT NULL


);

-- eSTAS LLEVAN DOS LLAVES FORANEAS 

CREATE TABLE FAVORITO_CANCION(
Codigo_FavoritoCA  INT PRIMARY KEY NOT NULL IDENTITY,
FK_Numero_Cancion INT NOT NULL,
FK_Codigo_Usuario INT NOT NULL,
Fecha DATETIME NOT NULL DEFAULT (GETDATE()) 
);

CREATE TABLE FAVORITO_ALBUM(
Codigo_FavoritoAB  INT PRIMARY KEY NOT NULL IDENTITY,
FK_Codigo_Album INT NOT NULL,
FK_Codigo_Usuario INT NOT NULL,
Fecha DATETIME NOT NULL DEFAULT (GETDATE()) 
);

--Ahora crear las llaves foraneas 




UPDATE TABLE 

-- Querys 

INSERT INTO TIPO_USER(

) 

--AGREGANDO LAS LLAVES FORANEAS 

ALTER TABLE USUARIO
ADD CONSTRAINT USUARIO_TipoUsuario FOREIGN KEY (FK_Tipo_Usuario) REFERENCES TIPO_USER(Codigo_Tipo);

ALTER TABLE ARTISTA
ADD CONSTRAINT ARTISTA_CodigoUser FOREIGN KEY (FK_Codigo_Usuario) REFERENCES USUARIO(Codigo_Usuario);


 ALTER TABLE LISTA_REPRODUCCION
 ADD CONSTRAINT LISTA_REPRODUCCION_CodigoUser FOREIGN KEY(FK_Codigo_Usuario) REFERENCES USUARIO(Codigo_Usuario);
 
 ALTER TABLE CANCION
 ADD CONSTRAINT CANCION_CodigoAlbum FOREIGN KEY(FK_Codigo_Album) REFERENCES ALBUM(Codigo_Album);
 
 
 
 ALTER TABLE ALBUM
 ADD CONSTRAINT ALBUM_CodigoArtista FOREIGN KEY(FK_Codigo_Artista) REFERENCES ARTISTA(Codigo_Artista);
 
 
 
 
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
ADD CONSTRAINT CANCION_ESTADO_CodigoCancion FOREIGN KEY(FK_Codigo_Cancion ) REFERENCES CANCION(Numero_Cancion);
 
 
 ALTER TABLE  CANCION_ESTADO
ADD CONSTRAINT CANCION_ESTADO_CodigoEstado FOREIGN KEY(FK_Codigo_Estado ) REFERENCES ESTADO(Codigo_Estado);
 
 ALTER TABLE USUARIO_ESTADO
 ADD CONSTRAINT USUARIO_ESTADO_CodigoUsuario FOREIGN KEY(FK_Codigo_Usuario) REFERENCES USUARIO(Codigo_Usuario);
 
  ALTER TABLE USUARIO_ESTADO
 ADD CONSTRAINT USUARIO_ESTADO_CodigoEstado FOREIGN KEY(FK_Codigo_Estado) REFERENCES ESTADO(Codigo_Estado);
 
 
 -------- Aqui van las llaves foraneas de las nuevas tablas 
 
 ALTER TABLE CANCION_MEGUSTA
 ADD CONSTRAINT CANCION_MEGUSTA_NumeroCancion FOREIGN KEY(FK_Numero_Cancion) REFERENCES CANCION(Numero_Cancion); 
 
 ALTER TABLE ALBUM_MEGUSTA 
 ADD CONSTRAINT ALBUM_MEGUSTA_CodigoAlbum FOREIGN KEY(FK_Codigo_Album) REFERENCES ALBUM(Codigo_Album);
 
 ALTER TABLE FAVORITO_ALBUM
 ADD CONSTRAINT FAVORITO_ALBUM_CodigoAlbum FOREIGN KEY(FK_Codigo_Album) REFERENCES  ALBUM(Codigo_Album);
 
 ALTER TABLE FAVORITO_ALBUM
 ADD CONSTRAINT FAVORITO_ALBUM_CodigoUsuario FOREIGN KEY(FK_Codigo_Usuario) REFERENCES USUARIO(Codigo_Usuario);
 
 ALTER TABLE FAVORITO_CANCION 
 ADD CONSTRAINT FAVORITO_CANCION_NumeroCancion FOREIGN KEY(FK_Numero_Cancion) REFERENCES CANCION(Numero_Cancion);
 
 ALTER TABLE FAVORITO_CANCION
 ADD CONSTRAINT FAVORITO_CANCION_CodigoUsuario FOREIGN KEY(FK_Codigo_Usuario) REFERENCES USUARIO(Codigo_Usuario);
 
 
 ------ Comentarios vergas para recordarme que estoy haciendo.

-- Formato de fecha DD/MM/AAAA
 
 --DATABASE NAME : WINDOWS-RL87E9Q

-- INSERCION DEL  ADMINISTRADOR CREADO POR DEFECTO  con los datos siguientes
	Raton Perez 
	dioslomejor@putas.com
	casa78964/
	22/01/1995
	
	
-- Se llenan los catalogos para el tipo de usuario;

	INSERT INTO TIPO_USER VALUES('Administrador');
	INSERT INTO TIPO_USER VALUES('Usuario');
	INSERT INTO TIPO_USER VALUES('Artista');
	
-- Se llena el catalogo de estado 
	
	INSERT INTO ESTADO VALUES('Activo');
	INSERT INTO ESTADO VALUES('Eliminado');
	INSERT INTO ESTADO VALUES('Bloqueado');
	
-- Se insertan los datos para el administrador del sistema	

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



-- solo era para ver la direccion especifica de los archivos    
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






////////////////////////////////////////// INSERT DE IMAGENES 		

------ Insertar todos los generos para la tabla 		

INSERT INTO GENERO VALUES('Rock', 'Imagenes/GneroImagenes/rock.jpg' );
INSERT INTO GENERO VALUES('Pop', 'Imagenes/GneroImagenes/rock.jpeg' );
INSERT INTO GENERO VALUES('Metal', 'Imagenes/GneroImagenes/metal.jpg' );
INSERT INTO GENERO VALUES('Electronica', 'Imagenes/GneroImagenes/electronica.png' );
INSERT INTO GENERO VALUES('Blues', 'Imagenes/GneroImagenes/blues.jpg' );
INSERT INTO GENERO VALUES('Funk', 'Imagenes/GneroImagenes/funk.jpg' );
INSERT INTO GENERO VALUES('HipHop', 'Imagenes/GneroImagenes/hiphop.png' );
INSERT INTO GENERO VALUES('Jazz', 'Imagenes/GneroImagenes/jazz.jpg' );
INSERT INTO GENERO VALUES('Rap', 'Imagenes/GneroImagenes/rap.jpg' );
INSERT INTO GENERO VALUES('Reggae', 'Imagenes/GneroImagenes/reggea.jpg' );
INSERT INTO GENERO VALUES('Clasica', 'Imagenes/GneroImagenes/clasica.jpg' );
INSERT INTO GENERO VALUES('Dance', 'Imagenes/GneroImagenes/dance.jpg' );

		
	

//////////////////////////////////////////////////	

Insertar un artista  nuevo

INSERT INTO ARTISTA VALUES( 'nombre', 'anoFormacion' , codigopais, 'descripcionartist', 'facebok', 'twitt', 'youtub', 'web', codgioestado, codigouser);



-- Se altero la tabla Artista  04/05/2018 


ALTER TABLE ARTISTA ADD Imagen VARCHAR(100);


consultando artista actual

SELECT Nombre , ano , pais , descricopn , foto , genero , face , twitt , youtub , pagina 

SELECT  Nombre , Ano_Formacion , Codigo_Pais , Descripcion_Artista , Imagen , Facebook , Twitter, YouTube , PaginaWeb FROM ARTISTA WHERE Codigo_Artista = codigEntra;



/------------------- Votar llaves foraneas que estan de mas en la base dedatos 8:55 / 05/05/2018

ALTER TABLE ARTISTA
DROP CONSTRAINT ARTISTA_CodigoEstado ; 

ALTER TABLE ALBUM
DROP CONSTRAINT ALBUM_CodigoEstado;

ALTER TABLE CANCION
DROP CONSTRAINT CANCION_CodigoEstado;

-- luego eliminar cada una de las columnas de estado en las tablas principales ya que estas estan relacionadas
-- por otra tabla especifica.

--Probar solo borrar la columna 


ALTER TABLE ARTISTA 
DROP COLUMN FK_Codigo_Estado; -- borrado exitoso!

ALTER TABLE CANCION
DROP COLUMN FK_Codigo_Estado;

ALTER TABLE ALBUM
DROP COLUMN FK_Codigo_Estado;


-- retornar todo los datos del artista 

nombre, ano , pais, descripcion, foto, generos , face , twt , youtub , pagina 

SELECT Nombre , Ano_Formacion, Codigo_Pais , Descripcion_Artista, Imagen, Facebook, Twitter, YouTube, PaginaWeb FROM
ARTISTA WHERE Codigo_Artista = 1; 

--------------------------- 19:53 
-- actualice el url de la imagen porque esa wea noservia 

UPDATE ARTISTA SET Imagen = '~/AppData/nuevogen1.png' WHERE Codigo_Artista = 1;


----06/05/2018---------------------------------- Consulltas he inserts para la tabla de album -----------------

INSERT INTO ALBUM VALUES ( 'tituloAlb', GETDATE(), 'resenaALb', 'fotoAlb', codigoArtista);


-- Retornara el valor del codigo del album para uns variable de sesion futura.

SELECT Codigo_Album FROM ALBUM WHERE FK_Codigo_Artista =  idUser AND Titulo = titulAlb;

SELECT Titulo FROM ALBUM; 
  
 -- insertar el estado del album 

INSERT INTO ALBUM_ESTADO VALUES (idAlbum, 1); 

-- 

agregar cancion 

agregar cancion estado



------------------------------------------------------------------

cONSULTAS VERGAS ------


SELECT USUARIO.Nombre, USUARIO.Apellido, USUARIO.Usuario, ESTADO.Nombre_Estado AS Estado_Actual, USUARIO_ESTADO.Fecha_Modificacion AS Fecha_de_CREACION
FROM USUARIO

JOIN USUARIO_ESTADO ON USUARIO_ESTADO.Codigo_UE = ( SELECT MIN(USUARIO_ESTADO.Codigo_UE) FROM USUARIO_ESTADO WHERE USUARIO_ESTADO.FK_Codigo_Usuario = USUARIO.Codigo_Usuario )
JOIN ESTADO ON ESTADO.Codigo_Estado= (SELECT USUARIO_ESTADO.FK_Codigo_Estado FROM USUARIO_ESTADO WHERE USUARIO_ESTADO.Codigo_UE =
( SELECT  MAX(USUARIO_ESTADO.Codigo_UE)  FROM USUARIO_ESTADO WHERE USUARIO_ESTADO.FK_Codigo_Usuario = USUARIO.Codigo_Usuario ) ) ;



-- JOIN ESTADO ON USUARIO_ESTADO.Codigo_UE = (SELECT MAX(USUARIO_ESTADO.Codigo_UE FROM USUARIO_ESTADO WHERE USUARIO.FK_Estado_Usuario = ESTADO.Nombre_Estado) 


-- Creo que son pruebas 
JOIN ESTADO ON USUARIO_ESTADO.Codigo_UE = (SELECT MAX(USUARIO_ESTADO.Codigo_UE) FROM USUARIO_ESTADO WHERE ESTADO.Codigo_Estado = (SELECT USUARIO_ESTADO.FK_Codigo_Estado 
ROM USUARIO_ESTADO WHERE USUARIO_ESTADO.FK_Codigo_Usuario = USUARIO.Codigo_Usuario)) ;

SELECT * FROM ESTADO;


-- SELECCIONAR A TODOS LOS ARTISTAS ELIMINADOS

----Devolver los artistas con estado eliminado 

SELECT ARTISTA.Nombre , ARTISTA.Ano_Formacion, ARTISTA.Codigo_Artista, ARTISTA.Descripcion_Artista, ARTISTA.Facebook , ARTISTA.Twitter , ARTISTA.YouTube , ARTISTA.PaginaWeb , ARTISTA.Imagen, ESTADO.Nombre_Estado 
FROM ARTISTA 
JOIN ARTISTA_ESTADO ON ARTISTA_ESTADO.Codigo_AE = (SELECT ARTISTA_ESTADO.Codigo_AE FROM ARTISTA_ESTADO WHERE ARTISTA_ESTADO.FK_Codigo_Artista = ARTISTA.Codigo_Artista)
JOIN ESTADO ON ESTADO.Codigo_Estado = (SELECT ARTISTA_ESTADO.FK_Codigo_Estado FROM ARTISTA_ESTADO WHERE ARTISTA_ESTADO.Codigo_AE = (SELECT ARTISTA_ESTADO.Codigo_AE  FROM ARTISTA_ESTADO WHERE ARTISTA_ESTADO.FK_Codigo_Estado = 2));


--- DEVOLVER TODOS LOS ALBUMES ELIMINADOS 

 SELECT ALBUM.Titulo , ALBUM.Fecha, ALBUM.Resena	,ALBUM.Foto_Portada	, ESTADO.Nombre_Estado FROM ALBUM 
JOIN ALBUM_ESTADO ON ALBUM_ESTADO.Codigo_ALE = (SELECT ALBUM_ESTADO.Codigo_ALE FROM ALBUM_ESTADO WHERE ALBUM.FK_Codigo_Artista = ALBUM.Codigo_Album)
JOIN ESTADO ON ESTADO.Codigo_Estado = (SELECT ALBUM_ESTADO.FK_Codigo_Estado FROM ALBUM_ESTADO WHERE ALBUM_ESTADO.Codigo_ALE = (SELECT ALBUM_ESTADO.Codigo_ALE FROM ALBUM_ESTADO WHERE ALBUM_ESTADO.FK_Codigo_Estado = 2 ));





-- Devolver las novedades 

SELECT * FROM NOVEDAD;


----- Codigo para mostrar las novedades 


<div class="card" style="width: 25rem;">
           <img class="card-img-top" src="direccion imagen" alt="Card image cap">
                    <div class="card-body">
                        <h5 class="card-title">titulo</h5>
                        <p class="card-text">ccontenido</p>                    
                    </div>
					</div>



---- Agregando el URL a cacncion    08/05/218 

ALTER TABLE CANCION 
ADD Url_Cancion VARCHAR(200); 


////////////////////////////////////////

Obtener los llevar un contador que asigna a cada 


update 

              <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:UpdatePanel runat="server" id="UpdatePanel" updatemode="Conditional">
        <Triggers>
            <asp:AsyncPostBackTrigger INamingContainer="Panel1" eventname="Click" />
        </Triggers>
            <ContentTemplate>
			   </ContentTemplate>
        </asp:UpdatePanel>





width: 25rem


		

	 
	  miConsulta = new Consultas();
            idUsuario = Session["Codigo_Artista"].ToString();


<asp:ImageButton ID=\"bot\" runat="server"  ImageUrl="" OnClick="motrarImagen_Click"/>
<img class=\"card-img-top\" src=\"" + "" + imagphat + "\" alt=\"Card image cap\">" 

<asp:Button ID="Button1" runat="server" Text="Mirar" OnClick="Button1_Click" />










