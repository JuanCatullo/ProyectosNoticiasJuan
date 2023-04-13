<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadFoto.aspx.cs" Inherits="ProyectosNoticiasJuan.manager.UploadFoto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="row">
            
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <div class="">
                    <asp:FileUpload ID="fFotoNoticia" CssClass="form-control" runat="server" />
                    
                </div>
                 
                <br /><br />

                <div class="">
                    <asp:Button ID="cmdUpload" runat="server" Text="Subir Foto" CssClass="btn btn-info" OnClick="cmdUpload_Click"/>
                </div>

                 <br /><br />

                <asp:Image ID="imgFoto" runat="server" />


            </section>
           
        </div>

</asp:Content>

