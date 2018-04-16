<%@ Page Title="" Language="C#" MasterPageFile="~/UsuarioConsulta/Usuario.Master" AutoEventWireup="true" CodeBehind="RegistrarArtista.aspx.cs" Inherits="RepositorioMusical.UsuarioConsulta.RegistrarArtista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Titulo" runat="server">
    Registrar Usuario 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    
    <!--Registrarse -->

                <div class="centrar-pagina">

                    <h5 class="col-xl-12">Ingrese los datos que se le piden acontinuacion.</h5>
                    <label class="col-xs-11">Nombre</label>
                    <div class="col-xl-11">
                        <asp:TextBox ID="Nombre" runat="server" class="form-control" placeholder="Nombre"></asp:TextBox>
                    </div>
                     <label class="col-xs-11">Año de formación</label>
                    <div class="col-xl-11">
                        <asp:TextBox ID="Formacion" runat="server" class="form-control" placeholder="AAAA/MM/DD"></asp:TextBox>
                    </div>
                    <label class="col-xs-11">Pais</label>
                    <div class="col-xs-11">
                    <asp:dropdownlist ID="Pais" class="form-control" runat="server"></asp:dropdownlist>
                     </div>
                    <label class="col-xl-11">Descripcion del Artista</label>
                    <div class="col-11">
                        <asp:TextBox ID="Descripcion" runat="server" class="form-control" placeholder="Hablenos de usted"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Facebook</label>
                    <div class="col-11">
                        <asp:TextBox ID="FB" runat="server" class="form-control" placeholder="Ingrese su Facebook"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Twitter</label>
                    <div class="col-11">
                        <asp:TextBox ID="Twitt" runat="server" class="form-control" placeholder="Ingrese su Twitter"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Youtube</label>
                    <div class="col-11">
                        <asp:textbox id="Youtube" runat="server" class="form-control" placeholder="Ingrese su canal de Youtube"></asp:textbox>
                    </div>
                    <label class="col-xl-11">PaginaWeb</label>
                    <div class="col-11">
                        <asp:textbox id="PaginaWeb" runat="server" class="form-control" placeholder="Ingrese su pagina Web"></asp:textbox>
                    </div>


                    <div class="col-11 espacio-vertical"> 
                        <asp:button ID="CrearArtista" runat="server" text="Crear Artista" class="btn btn-success" OnClick="CrearArtista_Click" />
                       
                      

                    </div>
                    <div class="col-1 espacio-vertical">

                        <asp:label ID="Mensaje" runat="server" Text="" class="col-xl-11"></asp:label>

                    </div>


                </div>
       

</asp:Content>
