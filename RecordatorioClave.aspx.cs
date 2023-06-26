using ProyectosNoticiasJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectosNoticiasJuan
{
        public partial class RecordatorioClave : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {

            }

            protected void btnRecordarClave(object sender, EventArgs e)
            {
                string mail = txtEmail.Text;
                bool bRetorno = false;
                string sMessageErrorMail = "";





                string contrasena = Utilidades.Datos.ObtenerContrasena(mail);

                if (!string.IsNullOrEmpty(contrasena))
                {
                    bRetorno = Utils.SendEmail(mail, "", "", "", "Recordatorio de Clave", "Usuario: " + mail + "\nClave: " + contrasena, System.Net.Mail.MailPriority.Normal, "Martin Dopazo", ref sMessageErrorMail);
                    if (bRetorno)
                    {
                        Utils.ShowAlertAjax(this.Page, "El mail se envio correctamente", "");
                    }
                    else
                    {
                        Utils.ShowAlertAjax(this.Page, "Hubo un error: " + sMessageErrorMail, "");
                    }
                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "Hubo un error: EL MAIL NO EXISTE", "");
                }
            }
        }



    }