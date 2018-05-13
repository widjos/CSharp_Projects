<%@ Page Title="Mis Albumes" Language="C#" MasterPageFile="~/UsuarioArtista/ArtistaPrincipal.Master" AutoEventWireup="true" CodeBehind="MostrarMisAlbums.aspx.cs" Inherits="RepositorioMusical.UsuarioArtista.MostrarMisAlbums" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    		  <div class="card-header">
        <asp:label   class="col-form-label" runat="server" text="En esta Seccion podra visualizar sus Albums"></asp:label>
        </div>
    <div class="row">
        <asp:button id="mostrarAlbums" runat="server" text="Mostrar mis Albumes"  class="btn btn-outline-secondary" OnClick="mostrarAlbums_Click" />
        <asp:Button ID="crearNuevoAlbum" runat="server" Text="Agregar Nuevo Album uwu"  class="btn btn-outline-secondary" OnClick="crearNuevoAlbum_Click"  />
        </div>

    <div class="containter">
       <div class=" espacio-vertical">
        <asp:Label ID="misalbums" runat="server" Text="Aqui hay albumes"></asp:Label>
        
           <!-- Esta es la conficuracion del Grid que almacena todos los botones que se tienen -->         
           <div class="card-columns">
           <asp:Panel ID="albumPanel" runat="server" class="panel-body panel-resizable" >
               <div class="card" style="width: 25rem;"></div>

             
           </asp:Panel>
            
             </div>
     </div>
        </div>

         <!--Controlador para desplegar la tablita con sus botones   10>06-->
                <div class="container-fluid">
     
                    <div class="row espacio-vertical">
                

                        <div style="width: 25px">

                            
       
                    <h3><asp:Label ID="acciones" runat="server" Text="Acciones"></asp:Label></h3>

                            <asp:Panel ID="Panel1" runat="server" class="panel-body panel-resizable">
                                <ul class="list-group"></ul>
                            </asp:Panel>

		
                           
         

                          
                        </div>
                    </div>
                </div>


</asp:Content>
