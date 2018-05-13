<%@ Page Title="" Language="C#" MasterPageFile="~/UsuarioConsulta/Usuario.Master" AutoEventWireup="true" CodeBehind="Tendencias.aspx.cs" Inherits="RepositorioMusical.UsuarioConsulta.Tendencias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Titulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">

    <div class=" card-header">
        <H5> ARTISTAS MAS INFLUYENTES TOP 10 </H5>
        </div>

    <asp:Label ID="top1" runat="server" Text="artistasiNFLU"></asp:Label>

    <div class=" card-header">
        <H5> CANCIONES DE ARTISTAS MAS INFLUYENTES TOP 10 </H5>
        </div>
    <asp:Label ID="TOP2" runat="server" Text="Label"></asp:Label>

    <div class=" card-header">
        <H5>ALBUMES POPULARES </H5>
        </div>
    <asp:Label ID="TOP3" runat="server" Text="Label"></asp:Label>



</asp:Content>
