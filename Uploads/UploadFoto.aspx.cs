using Microsoft.SqlServer.Server;
using ProyectosNoticiasJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan.manager
{
    public partial class UploadFoto : System.Web.UI.Page
    {

        String sFolderUploads = "uploads";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdUpload_Click(object sender, EventArgs e)
        {
            if (fFotoNoticia.HasFile)
            {
                if (System.IO.Path.GetExtension(fFotoNoticia.FileName.ToString().ToUpper()) == ".JPG")
                {

                    string sFileName = System.Guid.NewGuid().ToString() + ".jpg";

                    fFotoNoticia.PostedFile.SaveAs(HttpContext.Current.Server.MapPath("/") + sFolderUploads + "/" + sFileName);

                    imgFoto.ImageUrl = "../uploads/" + sFileName;
                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "El archivo no es JPG", "");
                }
            }
            else
            {
                Utils.ShowAlertAjax(this.Page, "No subiste archivo", "");
            }
        }
    }
}