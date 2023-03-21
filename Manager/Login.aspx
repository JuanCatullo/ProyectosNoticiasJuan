<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectosNoticiasJuan.manager.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>LOGIN</h1>


    
        <div class="row">
            
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <div class="">
                <asp:TextBox ID="txtUsuario" TextMode="Email" runat="server" required CssClass="form-control "></asp:TextBox>
                </div>

                <div class="">
                <asp:TextBox ID="txtClave" TextMode="Password" required runat="server"  CssClass="form-control "></asp:TextBox>
                </div>


                <div class="">
                    <asp:Button ID="cmdLogin" runat="server" Text="Ingresar" CssClass="btn btn-info" OnClick="cmdLogin_Click"/>
                </div>

            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                
            </section>
        </div>


</asp:Content>