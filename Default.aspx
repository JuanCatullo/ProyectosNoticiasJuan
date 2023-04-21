<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectosNoticiasJuan._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">


        
        <div class="row col-md-3">
            <asp:DropDownList CssClass="form-select"  ID="dlCategorias" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dlCategorias_SelectedIndexChanged"></asp:DropDownList>
        
        </div>

        <br />
       

        <div class="row col-md-4">
        <asp:Label ID="lblRegistros" runat="server" Text=""></asp:Label>
        </div>
        <br />

        <div class="row">

            <div class="table-responsive">
            <asp:GridView ID="gvNoticias" CssClass="table table-striped table-hover table-bordered table-sm" runat="server" AutoGenerateColumns="False" EmptyDataText="No se encontraron registros">
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
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# LinkNoticia(Eval("id_noticia")) %>' Text="Ir a la Noticia"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>


                </Columns>
                
            </asp:GridView>
            </div>


        </div>





    </div>

</asp:Content>