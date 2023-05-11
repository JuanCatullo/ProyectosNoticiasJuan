<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="ProyectosNoticiasJuan.manager.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




        <div class="container-fluid">


        <div class="panel panel-primary">

         <div class="panel-heading">
            <h3 class="panel-title">Formulario Registro</h3>
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
            <asp:TextBox ID="txtApellido" class="form-control" placeholder="Apellido" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Falta Apellido"  ControlToValidate="txtApellido" Display="Static" SetFocusOnError="True" CssClass="center-block text-center"></asp:RequiredFieldValidator>

       </div>

              <div class="form-group">
            <asp:TextBox ID="txtDni" class="form-control" placeholder="DNI" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Falta Dni"  ControlToValidate="txtDni" Display="Static" SetFocusOnError="True"  CssClass="center-block text-center"></asp:RequiredFieldValidator>
         </div>


       <div class="form-group">
    <asp:DropDownList ID="ddlPais" cssClass="form-control" runat="server">
       

    </asp:DropDownList>
        </div>


       <div class="form-group">

            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            
            </asp:RadioButtonList>

       </div>

       <div class="form-group">

                <asp:CheckBoxList ID="CblConocimiento"  runat="server" >
                    
                </asp:CheckBoxList>

        </div>



        <div class="form-group">
            <asp:TextBox ID="txtEmail" Cssclass="form-control" placeholder="Email" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Falta Email"  ControlToValidate="txtEmail" Display="Static" SetFocusOnError="True"  CssClass="center-block text-center"></asp:RequiredFieldValidator>
        </div>

       <div class="form-group">
            <asp:TextBox ID="txtFecha"  Cssclass="form-control" placeholder="Fecha de Nacimiento" runat="server"></asp:TextBox>
       </div>


       <div class="form-group"> 
           <asp:TextBox ID="txtOConocimientos" Cssclass="form-control" placeholder="Otros Conocimientos" runat="server"></asp:TextBox>
       </div>


       <div class="form-group">
               <asp:TextBox ID="txtClave" Cssclass="form-control" TextMode="Password" placeholder="Clave" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Falta Password"  ControlToValidate="txtClave" Display="Static" SetFocusOnError="True"  CssClass="center-block text-center"></asp:RequiredFieldValidator>
       </div>    


       <div class="form-group">
           <asp:TextBox ID="txtClave1" Cssclass="form-control" TextMode="Password" placeholder="Repetir Clave" runat="server"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Verifique la password"  ControlToValidate="txtClave1" Display="Static" SetFocusOnError="True"  CssClass="center-block text-center"></asp:RequiredFieldValidator>

       </div> 


       <div class="form-group">

           <asp:Label ID="Label1" runat="server" CssClass="text-center center-block" ></asp:Label>
            <div class="btn-group" role="group">

                <asp:Button ID="Button1" type="submit" Cssclass="btn btn-default center-block" role="group" runat="server" Text="Enviar" OnClick="Button1_Click" />

                <asp:Button ID="Button2" type="submit" Cssclass="btn btn-default center-block" role="group" runat="server" Text="Cancelar" />
            </div>

        </div>

      </div>



             </div>
        </div>
   </div>
    </div>

</asp:Content>


