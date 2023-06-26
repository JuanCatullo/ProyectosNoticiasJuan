using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace ProyectosNoticiasJuan.Utilidades
{
    public class Datos
    {

        
        public static string ObtenerContrasena(string sMail, ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerContrasena", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                MyDataAdapter.SelectCommand.Parameters.Add("@mail", SqlDbType.VarChar, 100);
                MyDataAdapter.SelectCommand.Parameters["@mail"].Value = sMail;

                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public static string ObtenerPaises(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerPaises", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string ObtenerUsuariosRegistrados(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerUsuariosRegistrados", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public static string ObtenerUsuarioRegistrado(int iId, ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerUsuarioRegistrado", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                MyDataAdapter.SelectCommand.Parameters.Add("@usuario_id", SqlDbType.Int);
                MyDataAdapter.SelectCommand.Parameters["@usuario_id"].Value = iId;


                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string ObtenerNoticia(int iId, ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerNoticia", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                MyDataAdapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int);
                MyDataAdapter.SelectCommand.Parameters["@id"].Value = iId;

                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


       public static string ObtenerNoticias(int iActivoId,int iCategoria, ref DataSet ds)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerNoticias", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                MyDataAdapter.SelectCommand.Parameters.Add("@activo", SqlDbType.Int);
                MyDataAdapter.SelectCommand.Parameters["@activo"].Value = iActivoId;

                MyDataAdapter.SelectCommand.Parameters.Add("@categoria_id", SqlDbType.Int);
                MyDataAdapter.SelectCommand.Parameters["@categoria_id"].Value = iCategoria;

                ds = new DataSet();
                MyDataAdapter.Fill(ds);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string ObtenerCursos(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerCursos", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string ObtenerConocimientos(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerConocimientos", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string ObtenerCategoria(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerCategoriaNoticias", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string ActualizarUsuario(int iId, string sNombre, string sApellido, string sDni, string sEmail, int iPais, int RadioButtonList1, DateTime sFecha, string sConocimientos, string sClave)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlCommand MyCommand = default(SqlCommand);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyCommand = new SqlCommand("spActualizarUsuario", MyConnection);
                MyCommand.CommandType = CommandType.StoredProcedure;

                //AGREGO EL PARAMETRO CON EL VALOR DEL PARAMETRO AL COMANDO
                MyCommand.Parameters.AddWithValue("@id", iId);

                MyCommand.Parameters.AddWithValue("@nombre", sNombre);

                MyCommand.Parameters.AddWithValue("@apellido", sApellido);

                MyCommand.Parameters.AddWithValue("@dni", sDni);

                MyCommand.Parameters.AddWithValue("@email", sEmail);

                MyCommand.Parameters.AddWithValue("@id_pais", iPais);

                MyCommand.Parameters.AddWithValue("@curso_id", RadioButtonList1);
                MyCommand.Parameters.AddWithValue("@fecha_nacimiento", sFecha);
                MyCommand.Parameters.AddWithValue("@conocimientos", sConocimientos);
                MyCommand.Parameters.AddWithValue("@contraseña", sClave);

                //ACCIONES A MANO
                MyConnection.Open(); //ABRO CONEXION
                MyCommand.ExecuteNonQuery(); //EJECUTO COMANDO
                MyConnection.Close(); //CIERRO CONEXION
                MyConnection.Dispose(); //DESCARTO CONEXION

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static string ActualizarNoticia(int iId, string sTitulo, string sCopete, string sTexto, string sFoto, int sOrden, DateTime sFecha, int sActivo, int sCategoria)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlCommand MyCommand = default(SqlCommand);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyCommand = new SqlCommand("spActualizarNoticia", MyConnection);
                MyCommand.CommandType = CommandType.StoredProcedure;

                //AGREGO EL PARAMETRO CON EL VALOR DEL PARAMETRO AL COMANDO
                MyCommand.Parameters.AddWithValue("@id", iId);

                MyCommand.Parameters.AddWithValue("@titulo", sTitulo);

                MyCommand.Parameters.AddWithValue("@copete", sCopete);

                MyCommand.Parameters.AddWithValue("@texto", sTexto);
                MyCommand.Parameters.AddWithValue("@imagen", sFoto);
                MyCommand.Parameters.AddWithValue("@orden", sOrden);
                MyCommand.Parameters.AddWithValue("@fecha", sFecha);
                MyCommand.Parameters.AddWithValue("@activo", sActivo);
                MyCommand.Parameters.AddWithValue("@id_categoria", sCategoria);


                //ACCIONES A MANO
                MyConnection.Open(); //ABRO CONEXION
                MyCommand.ExecuteNonQuery(); //EJECUTO COMANDO
                MyConnection.Close(); //CIERRO CONEXION
                MyConnection.Dispose(); //DESCARTO CONEXION

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public static string InsertarUsuario(string sNombre, string sApellido, string sDni, string sEmail, int sDdlPais, int RadioButtonList1, DateTime sFecha, string sConocimientos, string sClave)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlCommand MyCommand = default(SqlCommand);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyCommand = new SqlCommand("spInsertarUsuario", MyConnection);
                MyCommand.CommandType = CommandType.StoredProcedure;

                //AGREGO EL PARAMETRO CON EL VALOR DEL PARAMETRO AL COMANDO
                //MyCommand.Parameters.AddWithValue("@id", iId);

                MyCommand.Parameters.AddWithValue("@nombre", sNombre);

                MyCommand.Parameters.AddWithValue("@apellido", sApellido);

                MyCommand.Parameters.AddWithValue("@dni", sDni);
                MyCommand.Parameters.AddWithValue("@email", sEmail);
                MyCommand.Parameters.AddWithValue("@id_pais", sDdlPais);
                MyCommand.Parameters.AddWithValue("@curso_id", RadioButtonList1);
                MyCommand.Parameters.AddWithValue("@fecha_nacimiento", sFecha);
                MyCommand.Parameters.AddWithValue("@conocimientos", sConocimientos);
                MyCommand.Parameters.AddWithValue("@contraseña", sClave);
               

                //ACCIONES A MANO
                MyConnection.Open(); //ABRO CONEXION
                MyCommand.ExecuteNonQuery(); //EJECUTO COMANDO
                MyConnection.Close(); //CIERRO CONEXION
                MyConnection.Dispose(); //DESCARTO CONEXION

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static string InsertarNoticia(string sTitulo, string sCopete, string sTexto, string sFoto, int sOrden, DateTime sFecha, int sActivo, int sCategoria)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlCommand MyCommand = default(SqlCommand);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyCommand = new SqlCommand("spInsertarNoticia", MyConnection);
                MyCommand.CommandType = CommandType.StoredProcedure;

                //AGREGO EL PARAMETRO CON EL VALOR DEL PARAMETRO AL COMANDO
                //MyCommand.Parameters.AddWithValue("@id", iId);

                MyCommand.Parameters.AddWithValue("@titulo", sTitulo);

                MyCommand.Parameters.AddWithValue("@copete", sCopete);

                MyCommand.Parameters.AddWithValue("@texto", sTexto);
                MyCommand.Parameters.AddWithValue("@imagen", sFoto);
                MyCommand.Parameters.AddWithValue("@Orden", sOrden);
                MyCommand.Parameters.AddWithValue("@fecha", sFecha);
                MyCommand.Parameters.AddWithValue("@Activo", sActivo);
                MyCommand.Parameters.AddWithValue("@id_categoria", sCategoria);

                //ACCIONES A MANO
                MyConnection.Open(); //ABRO CONEXION
                MyCommand.ExecuteNonQuery(); //EJECUTO COMANDO
                MyConnection.Close(); //CIERRO CONEXION
                MyConnection.Dispose(); //DESCARTO CONEXION

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public static string EliminarUsuario(int iId)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlCommand MyCommand = default(SqlCommand);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyCommand = new SqlCommand("spEliminarUsuario", MyConnection);
                MyCommand.CommandType = CommandType.StoredProcedure;

                MyCommand.Parameters.AddWithValue("@id", iId);

                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();
                MyConnection.Dispose();

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public static string EliminarNoticia(int iId)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlCommand MyCommand = default(SqlCommand);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyCommand = new SqlCommand("spEliminarNoticia", MyConnection);
                MyCommand.CommandType = CommandType.StoredProcedure;

                MyCommand.Parameters.AddWithValue("@id_noticia", iId);

                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();
                MyConnection.Dispose();

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
        public static string LoginUsuario(string sUsuario, string sClave, ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spLoginUsuario", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                MyDataAdapter.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 50);
                MyDataAdapter.SelectCommand.Parameters["@usuario"].Value = sUsuario;

                MyDataAdapter.SelectCommand.Parameters.Add("@clave", SqlDbType.VarChar, 50);
                MyDataAdapter.SelectCommand.Parameters["@clave"].Value = sClave;


                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string ObtenerCategoriasNoticias(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerCategoriasNoticias", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #region "SORTING / PAGING"

        public static void SortGridView(ref string sSortExpression, ref string sDirection)
        {

            if (!string.IsNullOrEmpty(sSortExpression) | !string.IsNullOrEmpty(sDirection))
            {
                string myDirection = sDirection.Trim();

                if (string.IsNullOrEmpty(myDirection))
                {
                    myDirection = System.Web.UI.WebControls.SortDirection.Descending.ToString();
                }
                else
                {
                    if (myDirection == "ASC")
                    {
                        myDirection = System.Web.UI.WebControls.SortDirection.Descending.ToString();
                    }
                    else
                    {
                        myDirection = System.Web.UI.WebControls.SortDirection.Ascending.ToString();
                    }
                }

                switch (myDirection.ToUpper().Trim())
                {
                    case "ASCENDING":
                        sDirection = " ASC";
                        break;
                    case "DESCENDING":
                        sDirection = " DESC";
                        break;
                }


            }

        }
         #endregion




    }
}





