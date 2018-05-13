<%@ Page Title="Artistas Actuales" Language="C#" MasterPageFile="~/UsuarioAdministrador/AdministradorConsultaUsuarios.master" AutoEventWireup="true" CodeBehind="ConsultaArtistasActuales.aspx.cs" Inherits="RepositorioMusical.UsuarioAdministrador.ConsultaArtistasActuales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body2" runat="server">

   
    <div class="card-header">
    <asp:Label ID="artistasActuales" runat="server" Text="Estos son los Artistas actuales en el sistema" Class="Active"></asp:Label>
    <asp:Button ID="mostrarArstistas" runat="server" Text="Mostrar Artistas" class="btn btn-light" OnClick="mostrarArstistas_Click"/>
    </div>

    <div class="card-body espacio-vertical">

        <asp:Label ID="tablitaArtistas" runat="server" Text="">


        </asp:Label>

     </div>

</asp:Content>
