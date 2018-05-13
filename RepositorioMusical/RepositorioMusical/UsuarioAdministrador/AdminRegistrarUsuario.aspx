<%@ Page Title="Admin Registra Usuario" Language="C#" MasterPageFile="~/UsuarioAdministrador/AdministradorGestionUsuarios.master" AutoEventWireup="true" CodeBehind="AdminRegistrarUsuario.aspx.cs" Inherits="RepositorioMusical.UsuarioAdministrador.AdminRegistrarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body2" runat="server">

    <!--Registrarse -->



                <div class="centrar-pagina">

                    <h5 class="col-xl-12">Ingrese los datos que se le piden acontinuacion.</h5>
                    <label class="col-xs-11">Nombre</label>
                    <div class="col-xl-11">
                        <asp:TextBox ID="Nombre" runat="server" class="form-control" placeholder="Nombre"></asp:TextBox>
                    </div>
                     <label class="col-xs-11">Apellido</label>
                    <div class="col-xl-11">
                        <asp:TextBox ID="apellido" runat="server" class="form-control" placeholder="Apellido"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Fecha de Nacimiento</label>
                    <div class="col-11">
                        <asp:TextBox ID="FechaNac" runat="server" class="form-control" placeholder="AAAA-MM-DD"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Correo electronico</label>
                    <div class="col-11">
                        <asp:TextBox ID="CorreoElect" runat="server" class="form-control" placeholder="fulanito@dominio.com"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Usuario</label>
                    <div class="col-11">
                        <asp:TextBox ID="NomUser" runat="server" class="form-control" placeholder="Usuario"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Contraseña</label>
                    <div class="col-11">
                        <asp:TextBox ID="Contraseña" runat="server" class="form-control" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
                    </div>
                    <label class="col-xl-11">Verificacion de Contraseña</label>
                    <div class="col-11">
                        <asp:TextBox ID="ContraseñaVerificacion" runat="server" class="form-control" placeholder="Escriba de nuevo su contraseña"></asp:TextBox>
                    </div>

                    <div class="col-11 espacio-vertical"> 
                        <asp:Button ID="CrearCuenta" runat="server" Text="Crear cuenta" class="btn btn-success" OnClick="CrearCuenta_Click"  />
                      

                    </div>
                    <div class="col-1 espacio-vertical">
                        <asp:Label ID="Mensaje" runat="server" Text="" class="col-xl-11"></asp:Label>

                    </div>


                </div>
</asp:Content>
