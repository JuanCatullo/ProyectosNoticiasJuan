using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ProyectosNoticiasJuan.Utilidades
{
    public class Utils
    {


        #region "Javascripts"
        public static string ReplaceEnters(string str)
        {
            return str.Replace(System.Environment.NewLine, "<br>");
        }


        private static string ReplaceQuotes(string str)
        {
            return str.Replace("'", "''");
        }


        private static string ReplaceJsQuotes(string str)
        {
            return str.Replace("'", "\\'");
        }

        /// <summary>
        /// Muestra un alert de javascript
        /// </summary>
        /// <param name="oPage">El objeto PAGE donde se va a ejecutar el alert</param>
        /// <param name="sMessage">Mensaje a mostrar en el alert</param>
        public static void ShowAlert(Page oPage, string sMessage)
        {
            string CsName = System.Guid.NewGuid().ToString();
            Type cstype = oPage.GetType();
            ClientScriptManager cs = oPage.ClientScript;

            if (!cs.IsClientScriptBlockRegistered(CsName))
            {
                string cstext = "alert('" + SafeJavascript(sMessage) + "');" + System.Environment.NewLine;
                cs.RegisterStartupScript(cstype, CsName, cstext, true);
            }
        }

        /// <summary>
        /// Muestra un alert de javascript y redirecciona
        /// </summary>
        /// <param name="oPage">El objeto PAGE donde se va a ejecutar el alert</param>
        /// <param name="sMessage">Mensaje a mostrar en el alert</param>
        /// <param name="sUrlRedirect">URL para redirigir</param>
        public static void ShowAlert(Page oPage, string sMessage, string sUrlRedirect)
        {
            string CsName = System.Guid.NewGuid().ToString();
            Type cstype = oPage.GetType();
            ClientScriptManager cs = oPage.ClientScript;

            if (!cs.IsClientScriptBlockRegistered(CsName))
            {
                string cstext = "alert('" + SafeJavascript(sMessage) + "');" + System.Environment.NewLine;
                cstext = cstext + "location.href ='" + sUrlRedirect + "';" + System.Environment.NewLine;
                cs.RegisterStartupScript(cstype, CsName, cstext, true);
            }
        }

        /// <summary>
        /// Muestra un alert de javascript y redirecciona cuando se está usando AJAX con el ScriptManager
        /// </summary>
        /// <param name="oPage">El objeto PAGE donde se va a ejecutar el alert</param>
        /// <param name="sMessage">Mensaje a mostrar en el alert</param>
        /// <param name="sUrlRedirect">URL para redirigir</param>
        public static void ShowAlertAjax(Page oPage, string sMessage, string sUrlRedirect)
        {
            string CsName = System.Guid.NewGuid().ToString();
            Type cstype = oPage.GetType();

            string cstext = "alert('" + SafeJavascript(sMessage) + "');" + System.Environment.NewLine;

            if (!string.IsNullOrEmpty(sUrlRedirect.Trim()))
            {
                cstext = cstext + "location.href = '" + sUrlRedirect.Trim() + "';";
            }
            ScriptManager.RegisterClientScriptBlock(oPage, oPage.GetType(), CsName, cstext, true);
        }

        /// <summary>
        /// Crea un confirm de javascript
        /// </summary>
        /// <param name="oBtn">Objeto botón -link button-</param>
        /// <param name="sMessage">Mensaje a mostrar en el confirm</param>
        public static void CrearConfirmLinkButton(ref System.Web.UI.WebControls.LinkButton oBtn, string sMessage)
        {
            oBtn.Attributes.Add("onclick", "return confirm('" + SafeJavascript(sMessage) + "')");
        }

        /// <summary>
        /// Crea un confirm de javascript
        /// </summary>
        /// <param name="oBtn">Objeto botón -command button-</param>
        /// <param name="sMessage">Mensaje a mostrar en el confirm</param>
        public static void CrearConfirmCommandButton(ref System.Web.UI.WebControls.Button oBtn, string sMessage)
        {
            oBtn.Attributes.Add("onclick", "return confirm('" + SafeJavascript(sMessage) + "')");
        }

        /// <summary>
        /// Crea un confirm de javascript
        /// </summary>
        /// <param name="oBtn">Objeto botón -Image button-</param>
        /// <param name="sMessage">Mensaje a mostrar en el confirm</param>
        public static void CrearConfirmImageButton(ref System.Web.UI.WebControls.ImageButton oBtn, string sMessage)
        {
            oBtn.Attributes.Add("onclick", "return confirm('" + SafeJavascript(sMessage) + "')");
        }

        private static string SafeJavascript(string sMessage)
        {
            sMessage = sMessage.Replace(System.Environment.NewLine, "\\n");
            sMessage = sMessage.Replace("'", "\\'");
            return sMessage;
        }

        /// <summary>
        /// Bre ventana por Javascript
        /// </summary>
        /// <param name="sPage">Objeto Page a dónde se va a abrir la ventana</param>
        /// <param name="sPagina">Url de la página a levantar</param>
        /// <param name="sTitle">Título de la página a mostrar</param>
        /// <param name="sParam">Parámetros del window.open</param>
        public static void OpenWindow(Page sPage, string sPagina, string sTitle, string sParam)
        {
            string CsName = System.Guid.NewGuid().ToString();
            Type cstype = sPage.GetType();
            ClientScriptManager cs = sPage.ClientScript;

            if (!cs.IsClientScriptBlockRegistered(CsName))
            {
                string cstext = "window.open('" + sPagina + "','" + sTitle + "','" + sParam + "');";
                cs.RegisterStartupScript(cstype, CsName, cstext, true);
            }
        }

        /// <summary>
        /// Cierra la ventana abierta con un window.open
        /// </summary>
        /// <param name="sPage">Objeto Page a dónde se va a cerrar la ventana</param>
        /// <param name="bRefreshPadre">Valor booleano que indica si el opener debe refrescarse</param>
        /// <param name="sMessageAlert">Mensaje que quiera mostrarse. Opcional.</param>
        public static void CloseWindow(Page sPage, bool bRefreshPadre, string sMessageAlert)
        {
            string CsName = System.Guid.NewGuid().ToString();
            Type cstype = sPage.GetType();
            ClientScriptManager cs = sPage.ClientScript;

            System.Text.StringBuilder myscript = new System.Text.StringBuilder("");

            if (!string.IsNullOrEmpty(sMessageAlert))
            {
                myscript.Append("alert('" + SafeJavascript(sMessageAlert) + "');" + System.Environment.NewLine);
            }

            if (bRefreshPadre)
            {
                myscript.Append("opener.location.href=opener.location.href;" + System.Environment.NewLine);
            }
            myscript.Append("window.close();" + System.Environment.NewLine);

            if (!cs.IsClientScriptBlockRegistered(CsName))
            {
                string cstext = myscript.ToString();
                cs.RegisterStartupScript(cstype, CsName, cstext, true);
            }
        }

        /// <summary>
        /// Mueve la página hasta el Anchor indicado
        /// </summary>
        /// <param name="oPage">Objeto Page a dónde se va a ejecutar el movimiento</param>
        /// <param name="sHash">Anchor adónde debe moverse la ventana</param>
        public static void GoToAnchor(Page oPage, string sHash)
        {
            string CsName = System.Guid.NewGuid().ToString();
            Type cstype = oPage.GetType();
            ClientScriptManager cs = oPage.ClientScript;

            if (!cs.IsClientScriptBlockRegistered(CsName))
            {
                string cstext = "function moveWindow() {" + System.Environment.NewLine;
                cstext = cstext + "window.location.hash='" + sHash + "';" + System.Environment.NewLine;
                cstext = cstext + "}";
                cstext = cstext + "moveWindow();";
                cs.RegisterStartupScript(cstype, CsName, cstext, true);
            }

        }

        /// <summary>
        /// Mueve la página hasta el Anchor indicado si se usa Ajax
        /// </summary>
        /// <param name="sPage">Objeto Page a dónde se va a ejecutar el movimiento</param>
        /// <param name="sAnchor">Anchor adónde debe moverse la ventana</param>
        public static void GoToAnchorAjax(Page sPage, string sAnchor)
        {
            string CsName = System.Guid.NewGuid().ToString();
            Type cstype = sPage.GetType();

            string cstext = "";
            cstext = cstext + "var obj = document.getElementById('" + sAnchor + "');" + System.Environment.NewLine;
            cstext = cstext + "var d = obj.offsetTop;" + System.Environment.NewLine;
            cstext = cstext + "setTimeout(\"window.scroll(0,d)\",0);" + System.Environment.NewLine;
            ScriptManager.RegisterClientScriptBlock(sPage, sPage.GetType(), CsName, cstext, true);


        }


        public static void GoBack(Page oPage)
        {

            string CsName = System.Guid.NewGuid().ToString();
            Type cstype = oPage.GetType();
            ClientScriptManager cs = oPage.ClientScript;

            if (!cs.IsClientScriptBlockRegistered(CsName))
            {
                string cstext = "window.history.back();" + System.Environment.NewLine;
                cs.RegisterStartupScript(cstype, CsName, cstext, true);
            }




        }


        public static void MostrarLoadingAjax(Page sPage, UpdateProgress cUdpdatePanel)
        {
            string CsName = System.Guid.NewGuid().ToString();
            Type cstype = sPage.GetType();

            string cstext = "";
            cstext = cstext + "window.onsubmit = Function() {" + System.Environment.NewLine;
            cstext = cstext + "If(Page_IsValid) {" + System.Environment.NewLine;
            cstext = cstext + "var UpdateProgress = $find(\"" + cUdpdatePanel.ClientID + "\");" + System.Environment.NewLine;
            cstext = cstext + "window.setTimeout(Function() {" + System.Environment.NewLine;
            cstext = cstext + "UpdateProgress.set_visible(True);" + System.Environment.NewLine;
            cstext = cstext + "}, 100);" + System.Environment.NewLine;
            cstext = cstext + "}" + System.Environment.NewLine;
            cstext = cstext + "}" + System.Environment.NewLine;

            ScriptManager.RegisterClientScriptBlock(sPage, sPage.GetType(), CsName, cstext, true);

        }


        #endregion



        #region "Acceso a páginas del manager"

        public static bool TieneAcceso(string sNombrePagina, int iPerfilId)
        {
            bool bRet = false;

            switch (sNombrePagina)
            {
                //SOLO LOS ADMIN TIENEN ACCESO
                case "USUARIOS":

                    if (iPerfilId == 1 || iPerfilId == 3)
                    {
                        bRet = true;
                    }
                    else
                    {
                        bRet = false;
                    }
                    break;

                //TODOS TIENEN ACCESO
                case "NOTICIAS":
                    bRet = true;
                    break;

                default:
                    break;
            }

            return bRet;

        }

            static public bool SendMail(string sTOEmail, string sFROMEmail, string sCCEmail, string sBCCEmail, string sSubjectEmail, string sTxtBodyEmail, System.Net.Mail.MailPriority oPriority, string sDisPlayName, ref string sMessageError)
            {
                try
                {
                    // Armo el Body y lo agrego
                    System.Text.StringBuilder sHtmlMailContent = new System.Text.StringBuilder("");
                    sHtmlMailContent.Append(sTxtBodyEmail);

                    // Subject
                    string sSubject;
                    sSubject = sSubjectEmail.ToString();

                    // TO
                    string sTO = "";
                    if ((sTOEmail == ""))
                    {
                        sTO = ConfigurationManager.AppSettings["TO_MAIL"];
                    }
                    else
                    {
                        sTO = sTOEmail;

                    }

                    string sCC = "";
                    if ((sCCEmail == ""))
                    {
                        sCC = ConfigurationManager.AppSettings["CC_MAIL"];
                    }
                    else
                    {
                        sCC = sCCEmail;
                    }

                    // BCC
                    string sBCC;
                    if ((sBCCEmail == ""))
                    {
                        sBCC = ConfigurationManager.AppSettings["BCC_MAIL"];
                    }
                    else
                    {
                        sBCC = sBCCEmail;
                    }

                    string sFrom;
                    sFrom = sFROMEmail.ToString();
                    if (sFrom.Equals(""))
                    {
                        sFrom = ConfigurationManager.AppSettings["FROM_MAIL"];
                    }

                    System.Net.Mail.MailMessage msgMail = new System.Net.Mail.MailMessage();

                    System.Net.Mail.MailAddress oFrom = new System.Net.Mail.MailAddress(sFrom.ToString(), sDisPlayName.ToString());
                    msgMail.From = oFrom;

                    msgMail.Subject = sSubject;

                    // EN EL TO ADMITO LISTA CON ;
                    if (!sTO.Equals(""))
                    {
                        msgMail.To.Add(new System.Net.Mail.MailAddress(sTO.ToString()));

                    }

                    if (!sBCC.Equals(""))
                    {
                        System.Net.Mail.MailAddress bcopy = (new System.Net.Mail.MailAddress(sBCC.ToString()));
                    }


                    if ((msgMail.IsBodyHtml == true))
                    {
                        msgMail.Body = sHtmlMailContent.ToString().Replace("\r\n", "<br>");
                    }
                    else
                    {
                        msgMail.Body = sHtmlMailContent.ToString();
                    }


                    System.Net.Mail.SmtpClient mailSMTP = new System.Net.Mail.SmtpClient();

                    //zerezqustporjyac
                    mailSMTP.Host = "smtp.gmail.com";
                    mailSMTP.Port = 587;
                    mailSMTP.EnableSsl = true;

                    mailSMTP.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["SMTP_USER"].ToString(), ConfigurationManager.AppSettings["SMTP_CLAVE"].ToString());


                    {
                        var withBlock = mailSMTP;
                        withBlock.Send(msgMail);
                    }

                    sMessageError = "";
                    return true;
                }
                catch (Exception ex)
                {
                    // LOOPEAR CON INNEREXCEPTION
                    string msg = "";
                    msg = (ex.ToString() + "<br />");
                    while (!(ex.InnerException == null))
                    {
                        msg = (ex.InnerException.ToString() + "<br />");
                        ex = ex.InnerException;
                    }

                    sMessageError = ("Error enviando email: " + msg);
                    return false;
                }

            }
            #endregion


        }
    }