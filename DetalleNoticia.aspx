<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleNoticia.aspx.cs" Inherits="ProyectosNoticiasJuan.DetalleNoticia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class="container-fluid">

<div class="card text-center" >

    <asp:Image ID="imgNoticia" CssClass="card-img-top" ImageUrl="Descargas/img1" runat="server" Width="400" />

  <div class="card-body">
    <h3 class="card-title"><asp:Label ID="lblTitulo" runat="server" Text="Titulo Noticia"></asp:Label></h3>
    
      <h5 class="card-title"><asp:Label ID="lblCopete" runat="server" Text="Copete Noticia"></asp:Label></h5>
      <p class="card-text text-bg-danger">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
      
      
      <a href="javascript:history.back();" class="btn btn-primary">Volver</a>

  
  </div>



</div>



</div>

</asp:Content>