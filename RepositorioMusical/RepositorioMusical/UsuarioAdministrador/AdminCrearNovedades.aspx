<%@ Page Title="" Language="C#" MasterPageFile="~/UsuarioAdministrador/Administrador.Master" AutoEventWireup="true" CodeBehind="AdminCrearNovedades.aspx.cs" Inherits="RepositorioMusical.UsuarioAdministrador.AdminCrearNovedaes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titulo" runat="server">
    Crear Novedades
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 359px;
            height: 178px;
            position: absolute;
            top: 2746px;
            left: 293px;
            z-index: 1;
        }
    </style>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

        <!--Agregar Informacion -->


        <div class="card-header">
        <h5> Aqui puede generar novedades para todos los usuarios</h5>
        </div>
    
    <div class=" container centrarbox"">
       
                  <div class="row espacio-vertical">
               <div class="espacio-derecha">
            <asp:Label ID="tituloNovedad" class="col-xs-6 " runat="server" Text="Titulo : "></asp:Label>
                   </div>
            <div class="ubicaraladerecha">
                <asp:TextBox ID="tituloTXT" class="col-xs-4 anchura-mas form-control" runat="server" placeholder="Ingrese un Titulo llamativo para el publico" MaxLength="100"></asp:TextBox>
            </div>
        </div>

                <div class="row espacio-vertical">
               <div class="espacio-derecha">
            <asp:Label ID="contenido" class="col-xs-6 " runat="server" Text="Contenido : "></asp:Label>
                   </div>
            <div class="ubicaraladerecha">
                <asp:TextBox ID="contenidoTXT" class="col-xs-4 anchura-mas form-control" runat="server" placeholder="Aqui va la informacion pertinente." Columns="50" Rows="6" MaxLength="100" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>



        <div class="row espacio-vertical">
            <div class="espacio-derecha">
                <asp:Label ID="imagendeNovedad" runat="server" Text="Selecciona una imagen: " class="col-xs-6  "></asp:Label>
            </div>
            <div class="ubicaraladerecha">
                <div class="card" style="width: 18rem;">
                    <asp:Image ID="imagen" runat="server" class="card-img" />
                    <asp:FileUpload ID="subirfotoNovedad" runat="server" class="col-xs-4 form" />
                    <asp:Button ID="crearNovedad" runat="server" Text="Crear Novedad" class="btn btn-outline-primary" OnClick="crearNovedad_Click"  />

                </div>
            </div>

            <div class="row espacio-vertical">
                <div class="ubicaraladerecha">
                    <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>
                </div>
            </div>
                    </div>
        </div>


    <div class="espacio-vertical">
        
    </div>

   


  
   

    


    


   


</asp:Content>
