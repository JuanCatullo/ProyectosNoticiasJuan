using System;
using ProyectosNoticiasJuan.Utilidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Xml.Linq;

namespace ProyectosNoticiasJuan.manager
{
    public partial class Usuario : System.Web.UI.Page
    {
        // como declaro en una variable el value de pais y curso?

        public int iUsuarioId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                //CargarPaises();
                //CargarCurso();
                //CargarConocimientos();
                if (!string.IsNullOrEmpty(Request.QueryString["usuario_id"]))
                {
                    iUsuarioId = Int32.Parse(Request.QueryString["usuario_id"]);
                    CargarDatosUsuario(iUsuarioId);
                    ViewState["ID_USUARIO"] = iUsuarioId;

                    ViewState["MODO"] = "MODIFICACION";




                }
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
            sRet = Utilidades.Datos.ObtenerUsuarioRegistrado(iId, ref dt);
            if (sRet == "")
            {
                if (dt.Rows.Count == 1)
                {

                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["nombre"])))
                    {
                        //txtname.Text = dt.Rows[0]["nombre"].ToString().Trim();

                    }

                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["apellido"])))
                    {
                        //txtlastname.Text = dt.Rows[0]["apellido"].ToString().Trim();

                    }

                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["dni"])))
                    {
                        //txtdni.Text = dt.Rows[0]["dni"].ToString().Trim();

                    }
                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["email"])))
                    {
                        //email.Text = dt.Rows[0]["email"].ToString().Trim();

                    }
                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["nacimiento"]))) ///TODO: fijarse como se llama
                    {
                        //txtFecha.Text = Convert.ToDateTime(dt.Rows[0]["nacimiento"]).ToString("yyyy-MM-dd");


                    }

                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["password"])))
                    {
                        //password.Text = dt.Rows[0]["password"].ToString().Trim();

                    }


                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["pais_id"])))

                    {
                        //ddlpais.SelectedValue = dt.Rows[0]["pais_id"].ToString().Trim();
                    }
                    //if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["cono_id"])))
                    //{
                    //    cono.SelectedValue = dt.Rows[0]["cono_id"].ToString().Trim();
                    //}
                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["curso_id"])))
                    {
                        //curso.SelectedValue = dt.Rows[0]["curso_id"].ToString().Trim();
                    }

                }
            }
        }

        void CargarPaises()
        {
            string sRet = "";
            DataTable dt = new DataTable();

            sRet = Utilidades.Datos.ObtenerPaises(ref dt);

            if (sRet == "")
            {
                //pais.DataValueField = "id";
                //pais.DataTextField = "descripcion";
                //pais.DataSource = dt;
                //pais.DataBind();
            }
        }




        void CargarCurso()
        {
            string sRett = "";
            DataTable dt = new DataTable();

            //sRett = Utilidades.Datos.ObtenerCurso(ref dt);

            if (sRett == "")
            {
                //curso.DataValueField = "id";
                //curso.DataTextField = "descripcion";
                //curso.DataSource = dt;
                //curso.DataBind();
            }
        }
        void CargarConocimientos()
        {
            string sRett = "";
            DataTable dt = new DataTable();

            //sRett = Utilidades.Datos.ObtenerConocimientos(ref dt);

            if (sRett == "")
            {
                //cono.DataValueField = "id";
                //cono.DataTextField = "descripcion";
                //cono.DataSource = dt;
                //cono.DataBind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            string sValidar = ValidarForm();
            if (sValidar != "")
            {

                return;
            }



            if (ViewState["MODO"].ToString().Trim() == "MODIFICACION")
            {
                string sRetorno = "";
                //sRetorno = Datos.ActualizarUsuario(Convert.ToInt32(ViewState["ID_USUARIO"]), txtname.Text.Trim(), txtlast.Text.Trim(), txtdni.Text.Trim(), Convert.ToInt32(pais.SelectedValue), Convert.ToInt32(curso.SelectedValue), email.Text.Trim(), nacimiento.Text.Trim(), cono2.Text.Trim(), pass1.Text.Trim());
                if (sRetorno == "")
                {
                    Response.Redirect("Usuarios.aspx");
                }
            }
            else if (ViewState["MODO"].ToString() == "ALTA")
            {
                string sRetorno = "";
                //sRetorno = Datos.InsertarUsuario(txtname.Text.Trim(), txtlast.Text.Trim(), txtdni.Text.Trim(), Convert.ToInt32(pais.SelectedValue), Convert.ToInt32(curso.SelectedValue), email.Text.Trim(), nacimiento.Text.Trim(), cono2.Text.Trim(), pass1.Text.Trim());
                if (sRetorno == "")
                {
                    Response.Redirect("Usuarios.aspx");
                }
            }
        }



        string ValidarForm()
        {
            string sRet = "";
            DateTime tempDate;
            //if (!DateTime.TryParse(nacimiento.Text, out tempDate))
            {
                sRet = "La fecha no es válida.";
            }
            return sRet;
        }

    }



}

    