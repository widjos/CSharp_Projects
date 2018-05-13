<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="RepositorioMusical.IniciarSesion" %>

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
       

    <!-- Login -->

    <form class="container-fluid " > 
        <div class="centrar-pagina">
        <div>
            <h5>Ingrese sus datos para acceder a su cuenta</h5>
         </div>

        <div class="align-items-center">
        
  <div class="form-group mx-sm-3 mb-2">
    <label for="Correo" class="sr-only">Correo</label>

      <asp:TextBox ID="Correo" runat="server" class="form-control " placeholder="Correo Electronico"></asp:TextBox>
        <asp:Label ID="errorCorreo" runat="server" class="sr-only espacio-vertical" Text="casa"></asp:Label>
  </div>
  
        </div>

         <div class="align-items-center">
        

  <div class="form-group mx-sm-3 mb-2">
    <label for="contraseña" class="sr-only">Contraseña</label>
      <asp:TextBox ID="contrasena" runat="server"  placeholder="Contraseña"  class="form-control" TextMode="Password"></asp:TextBox>
      <asp:Label ID="ErrorContra" runat="server" class="sr-only espacio-vertical "  Text="casa">casa</asp:Label>
   
  </div>
              <div class="col-xs-11">
             <asp:Button ID="IngresarUser" Class="btn btn-primary mb-2" runat="server" Text="Ingresar" OnClick="IngresarUser_Click" />
                </div>
             <asp:HyperLink ID="CrearCuenta" href="Registrarse.aspx" runat="server">No tienes una cuenta</asp:HyperLink>
             
             
        </div>
         
    </form>
               <div class="col-xs-11">
                        <asp:LinkButton ID="RecuperarContrasena" runat="server" href="RecuperarContrasena.aspx">Olvidaste tu contraseña</asp:LinkButton>
                   
                        </div> 
                <div class="col-xs-11">
                <asp:Label ID="error" runat="server" Text=""></asp:Label>
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
