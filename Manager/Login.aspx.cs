﻿using ProyectosNoticiasJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan.Manager
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdLogin_Click(object sender, EventArgs e)
        {
            string sRet = "";
            sRet = ValidarForm();

            DataTable dt = new DataTable();

            //LLAMO AL STORED PROCEDURE PARA AUTENTICAR
            sRet = Datos.LoginUsuario(txtUsuario.Text.Trim(), txtClave.Text.Trim(), ref dt);

            if (sRet == "")
            {
                //ME COINCIDIO UN USUARIO
                if (dt.Rows.Count == 1)
                {

                    //GUARDO EN SESSION LOS DATOS QUE QUIERO USAR
                    //  Session["USUARIO_ID"] = dt.Rows[0]["id"].ToString();
                    //  Session["USUARIO_NOMBRE"] = dt.Rows[0]["apellido"].ToString() + ", " + dt.Rows[0]["nombre"].ToString();


                    Clases.Usuario UsuarioLogueado = new Clases.Usuario();
                    UsuarioLogueado.UsuarioID = int.Parse(dt.Rows[0]["id"].ToString());
                    UsuarioLogueado.Nombre = dt.Rows[0]["nombre"].ToString();
                    UsuarioLogueado.Apellido = dt.Rows[0]["apellido"].ToString();

                    Session["USUARIO"] = UsuarioLogueado;

                 



                    //SETEO LA COOKIE DE AUTENTICACION Y DESPUES REDIRIJO A LA HOME DEL MANAGER
                    System.Web.Security.FormsAuthentication.SetAuthCookie(txtUsuario.Text.Trim(), true);
                    Response.Redirect("/Default.aspx");

                }
                else
                {
                    Utilidades.Utils.ShowAlertAjax(this.Page, "Usuario y clave no coinciden.", "");
                }

            }
            else
            {
                Utilidades.Utils.ShowAlertAjax(this.Page, sRet, "");
            }



        }


        string ValidarForm()
        {
            string sRetorno = "";

            if (txtUsuario.Text.Trim() == "" || txtClave.Text.Trim() == "")
            {
                sRetorno = "Falta ingresar el usuario o clave";
            }
            return sRetorno;
        }
    }
}
