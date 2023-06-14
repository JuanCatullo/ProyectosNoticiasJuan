using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProyectosNoticiasJuan
{
    
	/// <summary>
	/// Summary description for ws_Noticias
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ws_Noticias : System.Web.Services.WebService
    {




        [WebMethod]
        public string HolaMundo()
        {
            return "Hola Mundo!";
        }


        [WebMethod]
        public string Sumar(int Nro1, int Nro2)
        {
            try
            {
                return (Nro1 + Nro2).ToString();
            }
            catch (Exception)
            {

                return "Hubo un error, revise los parámetros";
            }

        }






        [WebMethod]
        public DataTable ObtenerNoticias()
        {
            try
            {

                string sRet = "";
                DataTable dt = new DataTable();
        //        sRet = Utilidades.Datos.ObtenerNoticias(1, -1, ref dt);

                return dt;
            }
            catch (Exception)
            {

                return null;
            }

        }


        [WebMethod]
        public DataSet ObtenerNoticiasDS()
        {
            try
            {

                string sRet = "";
                DataSet ds = new DataSet();
                sRet = Utilidades.Datos.ObtenerNoticias(1, -1, ref ds);

                return ds;
            }
            catch (Exception)
            {

                return null;
            }

        }


        [WebMethod]
        public List<Noticia> ObtenerListaNoticias()
        {
            try
            {

                string sRet = "";
                DataTable dt = new DataTable();
           //     sRet = Utilidades.Datos.ObtenerNoticias(1, -1, ref dt);

                List<Noticia> ListaNoticias = new List<Noticia>();


                ///TODO: Revisar si los campos vienen en null de la base de datos
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Noticia myNoticia = new Noticia();

                    myNoticia.id = Int32.Parse(dt.Rows[i]["id"].ToString());


                    //MANERA 1
                    if (dt.Rows[i]["titulo"] is null)
                    {
                        myNoticia.titulo = "";
                    }
                    else
                    {
                        myNoticia.titulo = dt.Rows[i]["titulo"].ToString();
                    }

                    //MANERA 2
                    if (!DBNull.Value.Equals(dt.Rows[i]["copete"]))
                    {
                        myNoticia.copete = dt.Rows[i]["copete"].ToString();
                    }
                    else
                    {
                        myNoticia.copete = "";
                    }



                    myNoticia.texto = dt.Rows[i]["texto"].ToString();
                    myNoticia.imagen = dt.Rows[i]["imagen"].ToString();
                    myNoticia.fecha = DateTime.Parse(dt.Rows[i]["fecha"].ToString());
                    myNoticia.categoria_id = Int32.Parse(dt.Rows[i]["categoria_id"].ToString());

                    myNoticia.Descripcion = dt.Rows[i]["descripcion"].ToString();

                    ListaNoticias.Add(myNoticia);

                }

                return ListaNoticias;
            }
            catch (Exception)
            {

                return null;
            }

        }



    }
}