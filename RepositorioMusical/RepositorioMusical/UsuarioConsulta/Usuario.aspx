<%@ Page Title="" Language="C#" MasterPageFile="~/UsuarioConsulta/Usuario.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="RepositorioMusical.UsuarioConsulta.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Titulo" runat="server">
    Usuario
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    
    <!-- Explorar -->
    
    <div class="card-header">
        <h2 class=""> Explorar</h2>

        </div>
    
    <div class="card-columns">
        
        <div class="container col-6 p-4">
            <div class="col-6">
                <div class="card" style="width: 18rem;">
                    <img class="card-img-top" src="../Imagenes/7.jpg" alt="Card image cap">
                    <div class="card-body">
                        <h5 class="card-title">Genero</h5>
                        <p class="card-text">Explora con fasilidad todos en los generos alternativos que suenan en el momento para encontrar nuevas canciones.</p>
                        <a href="#" class="btn btn-primary">Ingresar</a>
                    </div>
                </div>
            </div>
            <div class="container col-6 p-4">
                <div class="col-6">
                    <div class="card" style="width: 18rem;">
                        <img class="card-img-top" src="../Imagenes/6.jpg" alt="Card image cap">
                        <div class="card-body">
                            <h5 class="card-title">Lista de Reprodución</h5>
                            <p class="card-text">Busca las Listas de reproduciones más escuchadas por los usuarios</p>
                            <a href="#" class="btn btn-primary">ingresar</a>
                        </div>
                    </div>
                </div>

            </div>
            </div>

        </div>

    <!--Tendencias-->

    <div class="card-header">
        <h2> Tendencias </h2>
        </div>

     <div class="card-columns">
        
        <div class="container col-6 p-4">
            <div class="col-6">
                <div class="card" style="width: 18rem;">
                    <img class="card-img-top" src="../Imagenes/5.jpg" alt="Card image cap">
                    <div class="card-body">
                        <h5 class="card-title">Artistas más Influyentes</h5>
                        <p class="card-text">Explora con fasilidad todos en los generos alternativos que suenan en el momento para encontrar nuevas canciones.</p>
                        <a href="#" class="btn btn-primary">Ingresar</a>
                    </div>
                </div>
            </div>
            <div class="container col-6 p-4">
                <div class="col-6">
                    <div class="card" style="width: 18rem;">
                        <img class="card-img-top" src="../Imagenes/4.jpg" alt="Card image cap">
                        <div class="card-body">
                            <h5 class="card-title">Álbumes populares</h5>
                            <p class="card-text">Busca las Listas de reproduciones más escuchadas por los usuarios</p>
                            <a href="#" class="btn btn-primary">ingresar</a>
                        </div>
                    </div>
                </div>
                
            </div>
            </div>

        </div>
       

</asp:Content>
