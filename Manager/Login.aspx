<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectosNoticiasJuan.Manager.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     
    <h1>Log in</h1>

         
    
        <div class="row">
            
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <div class="mb-3">
                <asp:TextBox ID="txtUsuario" TextMode="Email" runat="server" required CssClass="form-control "></asp:TextBox>
                </div>

                <div class="mb-3">
                <asp:TextBox ID="txtClave" TextMode="Password" required runat="server"  CssClass="form-control "></asp:TextBox>
                </div>


                <div class="d-flex justify-content-center align-items-center mb-3">
                    <asp:Button ID="cmdLogin" runat="server" Text="Ingresar" CssClass="btn btn-info" OnClick="cmdLogin_Click"/>
                </div>

            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                
            </section>
        </div>


</asp:Content>