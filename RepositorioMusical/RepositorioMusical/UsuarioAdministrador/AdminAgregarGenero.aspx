<%@ Page Title="Administrador Agregar Genero" Language="C#" MasterPageFile="~/UsuarioAdministrador/AdministradorGestionUsuarios.master" AutoEventWireup="true" CodeBehind="AdminAgregarGenero.aspx.cs" Inherits="RepositorioMusical.UsuarioAdministrador.AdminAgregarGenero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body2" runat="server">
        <!--Registrarse -->


        <div class="card-header">
        <h5> Registro de Genero nuevo</h5>
        </div>
    <div class=" container centrarbox"">


                  <div class="row espacio-vertical">
               <div class="espacio-derecha">
            <asp:Label ID="NombrGenero" class="col-xs-6 " runat="server" Text="Nombre del Genero: "></asp:Label>
                   </div>
            <div class="ubicaraladerecha">
                <asp:TextBox ID="generoTXT" class="col-xs-4 anchura-mas form-control" runat="server" placeholder="Gnero que quiere crear" ></asp:TextBox>
            </div>
        </div>



        <div class="row espacio-vertical">
            <div class="espacio-derecha">
                <asp:Label ID="ImagenGenero" runat="server" Text="Selecciona una imagen" class="col-xs-6  "></asp:Label>
            </div>
            <div class="ubicaraladerecha">
                <div class="card" style="width: 18rem;">
                    <asp:Image ID="imagen" runat="server" class="card-img" />
                    <asp:FileUpload ID="subirfotoGenero" runat="server" class="col-xs-4 form" />
                    <asp:Button ID="crearGenero" runat="server" Text="Crear genero" class="btn btn-success" OnClick="crearGenero_Click" />

                </div>
            </div>

            <div class="row espacio-vertical">
                <div class="ubicaraladerecha">
                    <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>
                </div>
            </div>
                    </div>
</asp:Content>
