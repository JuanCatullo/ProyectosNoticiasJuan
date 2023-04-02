<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="ProyectosNoticiasJuan.Manager.Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

         <br />     <br />     <br />     <br /> <br />

    <div class="row">
        <div class="col-md-4">

            <asp:TextBox ID="txtname" CssClass="form-control" runat="server" ValidationGroup="Registro"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="Registro" Display="None" ControlToValidate="txtname" ErrorMessage="Falta el nombre"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtlastname" CssClass="form-control" runat="server" ValidationGroup="Registro"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  Display="None" ValidationGroup="Registro" ErrorMessage="Falta el apellido" ControlToValidate="txtlastname"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtdni" CssClass="form-control" runat="server" ValidationGroup="Registro"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="None" ValidationGroup="Registro" runat="server" ErrorMessage="Falta el DNI" ControlToValidate="txtdni"></asp:RequiredFieldValidator>
        </div>
    </div>
    <br />

    <div class="row">
        <div class="col-md-4">
            <asp:DropDownList ID="ddlPais" runat="server" ValidationGroup="Registro" CssClass="form-control" >
                    
                   </asp:DropDownList>
              </div>
        <div class="col-md-4">




        <asp:RadioButtonList ID="rblCurso" runat="server" ValidationGroup="Registro" >
        <asp:ListItem Text="NET" Value="NET"></asp:ListItem>
        <asp:ListItem Text="JAVA" Value="JAVA"></asp:ListItem>
        <asp:ListItem Text="UX/UI" Value="UX/UI"></asp:ListItem>
    </asp:RadioButtonList>
                    </div>
        <div class="col-md-4">
        <asp:CheckBoxList ID="chklConocimientos" runat="server" ValidationGroup="Registro" >
        <asp:ListItem Text="HTML" Value="HTML"></asp:ListItem>
        <asp:ListItem Text="Javascript" Value="Javascript"></asp:ListItem>
        <asp:ListItem Text="Jquery" Value="Jquery"></asp:ListItem>
        <asp:ListItem Text="CSS" Value="CSS"></asp:ListItem>
        <asp:ListItem Text="NET" Value="NET"></asp:ListItem>
        <asp:ListItem Text="SQL Server" Value="SQL Server"></asp:ListItem>
    </asp:CheckBoxList>
                    </div>
    </div>

    <br />

    <div class="row">
        <div class="col-md-4">
            <asp:TextBox ID="txtFecha" TextMode="Date" CssClass="form-control" runat="server" ValidationGroup="Registro"></asp:TextBox>
            
            </div>

        <div class="col-md-4">
            
            </div>

        <div class="col-md-4">
            
            </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-4">

            <asp:Label ID="lblMensajeError" runat="server" Text=""></asp:Label>
            
            <asp:Button ID="cmdEnviar" CssClass="btn btn-primary" runat="server" Text="Enviar" OnClick="cmdEnviar_Click" />
        
        
        </div>

    </div>


    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="Registro" ShowMessageBox="True"  ShowSummary="False" />




</asp:Content>