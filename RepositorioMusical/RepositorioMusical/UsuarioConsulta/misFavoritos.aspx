<%@ Page Title="" Language="C#" MasterPageFile="~/UsuarioConsulta/Usuario.Master" AutoEventWireup="true" CodeBehind="misFavoritos.aspx.cs" Inherits="RepositorioMusical.UsuarioConsulta.misFavoritos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Titulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <div class="card-header">
        
    <H5> Aqui van sus favoritos albunes</H5>
    </div>

    <asp:Label ID="Albumes" runat="server" Text="Label"></asp:Label>

     <div class="card-header">
        
    <H5> Aqui van sus favoritos canciones</H5>
    </div>

    <asp:Label ID="Canciones" runat="server" Text="Label"></asp:Label>
</asp:Content>
