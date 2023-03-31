<%@ Page Title="UsuariosRegistrados" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuariosRegistrados.aspx.cs" Inherits="ProyectosNoticiasJuan.Manager.UsuariosRegistrados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">

              <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="id" OnRowCommand="gvUsuarios_RowCommand">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                    <asp:BoundField DataField="email" HeaderText="Email" />
                
              

                 <asp:TemplateField HeaderText="Editar">
                        <ItemTemplate>
                            <asp:Button ID="cmdEditarUsuario" runat="server" Text="Editar Usuario" CommandName="EDITAR" CommandArgument='<%#Eval("id") %>'  />
                        </ItemTemplate>
                        
                   </asp:TemplateField>


                    <asp:TemplateField HeaderText="Eliminar">
                        <ItemTemplate>
                            <asp:Button ID="cmdEliminarUsuario" runat="server" Text="Eliminar Usuario" CommandName="ELIMINAR" CommandArgument='<%#Eval("id") %>' OnClientClick="return confirm('Está seguro que desea eliminar al usuario?');"  />
                        </ItemTemplate>
                        
                    </asp:TemplateField>
                    
                </Columns>
            </asp:GridView>
            
        </div>
        
    </div>



</asp:Content>