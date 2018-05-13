<%@ Page Title="Artistas Eliminados" Language="C#" MasterPageFile="~/UsuarioAdministrador/AdministradorEliminados.master" AutoEventWireup="true" CodeBehind="AdminArtistasEliminados.aspx.cs" Inherits="RepositorioMusical.UsuarioAdministrador.AdminArtistasEliminados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cuerpo" runat="server">
        <div class="card-header">
    <asp:Label ID="lblEliminados" runat="server" Text="Estos son los Artistas actuales en el sistema" Class="Active"></asp:Label>
    <asp:Button ID="btnMostrareliminados" runat="server" Text="ArtistasEliminados" class="btn btn-light" OnClick="btnMostrareliminados_Click" />
    </div>

    <div class="card-body espacio-vertical">

        <asp:Label ID="tablitaArtEliminados" runat="server" Text="">


        </asp:Label>

     </div>

</asp:Content>
