<%@ Page Title="" Language="C#" MasterPageFile="~/UsuarioArtista/ArtistaPrincipal.Master" AutoEventWireup="true" CodeBehind="CancionesAlbum.aspx.cs" Inherits="RepositorioMusical.UsuarioArtista.CancionesAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    	  <div class="card-header">
        <asp:label   class="col-form-label" runat="server" text="Aqui puede ver las canciones actuales de su Album"></asp:label>
        </div>
    <div class="row">
        <asp:button id="mostrarCancion" runat="server" text="Mostrar mis canciones"  class="btn btn-outline-secondary" OnClick="mostrarCancion_Click" />
        <asp:Button ID="crearNuevoAlbum" runat="server" Text="Agregar Nuevo Album uwu"  class="btn btn-outline-secondary" OnClick="crearNuevoAlbum_Click"  />
        </div>
    <asp:imagebutton runat="server"></asp:imagebutton>

       <div class=" espacio-vertical">
        <asp:Label ID="misalbums" runat="server" Text=""></asp:Label>
        
           <!-- Esta es la conficuracion del Grid que almacena todos los botones que se tienen -->         
           <div class="card-columns">
           <asp:Panel ID="Panel1" runat="server" class="card" >
               <div class="card" style="width: 25rem;"></div>


           </asp:Panel>
             </div>
     </div>


</asp:Content>
