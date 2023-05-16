<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Noticias.aspx.cs" Inherits="ProyectosNoticiasJuan.manager.Noticias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
    
   
    <div class="row">
        <div class="col-md-12">

                     <asp:GridView cssClass=" table-striped table-hover table-bordered text-center" ID="gvNoticias" runat="server" AutoGenerateColumns="False" OnRowCommand="gvNoticias_RowCommand">
               <Columns>
                   
                    <asp:BoundField DataField="titulo" HeaderText="Noticia"></asp:BoundField>
                    <asp:BoundField DataField="descripcion" HeaderText="Categoria"></asp:BoundField>

                   <asp:TemplateField HeaderText="Editar">

                     <ItemTemplate>
                         <asp:Button ID="cmdEditarNoticia" runat="server" Text="Editar Noticia" CommandName="EDITAR" CommandArgument='<%#Eval("id_noticia") %>'  />
                     </ItemTemplate>
                   </asp:TemplateField>

                  <asp:TemplateField HeaderText="Eliminar">
                   <ItemTemplate>
                         <asp:Button ID="cmdEliminarNoticia" runat="server" Text="Eliminar Noticia" CommandName="ELIMINAR" CommandArgument='<%#Eval("id_noticia") %>' OnClientClick="return confirm('Esta seguro que quiere borrar la noticia');"/>
                     </ItemTemplate>
                   </asp:TemplateField>

               </Columns>
               
           </asp:GridView>
            <br />
            <ItemTemplate>
                 <div class="d-flex justify-content-center align-items-center">
                         <asp:Button ID="cmdCrearNoticia" runat="server" Text="Crear Noticia" CommandName="CREAR" CommandArgument='<%#Eval("id_noticia") %>' OnClick="Btn_Crear" />
                     </ItemTemplate>


           </div>
       </div>
  

    </div>
  

</asp:Content>