<%@ Page Title="" Language="C#" MasterPageFile="~/UsuarioArtista/ArtistaPrincipal.Master" AutoEventWireup="true" CodeBehind="Artista.aspx.cs" Inherits="RepositorioMusical.UsuarioArtista.Artista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            margin-top: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card-header">
        <h5> Informacion de artista  </h5>
        </div>


    <div class=" container centrarbox">

        <div class="row espacio-vertical">
               <div class="espacio-derecha">
            <asp:Label ID="Nombreart" class="col-xs-6 " runat="server" Text="Nombre del Artista"></asp:Label>
                   </div>
            <div class="ubicaraladerecha">
                <asp:TextBox ID="TextNombArt" class="col-xs-4 anchura-mas form-control" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
        </div>
        <div class="row espacio-vertical">
               <div class="espacio-derecha">
            <asp:Label ID="anolbl" runat="server" Text="Año de Formacion" class="col-xs-6 "></asp:Label>
                   </div>
            <div class="ubicaraladerecha">
                <asp:TextBox ID="anoTex" runat="server" class="col-xs-4 anchura-mas form-control " OnTextChanged="anoTex_TextChanged" ></asp:TextBox>
            </div>

        </div>
        <div class="row espacio-vertical">
               <div class="espacio-derecha">
            <asp:Label ID="paislbl" runat="server" Text="Pais" class="col-xs-6 "></asp:Label>
                   </div>
            <div class="ubicaraladerecha">
                <asp:TextBox ID="paisTxt" runat="server" class="col-xs-4 anchura-mas form-control"></asp:TextBox>
            </div>

        </div>

        <div class="row espacio-vertical">
               <div class="espacio-derecha">
            <asp:Label ID="descripcionlbl" runat="server" Text="Descripción" class="col-xs-6"></asp:Label>
                   </div>
            <div class="ubicaraladerecha">
                <asp:TextBox ID="descripArtista" TextMode="multiline" Columns="50" Rows="5" runat="server" class="col-xs-4 anchura-mas form-control" MaxLength="100"  OnTextChanged="descripArtista_TextChanged" ></asp:TextBox>
            </div>

        </div>
      
        <div class="row espacio-vertical">
               <div class="espacio-derecha">
            <asp:Label ID="fotoPortada" runat="server" Text="Foto de Portada" class="col-xs-6  "></asp:Label>
                   </div>
            <div class="ubicaraladerecha">
                <div class="card" style="width: 18rem;">
                <asp:Image ID="imagenArtista"  runat="server" class="card-img"  />
                <asp:FileUpload ID="cambiarImag"  runat="server" class="col-xs-4 form" />
                    </div>
            </div>


            <div class="row espacio-vertical">
                   <div class="espacio-derecha">
                <asp:Label ID="generolbl" runat="server" Text="Genero" class="col-xs-6  "></asp:Label>
                       </div>
                <div class="ubicaraladerecha">
                    <asp:TextBox ID="generoTxt" runat="server" class="col-xs-4 anchura-mas form-control "></asp:TextBox>
                </div>
            </div>

            <div class="row espacio-vertical">
                   <div class="espacio-derecha">
                <asp:Label ID="facebookLabel" runat="server" Text="Facebook" class="col-xs-6  "></asp:Label>
                </div>
                       <div class="ubicaraladerecha">
                    <asp:TextBox ID="faceText" runat="server" class="col-xs-4 anchura-mas form-control " OnTextChanged="faceText_TextChanged"></asp:TextBox>
                </div>
            </div>

            <div class="row espacio-vertical">
                   <div class="espacio-derecha">
                <asp:Label ID="twitlbl" runat="server" Text="Twitter" class="col-xs-6  "></asp:Label>
               </div>
                       <div class="ubicaraladerecha">
                    <asp:TextBox ID="twitTxt" runat="server" class="col-xs-4 anchura-mas form-control " OnTextChanged="twitTxt_TextChanged"></asp:TextBox>
                </div>
            </div>
            <div class="row espacio-vertical">
                   <div class="espacio-derecha">
                <asp:Label ID="youtubeLabel" runat="server" Text="Youtube" class="col-xs-6  "></asp:Label>
               </div>
                       <div class="ubicaraladerecha">
                    <asp:TextBox ID="youtubTxt" runat="server" class="col-xs-4 anchura-mas form-control " OnTextChanged="youtubTxt_TextChanged"></asp:TextBox>
                </div>
            </div>
            <div class="row espacio-vertical">
                   <div class="espacio-derecha">
                <asp:Label ID="paginaLbl" runat="server" Text="Pagina Web" class="col-xs-6  "></asp:Label>
               </div>
                       <div class="ubicaraladerecha">
                    <asp:TextBox ID="paginaTxt" runat="server" class="col-xs-4 anchura-mas form-control " OnTextChanged="paginaTxt_TextChanged"></asp:TextBox>
                </div>
            </div>

            <div class="row espacio-vertical">
                <div class="ubicaraladerecha">
                    <asp:Button ID="eliminarBT" runat="server" Text="Eliminar Artista" class="col-xs-6 btn btn-primary" OnClick="eliminarBT_Click" />
                    </div>
                <div class="ubicaraladerecha">
                    <asp:Button ID="actualizaBT" runat="server" Text="Actualizar Artista" class="col-xs-6 btn btn-primary" OnClick="actualizaBT_Click" />
                    </div>
              </div>
            </div>

        </div>

</asp:Content>
