using ProyectosNoticiasJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan.Manager
{
    public partial class NoticiaEditar : System.Web.UI.Page
    {
        String sFolderUploads = "uploads";
        protected void Page_Load(object sender, EventArgs e)
        {
            int iNoticiaId = 0;
            if (!Page.IsPostBack)
            {

                CargarCategoria();
                //VIENE PARA VER UN USUARIO, ME FIJO SI EL PARAMETRO VIENE Y SI TIENE VALOR
                if (!string.IsNullOrEmpty(Request.QueryString["noticia_id"]))
                {
                    //LLENO LA VARIABLE GLOBAL CON LO QUE TRAE EL PARAMETRO
                    iNoticiaId = Int32.Parse(Request.QueryString["noticia_id"]);

                    //CARGO DATOS DEL USUARIO
                    CargarDatosNoticia(iNoticiaId);

                    ViewState["ID_NOTICIA"] = iNoticiaId;
                    ViewState["MODO"] = "MODIFICACION";
                }
                // CARGO LOS DATOS DEL USUARIO
                else
                {
                    ViewState["MODO"] = "ALTA";
                }

                
            


            }




        }
        void CargarDatosNoticia(int iId)
        {

            string sRet = "";
            DataTable dt = new DataTable();
            sRet = Utilidades.Datos.ObtenerNoticia(iId, ref dt);

            if (dt.Rows.Count == 1)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["titulo"])))
                {
                    txtNombre.Text = dt.Rows[0]["titulo"].ToString().Trim();
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["copete"])))
                {
                    txtCopete.Text = dt.Rows[0]["copete"].ToString().Trim();
                }
                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["texto"])))
                {
                    txtTexto.Text = dt.Rows[0]["texto"].ToString().Trim();
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["Orden"])))
                {
                    txtOrden.Text = dt.Rows[0]["Orden"].ToString().Trim();
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["Fecha"])))
                {
                    txtFecha.Text = dt.Rows[0]["Fecha"].ToString().Trim();
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["Activa"])))
                {
                    txtActivo.Text = dt.Rows[0]["Activa"].ToString().Trim();
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["imagen"])))
                {
                    imgFoto.ImageUrl = "../uploads/" + dt.Rows[0]["imagen"].ToString().Trim();
                }

                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["id_categoria"])))
                {
                    categoria.SelectedValue = dt.Rows[0]["id_categoria"].ToString().Trim();
                }


            }


            //else
            //{
            //    Utilidades.Utils.ShowAlertAjax(this.Page, "No se encontro el usuario", "");
            //}

        }


        void CargarCategoria()
        {
            string sRet = "";
            DataTable dt = new DataTable();

            sRet = Datos.ObtenerCategoria(ref dt);

            if (sRet == "")
            {
                categoria.DataValueField = "id";
                categoria.DataTextField = "descripcion";
                categoria.DataSource = dt;
                categoria.DataBind();
            }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {


            string sRet = "";
            string sFileName = "";
            sRet = SubirFoto(ref sFileName);
            if (sRet != "")
            {
                Utils.ShowAlertAjax(this.Page, sRet, "");
                return;
            }



            if (ViewState["MODO"].ToString() == "MODIFICACION")
            {



                string sRetorno = "";
                sRetorno = Datos.ActualizarNoticia(Convert.ToInt32(ViewState["ID_NOTICIA"]), txtNombre.Text.Trim(), txtCopete.Text.Trim(), txtTexto.Text.Trim(), sFileName, Convert.ToInt32(txtOrden.Text.Trim()), Convert.ToDateTime(txtFecha.Text.Trim()), Convert.ToInt32(txtActivo.Text.Trim()), Convert.ToInt32(categoria.SelectedValue));

                if (sRetorno == "")
                {
                    Utils.ShowAlertAjax(this.Page, "Noticia actualizada exitosamente", "");
                    Response.Redirect("Noticias.aspx");
                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "Error al borrar: " + sRetorno, "");
                }
            }
            else if (ViewState["MODO"].ToString() == "ALTA")
            {

                string sRetorno = "";
                sRetorno = Datos.InsertarNoticia(txtNombre.Text.Trim(), txtCopete.Text.Trim(), txtTexto.Text.Trim(),sFileName, Convert.ToInt32(txtOrden.Text.Trim()), Convert.ToDateTime(txtFecha.Text.Trim()), Convert.ToInt32(txtActivo.Text.Trim()), Convert.ToInt32(categoria.SelectedValue));

                if (sRetorno == "")
                {
                    Utils.ShowAlertAjax(this.Page, "Noticia agregada exitosamente", "");
                    Response.Redirect("Noticias.aspx");
                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "Error al borrar: " + sRetorno, "");
                }
            }

        }

     


        string SubirFoto(ref string sFileName)
        {

            string sRet = "";


            if (imgFoto.ImageUrl == "")
            {

                if (FileUpload1.HasFile)
                {
                    if (System.IO.Path.GetExtension(FileUpload1.FileName.ToString().ToUpper()) == ".JPG")
                    {

                        sFileName = System.Guid.NewGuid().ToString() + ".jpg";

                        FileUpload1.PostedFile.SaveAs(HttpContext.Current.Server.MapPath("/") + sFolderUploads + "/" + sFileName);

                        //imgFoto.ImageUrl = "../uploads/" + sFileName;
                    }
                    else
                    {
                        sRet = "El archivo no es JPG";
                    }
                }
                else
                {
                    sRet = "No subiste archivo";
                }

            }
            else
            {

                if (FileUpload1.HasFile)
                {
                    if (System.IO.Path.GetExtension(FileUpload1.FileName.ToString().ToUpper()) == ".JPG")
                    {

                        sFileName = System.Guid.NewGuid().ToString() + ".jpg";

                        FileUpload1.PostedFile.SaveAs(HttpContext.Current.Server.MapPath("/") + sFolderUploads + "/" + sFileName);

                        imgFoto.ImageUrl = "../uploads/" + sFileName;
                    }
                    else
                    {
                        sRet = "El archivo no es JPG";
                    }
                }
                else
                {
                    sFileName = imgFoto.ImageUrl.ToString().Replace("../uploads/", "").Trim();
                }


            }



            return sRet;

        }


    }
}