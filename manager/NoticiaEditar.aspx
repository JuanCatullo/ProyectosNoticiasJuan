<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NoticiaEditar.aspx.cs" Inherits="ProyectosNoticiasJuan.Manager.NoticiaEditar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



        <div class="container-fluid">


        <div class="panel panel-primary">

         <div class="panel-heading">
            <h3 class="panel-title">Editor de Noticias</h3>
        </div>



        <div class="panel-body">
         <div class="form-horizontal">



  <div class="col-md-4"></div>
         
  <div class="col-md-8">

        <div class="form-group">
            <asp:TextBox ID="txtNombre" class="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Falta Nombre"  ControlToValidate="txtNombre" Display="Static" SetFocusOnError="True" CssClass="center-block text-center"></asp:RequiredFieldValidator>

       </div>

          <div class="form-group">
            <asp:TextBox ID="txtCopete" class="form-control" placeholder="Copete" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Falta Copete"  ControlToValidate="txtCopete" Display="Static" SetFocusOnError="True" CssClass="center-block text-center"></asp:RequiredFieldValidator>

       </div>

              <div class="form-group">
              <asp:TextBox ID="txtTexto" class="form-control" placeholder="Texto" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Falta Texto"  ControlToValidate="txtTexto" Display="Static" SetFocusOnError="True"  CssClass="center-block text-center"></asp:RequiredFieldValidator>
         </div>
      <div class="form-group">
              <asp:TextBox ID="txtImagen" class="form-control" placeholder="Imagen" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Falta Imagen"  ControlToValidate="txtImagen" Display="Static" SetFocusOnError="True"  CssClass="center-block text-center"></asp:RequiredFieldValidator>
      </div>
      <div class="form-group">
            <asp:TextBox ID="txtOrden" Cssclass="form-control" placeholder="Orden" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Falta Orden"  ControlToValidate="txtOrden" Display="Static" SetFocusOnError="True"  CssClass="center-block text-center"></asp:RequiredFieldValidator>
        </div>
      <div class="form-group">
            <asp:TextBox ID="txtFecha" Cssclass="form-control" placeholder="Fecha" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Falta Fecha"  ControlToValidate="txtFecha" Display="Static" SetFocusOnError="True"  CssClass="center-block text-center"></asp:RequiredFieldValidator>
        </div>
      <div class="form-group">
            <asp:TextBox ID="txtActivo" Cssclass="form-control" placeholder="Activo" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Falta Activacion"  ControlToValidate="txtActivo" Display="Static" SetFocusOnError="True"  CssClass="center-block text-center"></asp:RequiredFieldValidator>
        </div>
       <div class="form-group">
    <asp:DropDownList ID="categoria" cssClass="form-control" runat="server">
       

    </asp:DropDownList>
        </div>



       


       <div class="form-group">

           <asp:Label ID="Label1" runat="server" CssClass="text-center center-block" ></asp:Label>
            <div class="btn-group" role="group">

                <asp:Button ID="Button1" type="submit" Cssclass="btn btn-default center-block" role="group" runat="server" Text="Enviar"  OnClick="Button1_Click"  />

                <asp:Button ID="Button2" type="submit" Cssclass="btn btn-default center-block" role="group" runat="server" Text="Cancelar" />
            </div>

        </div>

      </div>



             </div>
        </div>
   </div>
    </div>

</asp:Content>