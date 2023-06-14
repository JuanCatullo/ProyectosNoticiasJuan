<%@ Page Title="UsuariosRegistrados" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuariosRegistrados.aspx.cs" Inherits="ProyectosNoticiasJuan.manager.UsuariosRegistrados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <p> <asp:Label ID="lblCuentaRegistros" runat="server" Text=""></asp:Label></p>

    <div class="row">
        <div class="col-md-12">


            <asp:GridView cssClass=" table-striped table-hover table-bordered text-center" ID="gvUsuarios" runat="server" AutoGenerateColumns="False"  EmptyDataText="No se encontraron registros" DataKeyNames="id" OnRowCommand="gvUsuarios_RowCommand" AllowPaging="true" PageSize="5" AllowSorting="true" OnSorting="gvUsuarios_Sorting" PagerSettings-Mode="NumericFirstLast" OnPageIndexChanging="gvUsuarios_PageIndexChanging">
                <Columns>
                     <asp:BoundField DataField="id" HeaderText="ID" SortExpression="id" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre"  SortExpression="nombre"></asp:BoundField>
                    <asp:BoundField DataField="apellido" HeaderText="Apellido"  SortExpression="apellido"></asp:BoundField>
                    <asp:BoundField DataField="email" HeaderText="Email"  SortExpression="email"></asp:BoundField>
                <asp:TemplateField HeaderText="Editar">

                    <ItemTemplate>

                        <asp:Button ID="cmdEditarUsuario" runat="server" Text="Editar Usuario" CommandName="EDITAR" CommandArgument='<%#Eval("id") %>' />
                    </ItemTemplate>
                    

                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Eliminar">                        <ItemTemplate>                            <asp:Button ID="cmdEliminarUsuario" runat="server" Text="Eliminar Usuario" CommandName="ELIMINAR" CommandArgument='<%#Eval("id") %>' OnClientClick="return confirm('Está seguro que desea eliminar al usuario?');"  />                        </ItemTemplate>                                            </asp:TemplateField>

                    

             

                </Columns>
            </asp:GridView>



        </div>




    </div>










</asp:Content>