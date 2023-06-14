<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PruebasServicios.aspx.cs" Inherits="ProyectosNoticiasJuan.PruebasServicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblHola" runat="server" Text=""></asp:Label>
    <br />

    <asp:Label ID="lblSumar" runat="server" Text=""></asp:Label>

    <br />

    <asp:GridView ID="GridView1" CssClass="table table-striped table-hover table-bordered table-sm" runat="server" AutoGenerateColumns="true"></asp:GridView>

    <br />

    <asp:Button ID="cmdEnviarMail" runat="server" Text="Enviar" OnClick="cmdEnviarMail_Click" />

</asp:Content>
