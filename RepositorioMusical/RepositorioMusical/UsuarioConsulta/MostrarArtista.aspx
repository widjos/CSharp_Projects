<%@ Page Title="" Language="C#" MasterPageFile="~/UsuarioConsulta/Usuario.Master" AutoEventWireup="true" CodeBehind="MostrarArtista.aspx.cs" Inherits="RepositorioMusical.UsuarioConsulta.MostrarArtista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Titulo" runat="server">
    Artistas
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <div class="card-header">
       <H5> Albumes</H5>
    </div>


    <asp:Label ID="artistas" runat="server" Text="Label"></asp:Label>


    <asp:TextBox ID="entraArtista" runat="server"></asp:TextBox>
    <asp:Button ID="ArtistaFav" runat="server" Text="Agregar Album A favorito" OnClick="ArtistaFav_Click" style="height: 42px" />
    <asp:Label ID="mensaje1" runat="server" Text=""></asp:Label>

    <div class="card">
        <asp:TextBox ID="megustaAlbum" runat="server"></asp:TextBox>
        <asp:Button ID="megustaAl" runat="server" Text="Megusta Album" OnClick="megustaAl_Click" />
    </div> 




    <div class="card-header">
        <h5> Canciones  </h5>
    </div>

    <asp:Label ID="canciones" runat="server" Text=""></asp:Label>

    <div class="card-columns">
    <asp:TextBox ID="codigoalbum" runat="server"></asp:TextBox>
    <asp:Button ID="mostrarCanciones" runat="server" Text="mostrar Canciones" OnClick="mostrarCanciones_Click" />
        </div>
    
    <div class="card-columns">
         <asp:Label ID="IngresarCancionAFav" runat="server" Text=""></asp:Label>
        <asp:TextBox ID="favCanciones" runat="server"></asp:TextBox>
        <asp:Button ID="AgragarCancionFav" runat="server" Text="Agregar Cancion Favorito" OnClick="AgragarCancionFav_Click" />

        <asp:Label ID="mensaje2" runat="server" Text="Label"></asp:Label>
        </div>
  

     <div class="card-columns">
         <asp:TextBox ID="txtmegustaCancion" runat="server"></asp:TextBox>
         <asp:Button ID="btnCancionMegusta" runat="server" Text="Me gusta Cancion" OnClick="btnCancionMegusta_Click" />

         </div>




</asp:Content>
