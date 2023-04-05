<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlMenuNavegacion.ascx.cs" Inherits="ProyectosNoticiasJuan.ctrlMenuNavegacion" %>



<div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse" title="more options">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="~/">Proyecto Juan Noticias</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/">Inicio</a></li>
                         <li><a runat="server" href="~/About">Acerca de</a></li>
                        <li><a runat="server" href="~/Contact">Contacto</a></li>


                         <asp:PlaceHolder ID="plcManager" runat="server">
                        <li><a runat="server" href="~/manager/Usuarios">Usuarios</a></li>
                        <li><a runat="server" href="~/manager/Noticias">Noticias</a></li>
                        <li class="nav-item">
                            <asp:LinkButton CssClass="nav-link" ID="lnkSalir" runat="server" OnClick="lnkSalir_Click" OnClientClick="return confirm('Está seguro que desea salir?');">Salir</asp:LinkButton>
                        </li>
                        </asp:PlaceHolder>


                    </ul>
                </div>
            </div>
        </div>