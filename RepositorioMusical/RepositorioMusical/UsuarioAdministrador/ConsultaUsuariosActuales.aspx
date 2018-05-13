<%@ Page Title="Consulta Usuarios Actuales" Language="C#" MasterPageFile="~/UsuarioAdministrador/AdministradorConsultaUsuarios.master" AutoEventWireup="true" CodeBehind="ConsultaUsuariosActuales.aspx.cs" Inherits="RepositorioMusical.UsuarioAdministrador.ConsultaUsuariosActuales" %>


<asp:Content ID="body2" ContentPlaceHolderID="body2" runat="server">
    <div class="card-header">
    <asp:Label ID="usuariosActuales" runat="server" Text="Estos son los usuarios actuales en el sistema" Class="Active"></asp:Label>
    <asp:Button ID="mostrarUser" runat="server" Text="Mostrar Usuarios" class="btn btn-light" OnClick="mostrarUser_Click"/>
    </div>

    <div class="card-body espacio-vertical">

        <asp:Label ID="codigo" runat="server" Text="">


        </asp:Label>

     </div>


</asp:Content>
