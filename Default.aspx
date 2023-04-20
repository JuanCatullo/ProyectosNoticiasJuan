<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectosNoticiasJuan._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        
        <div class="row col-md-4">
            <asp:DropDownList CssClass="form-select"  ID="dlCategorias" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dlCategorias_SelectedIndexChanged"></asp:DropDownList>
           
           
        </div>

        <br />
        <br />

        <asp:Label ID="lblRegistros" runat="server" Text=""></asp:Label>
        
        <br />

        <div class="row">
            <asp:GridView ID="gvNoticias" CssClass="table" runat="server" AutoGenerateColumns="False" EmptyDataText="No se encontraron registros">
                <Columns>


                    <asp:BoundField DataField="titulo" HeaderText="Titulo" />
                    <asp:BoundField DataField="descripcion" HeaderText="Categoría" />
                    <asp:BoundField DataField="fecha" HeaderText="Fecha" DataFormatString="{0:D}" />
                   





                    <asp:TemplateField HeaderText="Imagen">
                        <ItemTemplate>
                            <asp:Image ID="Image1" Width="100" runat="server" ImageUrl='<%# ImagenNoticia(Eval("imagen")) %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                   





                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# LinkNoticia(Eval("id")) %>' Text="Ir a la Noticia"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>


                </Columns>
                
            </asp:GridView>
        </div>
    </main>

</asp:Content> 
    