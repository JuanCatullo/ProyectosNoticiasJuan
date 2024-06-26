﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrlMenuNavegacion.ascx.cs" Inherits="ProyectosNoticiasJuan.ctrlMenuNavegacion" %>


<nav class="navbar navbar-expand-sm navbar-light bg-light" aria-label="">
    <div class="container-fluid">
     <a class="navbar-brand" href="#">Proyecto Noticias</a>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarsExample02" aria-controls="navbarsExample02" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>

      <div class="collapse navbar-collapse" id="navbarsExample03">
        <ul class="navbar-nav me-auto mb-2 mb-sm-0">
          
          <li class="nav-item"><a class="nav-link" runat="server" href="~/">Inicio</a></li>
                        <li class="nav-item"><a class="nav-link" runat="server" href="~/About">Acerca de</a></li>
                        <li class="nav-item"><a class="nav-link" runat="server" href="~/Contact">Contacto</a></li>
                      

          
                  

          
        <asp:PlaceHolder ID="plcManager" runat="server">
          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" data-bs-toggle="dropdown" aria-expanded="false">Administración</a>
            <ul class="dropdown-menu">

                 <asp:PlaceHolder ID="plcUsuarios" runat="server">
                    <li class="nav-item"><a class="dropdown-item" runat="server" href="~/manager/UsuariosRegistrados">Usuarios</a></li>
                </asp:PlaceHolder>

              <li class="nav-item"><a class="dropdown-item" runat="server" href="~/manager/Usuario">Crear Usuario</a></li>
              <li class="nav-item"><a class="dropdown-item" runat="server" href="~/manager/Noticias">Editar Noticias</a></li>
                <li class="nav-item"><a class="dropdown-item" runat="server" href="~/Default">Noticias cargadas</a></li>
              <li class="nav-item"><a class="dropdown-item" runat="server" href="~/manager/UsuariosRegistrados"> Usuarios Cargados</a></li>
            </ul>
          </li>
        </asp:PlaceHolder>

              <li>
                           <asp:LinkButton CssClass="nav-link" ID="lnkSalir" runat="server" OnClick="lnkSalir_Click" OnClientClick="return confirm('Está seguro que desea salir?');">Salir</asp:LinkButton>
                        </li>
                      

        </ul>

      </div>
    </div>
  </nav>