<%@ Page Title="" Language="C#" MasterPageFile="~/UsuarioConsulta/Usuario.Master" AutoEventWireup="true" CodeBehind="Novedades.aspx.cs" Inherits="RepositorioMusical.UsuarioConsulta.Novedades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Titulo" runat="server">
    Novedades
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">

          <div class="card-header">
            <h5> Aqui se encuentran las novedades. </h5>
            </div>

    <div class=" espacio-vertical">
        <asp:Label ID="novedadeslbl" runat="server" Text=""></asp:Label>
     </div>
    
    
</asp:Content>
