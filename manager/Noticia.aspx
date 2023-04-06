﻿<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Noticia.aspx.cs" Inherits="ProyectosNoticiasJuan.Manager.Noticias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
   <div>
       <div>
           <asp:GridView ID="gvNoticias" runat="server" AutoGenerateColumns="False" OnRowCommand="gvNoticias_RowCommand">
               <Columns>
                   <asp:BoundField DataField="ID" HeaderText="ID" />
                   <asp:BoundField DataField="Titulo" HeaderText="Titulo" />
                   <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
                   <asp:BoundField DataField="Activo" HeaderText="Activo" />


                   <asp:TemplateField HeaderText="Editar">

                     <ItemTemplate>
                         <asp:Button ID="cmdEditarNoticia" runat="server" Text="Editar Noticia" CommandName="EDITAR" CommandArgument='<%#Eval("id") %>'  />
                     </ItemTemplate>
                   </asp:TemplateField>

                  <asp:TemplateField HeaderText="Eliminar">
                   <ItemTemplate>
                         <asp:Button ID="cmdEliminarNoticia" runat="server" Text="Eliminar Noticia" CommandName="ELIMINAR" CommandArgument='<%#Eval("id") %>' OnClientClick="return confirm('Esta seguro que quiere borrar al usuario');"/>
                     </ItemTemplate>
                   </asp:TemplateField>

               </Columns>
               
           </asp:GridView>
            <br />
            <ItemTemplate>
                         <asp:Button ID="cmdCrearNoticia" runat="server" Text="Crear Noticia" CommandName="CREAR" CommandArgument='<%#Eval("id") %>' OnClick="Btn_Crear" />
                     </ItemTemplate>
       </div>
   </div>
</asp:Content>