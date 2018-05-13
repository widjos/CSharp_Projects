<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RepositorioMusical.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WiPlay</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
   <link href="Content/bootstrap.css" rel="stylesheet" />

</head>

<body>
    <form id="form1" runat="server">

        <!-- Barra de navegacion -->

        
            <nav class="navbar navbar-dark bg-dark">


                <a class="navbar-brand active" href="#">WiPlay </a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
            </nav>

            <div class="pos-f-t">


                <div class="collapse" id="navbarToggleExternalContent">
                    <div class="bg-dark p-4">
                        <h4 class="text-white">Contenido Externo</h4>
                        <span class="text-muted">Bienvenido a WiPLay : El repositorio de musica libre e inovador del mercado. </span>

                        <ul class="navbar-nav mr-auto">
                            <li class="nav-item active">
                                <a class="nav-link" href="Home.aspx">Home </a>
                            </li>
                            <li class="nav-item active">
                                <a class="nav-link" href="IniciarSesion.aspx">Inicio de Sesión </a>
                            </li>
                        </ul>



                    </div>
                </div>
        </form>

        <!-- Jumbotron de informacion de la pagina -->

        <div class="jumbotron jumbotron-fluid">
            <div class="container">
                <h1 class="display-4">WiPlay</h1>
                <p class="lead">
                    Bienvenido al mejor lugar para emprender tu arte y conocer nuevos artistas. WiPlay es un lugar donde la comunidad convive y hace 
        crecer todo el repositorio dia con dia. Eres Artista ? , Sube tu musica .
        Te gusta la nueva musica ? , Explora nueva musica gratis.
                </p>
            </div>
        </div>


        <!--Carrusel de imagenes de presentacion para el sitio -->

        <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img class="d-block w-75 " src="Imagenes/Portada%201.jpg" alt="First slide">
                    <div class="carousel-caption d-none d-md-block">
                        <h5>Musica de Guitarra</h5>
                        <p>Explora a los artistas del momento con el ritmo de una melodica cancion.</p>
                    </div>
                </div>
               
                
     
                <div class="carousel-item">
                    <img class="d-block w-75 " src="Imagenes/Portada%202.jpg" alt="Second slide">
                    <div class="carousel-caption d-none d-md-block">
                        <h5>Te gusta ser Diferente </h5>
                        <p>Explora nuestro amplio repositorio con musica Indie y alternativas nuevas y hermosas.</p>
                    </div>
                </div>
                <div class="carousel-item">

                    <img class="d-block w-75 " src=" Imagenes/Portada%203.jpg" alt="Third slide">
                    <div class="carousel-caption d-none d-md-block">
                        <h5 style="color: black">No seas timido deja atras lo normal </h5>
                        <p style="color: black">Seccion de Tendencias que te sugiere lo mejor de la semana , mes y año </p>
                    </div>
                </div>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>







    </form>

    <!--Footer -->
      <footer>
          <p class="pull-right"><a href="#">Regresar arriba</a></p>
            <p>&copy; 2018 - WiPlay</p>
       </footer>


    <!--Archivos de boostrap -->
    <script src="Scripts/jquery-3.0.0.js"></script>
    <script src="Scripts/umd/popper.min.js"></script>
    <script src="Scripts/popper.js"></script>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>

        
   
</body>
</html>
