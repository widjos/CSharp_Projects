<%@ Page Title="" Language="C#" MasterPageFile="~/UsuarioConsulta/Usuario.Master" AutoEventWireup="true" CodeBehind="MostrarGeneros.aspx.cs" Inherits="RepositorioMusical.UsuarioConsulta.MostrarGeneros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Titulo" runat="server">
    Generos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <div class="card-header" >
    <asp:Button ID="mostrarGenero" runat="server" Text="Button" />



       </div>
    <asp:Panel ID="panelGenero" runat="server"></asp:Panel>
     <div class=" espacio-vertical">
        <asp:Label ID="novedadeslbl" runat="server" Text=""></asp:Label>
     </div>
    

    

</asp:Content>
