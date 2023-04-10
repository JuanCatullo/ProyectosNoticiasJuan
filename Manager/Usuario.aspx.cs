using ProyectosNoticiasJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ProyectosNoticiasJuan.manager
{
    public partial class Usuario : System.Web.UI.Page
    {
        int iUsuarioId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                CargarPaises();
                CargarCursos();
                CargarConocimientos();

                //VIENE PARA VER UN USUARIO, ME FIJO SI EL PARAMETRO VIENE Y SI TIENE VALOR
                if (!string.IsNullOrEmpty(Request.QueryString["usuario_id"]))
                {
                    //LLENO LA VARIABLE GLOBAL CON LO QUE TRAE EL PARAMETRO
                    iUsuarioId = Int32.Parse(Request.QueryString["usuario_id"]);

                    //CARGO DATOS DEL USUARIO
                    CargarDatosUsuario(iUsuarioId);

                    ViewState["ID_USUARIO"] = iUsuarioId;
                    ViewState["MODO"] = "MODIFICACION";
                }
                // CARGO LOS DATOS DEL USUARIO
                else
                {
                    ViewState["MODO"] = "ALTA";
                }

            }
        }



        void CargarDatosUsuario(int iId)
        {


            string sRet = "";
            DataTable dt = new DataTable();
            sRet = Datos.ObtenerUsuariosRegistrados(iId, ref dt);

            if (dt.Rows.Count == 1)
            {

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["nombre"])))
                {
                    txtNombre.Text = dt.Rows[0]["nombre"].ToString().Trim();
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["apellido"])))
                {
                    txtApellido.Text = dt.Rows[0]["apellido"].ToString().Trim();
                }


                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["dni"])))
                {
                    txtDni.Text = dt.Rows[0]["dni"].ToString().Trim();
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["id_pais"])))
                {
                    ddlPais.SelectedValue = dt.Rows[0]["id_pais"].ToString().Trim();
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["curso_id"])))
                {
                    RadioButtonList1.SelectedValue = dt.Rows[0]["curso_id"].ToString().Trim();
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["conocimientos"])))
                {
                    CblConocimiento.Text = dt.Rows[0]["conocimientos"].ToString().Trim();
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["email"])))
                {
                    txtEmail.Text = dt.Rows[0]["email"].ToString().Trim();
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["fecha_nacimiento"])))
                {
                    txtFecha.Text = dt.Rows[0]["fecha_nacimiento"].ToString().Trim();
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["conocimientos"])))
                {
                    txtOConocimientos.Text = dt.Rows[0]["conocimientos"].ToString().Trim();
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["contraseña"])))
                {
                    txtClave.Text = dt.Rows[0]["contraseña"].ToString().Trim();
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["contraseña"])))
                {
                    txtClave1.Text = dt.Rows[0]["contraseña"].ToString().Trim();
                }

                


            }
            else
            {
                Utilidades.Utils.ShowAlertAjax(this.Page, "No se encontro el usuario", "");
            }

        }




        void CargarPaises()
        {
            string sRet = "";
            DataTable dt = new DataTable();

            sRet = Utilidades.Datos.ObtenerPaises(ref dt);

            if (sRet == "")
            {
                ddlPais.DataValueField = "id";
                ddlPais.DataTextField = "descripcion";
                ddlPais.DataSource = dt;
                ddlPais.DataBind();
            }

        }

        void CargarCursos()
        {
            string sRet = "";
            DataTable dt = new DataTable();

            sRet = Utilidades.Datos.ObtenerCursos(ref dt);

            if (sRet == "")
            {
                RadioButtonList.DataValueField = "id";
                RadioButtonList1.DataTextField = "descripcion";
                RadioButtonList1.DataSource = dt;
                RadioButtonList1.DataBind();
            }
        }

        void CargarConocimientos()
        {
            string sRet = "";
            DataTable dt = new DataTable();

            sRet = Utilidades.Datos.ObtenerConocimientos(ref dt);

            if (sRet == "")
            {
                CblConocimiento.DataValueField = "id";
                CblConocimiento.DataTextField = "descripcion";
                CblConocimiento.DataSource = dt;
                CblConocimiento.DataBind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["MODO"].ToString() == "MODIFICACION")
            {
                string sRetorno = "";
                sRetorno = Utilidades.Datos.ActualizarUsuario(Convert.ToInt32(ViewState["ID_USUARIO"]), txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtDni.Text.Trim(), txtEmail.Text.Trim(), Convert.ToInt32(ddlPais.SelectedValue), Convert.ToInt32(RadioButtonList1.SelectedValue), Convert.ToDateTime(txtFecha.Text.Trim()), txtOConocimientos.Text.Trim(), txtClave.Text.Trim());

                if (sRetorno == "")
                {
                    Utils.ShowAlertAjax(this.Page, "Usuario actualizado exitosamente", "");

                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "Error al borrar: " + sRetorno, "");
                }
            }
            else if (ViewState["MODO"].ToString() == "ALTA")
            {

                string sRetorno = "";
                sRetorno = Datos.InsertarUsuario(Convert.ToInt32(ViewState["ID_USUARIO"]), txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtDni.Text.Trim(), txtEmail.Text.Trim(), Convert.ToInt32(ddlPais.SelectedValue), Convert.ToInt32(RadioButtonList1.SelectedValue), Convert.ToDateTime(txtFecha.Text.Trim()), txtOConocimientos.Text.Trim(), txtClave.Text.Trim());

                if (sRetorno == "")
                {
                    Utils.ShowAlertAjax(this.Page, "Usuario agregado exitosamente", "Usuarios");

                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "Error al borrar: " + sRetorno, "");
                }
            }

        }
    }
}
    



