<%@ Page Title="" Language="C#" MasterPageFile="~/UsuarioAdministrador/Administrador.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="RepositorioMusical.UsuarioAdministrador.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="card-header">
        <h5>Aqui van sus reportes nuevos</h5>
        </div>

    <asp:Button ID="masinfluyentes" runat="server" Text="Artistas Mas Influyentes" OnClick="masinfluyentes_Click" />

    <asp:Label ID="influyentes" runat="server" Text=""></asp:Label>

    <asp:Button ID="favoritos" runat="server" Text="Favoritos" OnClick="favoritos_Click" />
    <asp:Label ID="lbfab" runat="server" Text=""></asp:Label>

</asp:Content>
