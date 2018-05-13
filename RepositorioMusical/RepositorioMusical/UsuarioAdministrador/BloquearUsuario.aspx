<%@ Page Title="Bloquear Usuario" Language="C#" MasterPageFile="~/UsuarioAdministrador/AdministradorGestionUsuarios.master" AutoEventWireup="true" CodeBehind="BloquearUsuario.aspx.cs" Inherits="RepositorioMusical.UsuarioAdministrador.BloquearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body2" runat="server">
    
    <form class="container-fluid " > 
        <div class="card-body espacio-vertical">
        <div class="centrar-pagina">
        <div>
            <h5>Los siguietes datos</h5>
         </div>

        <div class="align-items-center">
        
  <div class="form-group mx-sm-3 mb-2">
    <label for="Correo" class="sr-only">Correo</label>

      <asp:TextBox ID="UCorreo" runat="server" class="form-control " placeholder="Correo Electronico"></asp:TextBox>
       
  </div>
  
        </div>

         <div class="align-items-center">
        

  <div class="form-group mx-sm-3 mb-2">
    <label for="contraseña" class="sr-only">Fecha de Nacimiento</label>
      <asp:TextBox ID="Ufechanac" runat="server"  placeholder="FechadeNac"  class="form-control" ></asp:TextBox>

   
  </div>
              <div class="col-xs-11">
             <asp:Button ID="BloquearUser" Class="btn btn-warning mb-2" runat="server" Text="Bloquear Usuario" OnClick="BloquearUser_Click" />
                </div>
             <asp:HyperLink ID="Regresar" href="AdministradorInicio.aspx" runat="server">Regresar a la pagina principal</asp:HyperLink>
             
             
        </div>
         
    </form>
              
                <div class="col-xs-11">
                <asp:Label ID="error" runat="server" Text=""></asp:Label>
                    </div> 
    </div>


</asp:Content>
