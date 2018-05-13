<%@ Page Title="Albumes Eliminados" Language="C#" MasterPageFile="~/UsuarioAdministrador/AdministradorEliminados.master" AutoEventWireup="true" CodeBehind="AdminAlbumesEliminados.aspx.cs" Inherits="RepositorioMusical.UsuarioAdministrador.AdminAlbumesEliminados" %>


<asp:Content ID="Content1" ContentPlaceHolderID="cuerpo" runat="server">

         <div class="card-header">
    <asp:Label ID="lblEliminados" runat="server" Text="Estos son los Albumes eliminados actuales en el sistema" Class="Active"></asp:Label>
    <asp:Button ID="btnMostrareliminados" runat="server" Text="Albumes Eliminados" class="btn btn-light" OnClick="btnMostrareliminados_Click" />
    </div>

    <div class="card-body espacio-vertical">

        <asp:Label ID="tablitaAlbumEliminados" runat="server" Text="">


        </asp:Label>

     </div>

</asp:Content>
