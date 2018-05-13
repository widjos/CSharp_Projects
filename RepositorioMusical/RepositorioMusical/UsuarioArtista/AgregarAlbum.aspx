<%@ Page Title="AgregarAlbum" Language="C#" MasterPageFile="~/UsuarioArtista/ArtistaPrincipal.Master" AutoEventWireup="true" CodeBehind="AgregarAlbum.aspx.cs" Inherits="RepositorioMusical.UsuarioArtista.AgregarAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card-header">
        <h5> Registro de Album </h5>
        </div>

    
     <div class=" container centrarbox">

        <div class="row espacio-vertical">
               <div class="espacio-derecha">
            <asp:Label ID="NombrTitulo" class="col-xs-6 " runat="server" Text="Titulo: "></asp:Label>
                   </div>
            <div class="ubicaraladerecha">
                <asp:TextBox ID="tituloTxt" class="col-xs-4 anchura-mas form-control" runat="server" placeholder="Titulo de su Album" ></asp:TextBox>
            </div>
        </div>
        <div class="row espacio-vertical">
               <div class="espacio-derecha">
            <asp:Label ID="fechalbl" runat="server" Text="Fecha:" class="col-xs-6 "></asp:Label>
                   </div>
            <div class="ubicaraladerecha">
                <asp:TextBox ID="fechaTxt" runat="server" class="col-xs-4 anchura-mas form-control " palceholder="AAAA/MM/DD"></asp:TextBox>
            </div>

        </div>
        <div class="row espacio-vertical">
               <div class="espacio-derecha">
            <asp:Label ID="resenalbl" runat="server" Text="Reseña: " class="col-xs-6 "></asp:Label>
                   </div>
            <div class="ubicaraladerecha">
                <asp:TextBox ID="resenaTxt" runat="server" class="col-xs-4 anchura-mas form-control" TextMode="multiline" Columns="50" Rows="5" placeholder="Describa esta maravilla"></asp:TextBox>
            </div>

        </div>

      
        <div class="row espacio-vertical">
               <div class="espacio-derecha">
            <asp:Label ID="fotoPortadaAlbum" runat="server" Text="Foto de Portada: " class="col-xs-6  "></asp:Label>
                   </div>
            <div class="ubicaraladerecha">
                <div class="card" style="width: 18rem;">
                <asp:Image ID="imagenAlbum"  runat="server" class="card-img"  />
                <asp:FileUpload ID="subirfotoAlbum"  runat="server" class="col-xs-4 form" />
                    </div>
            </div>
     
            <div class="row espacio-vertical">
                   
                        <div class="espacio-derecha">

                            <asp:Label ID="cancionlbl" runat="server" Text="Cancion: " class="col-xs-6  "></asp:Label>
                               <asp:Button ID="agregarCancion" runat="server" class="col-xs-4 anchura-mas btn btn-danger" Text="Agregar" OnClick="agregarCancion_Click" />
                    <asp:FileUpload ID="subirCancion" runat="server"  class="form-control" />                                     
                         
                        </div>


                <!--Controlador para desplegar la tablita con sus botones   10>06-->
                <div class="container-fluid">
     
                    <div class="row espacio-vertical">
                        <div class="col-sm-9">
                            <asp:Label ID="cancionesTabla" runat="server" Text="aqui va su tab"></asp:Label>
                        </div>

                        <div style="width: 25px">

                            
       
                    <h3><asp:Label ID="acciones" runat="server" Text="Acciones"></asp:Label></h3>

                            <asp:Panel ID="Panel1" runat="server" class="panel-body panel-resizable">
                                <ul class="list-group"></ul>
                            </asp:Panel>

		
                           
         

                          
                        </div>
                    </div>
                </div>

            </div>
         
     
            <div class="row espacio-vertical">
                <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>
            </div>
           
    
             <div class="row espacio-vertical">
            <div class="ubicaraladerecha">
                <asp:Button ID="Cancelar" runat="server" Text="Cancelar"  class="col-xs-4 anchura-mas btn btn-outline-danger" />
                <asp:Button ID="crearAlbum" runat="server" Text="Finalizar" class="col-xs-4 anchura-mas btn btn-outline-success" OnClick="crearAlbum_Click" />
            </div>
                 </div>
    </div>



</asp:Content>
