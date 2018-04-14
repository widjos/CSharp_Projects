<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="RepositorioMusical.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrarse</title>
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
       
    
    
    <!--Registrarse -->



                <div class="centrar-pagina">

                    <h5 class="col-xl-12">Ingrese los datos que se le piden acontinuacion.</h5>
                    <label class="col-xs-11">Nombre</label>
                    <div class="col-xl-11">
                        <asp:TextBox ID="Nombre" runat="server" class="form-control" placeholder="Nombre"></asp:TextBox>
                    </div>
                     <label class="col-xs-11">Apellido</label>
                    <div class="col-xl-11">
                        <asp:TextBox ID="apellido" runat="server" class="form-control" placeholder="Apellido"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Fecha de Nacimiento</label>
                    <div class="col-11">
                        <asp:TextBox ID="FechaNac" runat="server" class="form-control" placeholder="AAAA-MM-DD"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Correo electronico</label>
                    <div class="col-11">
                        <asp:TextBox ID="CorreoElect" runat="server" class="form-control" placeholder="fulanito@dominio.com"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Usuario</label>
                    <div class="col-11">
                        <asp:TextBox ID="NomUser" runat="server" class="form-control" placeholder="Usuario"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Contraseña</label>
                    <div class="col-11">
                        <asp:TextBox ID="Contraseña" runat="server" class="form-control" placeholder="Contraseña"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Verificacion de Contraseña</label>
                    <div class="col-11">
                        <asp:TextBox ID="ContraseñaVerificacion" runat="server" class="form-control" placeholder="Escriba de nuevo su contraseña"></asp:TextBox>
                    </div>

                    <div class="col-11 espacio-vertical"> 
                        <asp:Button ID="CrearCuenta" runat="server" Text="Crear cuenta" class="btn btn-success" OnClick="CrearCuenta_Click"  />
                      

                    </div>
                    <div class="col-1 espacio-vertical">
                        <asp:Label ID="Mensaje" runat="server" Text="" class="col-xl-11"></asp:Label>

                    </div>


                </div>
    </form>
          <footer>
            <p>&copy; 2018 - WiPlay</p>
        </footer>

    <script src="Scripts/jquery-3.0.0.js"></script>
    <script src="Scripts/umd/popper.min.js"></script>
    <script src="Scripts/popper.js"></script>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>


</body>
</html>
