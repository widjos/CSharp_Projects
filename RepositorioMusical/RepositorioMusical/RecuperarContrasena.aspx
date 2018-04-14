<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarContrasena.aspx.cs" Inherits="RepositorioMusical.RecuperarContrasena" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Inicio de Sesion</title>
      <link href="Content/bootstrap.min.css" rel="stylesheet" />
   <link href="Content/bootstrap.css" rel="stylesheet" />
        <link href="Content/bootstrap/Estilos%20random.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
      
        <!-- Barra de Navegacion -->

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

                <!-- Recuperacion de Contraseña -->

                <div class="centrar-pagina">
                     <h5 class="col-xl-12">Ingrese su Fecha de Nacimiento y su Correo Electronico para validadar.</h5>
                    <label class="col-xs-11">Fecha de Nacimiento</label>
                    <div class="col-xl-11">
                        <asp:TextBox ID="NacRecuperarContrasena" runat="server" Class="form-control" placeholder="Fecha de Nacimiento"></asp:TextBox>
                    </div>
                     <label class="col-xs-11">Correo Electronico</label>
                    <div class="col-xl-11">
                        <asp:TextBox ID="CorreoRecuperarContrasea" runat="server" Class="form-control" placeholder="Correo Electronico"></asp:TextBox>
                    </div>

                    <div class="col-xs-11 espacio-vertical">
                        <asp:Button ID="DevolverContrasena" runat="server" Text="Aceptar" Class="btn btn-success" />
                    </div>

                </div>
       
    </form>

     <script src="Scripts/jquery-3.0.0.js"></script>
    <script src="Scripts/umd/popper.min.js"></script>
    <script src="Scripts/popper.js"></script>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>

</body>
</html>
