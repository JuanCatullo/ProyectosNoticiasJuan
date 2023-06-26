<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecordatorioClave.aspx.cs" Inherits="ProyectosNoticiasJuan.RecordatorioClave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:TextBox ID="Usuario" runat="server">Usuario</asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Usuario" ErrorMessage="El campo usuario es obligatorio." />


    <asp:TextBox ID="txtEmail" runat="server">Email</asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="El campo email es obligatorio." />
      
    <div>
    <Button ID="RClave" runat="server" Text="Recordar Clave" CssClass="btn btn-info" OnClick="btnRecordarClave_Click"
         style="width: 150px; height: 50px; background-color: #0066FF;"/></div>      



</asp:Content>
