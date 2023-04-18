<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectosNoticiasJuan._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
 

    <div class="row">
        <asp:DropDownList CssClass="form-control" ID="dlCategorias" runat="server" AutoPostback="true" onSelectedIndexChanged="dlCategorias_SelectedIndexChanged" ></asp:DropDownList>
        
    </div>
   <div class="row">
        <asp:GridView CssClass="table" ID="gvNoticias" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="titulo" HeaderText="Titulo" />
                <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                 <asp:BoundField DataField="descripcion" HeaderText="Categoria" />
                <asp:HyperLinkField Text="Ir a la Noticia" />
            </Columns>

        </asp:GridView>
   </div>
 
    
</asp:Content>