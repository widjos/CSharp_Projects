<%@ Page Title="" Language="C#" MasterPageFile="~/UsuarioArtista/ArtistaPrincipal.Master" AutoEventWireup="true" CodeBehind="MisAlbumes.aspx.cs" Inherits="RepositorioMusical.UsuarioArtista.MisAlbumes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button ID="MostrarAlbumes" runat="server" Text="Button" OnClick="MostrarAlbumes_Click" />
    <asp:Panel ID="Panel1" runat="server"></asp:Panel>

</asp:Content>

