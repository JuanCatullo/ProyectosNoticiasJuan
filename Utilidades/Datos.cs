using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FormularioRegistro.Utilidades
{
    public class Datos
    {

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

        public static string ObtenerUsuariosRegistrados(int iId, ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerUsuariosRegistrados", MyConnection);
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

        #region "combos"

        

        public static string ObtenerPaises(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spPaises", MyConnection);
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

        public static string ObtenerCursos(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spCursos", MyConnection);
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
                #endregion          
            }
        }

            public static string EliminarUsuario (int id, string txtname, string txtlastname, string txtdni, int ddlpais, int miRadioButtonList, string email, string Fechanac, string otros, string password)
        {
                SqlConnection MyConnection = default(SqlConnection);
                SqlCommand MyCommand = default(SqlCommand);

                try
                {
                    MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                    MyCommand = new SqlCommand("spEliminarUsuario", MyConnection);
                    MyCommand.CommandType = CommandType.StoredProcedure;

                //AGREGO EL PARAMETRO CON EL VALOR DEL PARAMETRO AL COMANDO

                      MyCommand.Parameters.AddWithValue("@id", id);

                     MyCommand.Parameters.AddWithValue("@nombre", txtname);

                    MyCommand.Parameters.AddWithValue("@apellido", txtlastname);

                    MyCommand.Parameters.AddWithValue("@dni", txtdni);

                    MyCommand.Parameters.AddWithValue("@id_pais", ddlpais);

                    MyCommand.Parameters.AddWithValue("@curso_id", miRadioButtonList);

                    MyCommand.Parameters.AddWithValue("@email", email);

                    MyCommand.Parameters.AddWithValue("@fecha_nacimiento", Fechanac);

                    MyCommand.Parameters.AddWithValue("@conocimientos", otros);

                    MyCommand.Parameters.AddWithValue("@contraseña", password);





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


            public static string ActualizarUsuario(int iId, string txtname, string txtlastname, string txtdni, int ddlpais, int miRadioButtonList, string email, string Fechanac, string otros, string password)
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

                    MyCommand.Parameters.AddWithValue("@nombre", txtname);

                    MyCommand.Parameters.AddWithValue("@apellido", txtlastname);

                    MyCommand.Parameters.AddWithValue("@dni", txtdni);

                    MyCommand.Parameters.AddWithValue("@id_pais", ddlpais);

                    MyCommand.Parameters.AddWithValue("@curso_id", miRadioButtonList);

                    MyCommand.Parameters.AddWithValue("@email", email);

                    MyCommand.Parameters.AddWithValue("@fecha_nacimiento", Fechanac);

                    MyCommand.Parameters.AddWithValue("@conocimientos", otros);

                    MyCommand.Parameters.AddWithValue("@contraseña", password);

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

        public static string InsertarUsuario(int iId, string txtname, string txtlastname, string txtdni, int ddlpais, int miRadioButtonList, string email, string Fechanac, string otros, string password)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlCommand MyCommand = default(SqlCommand);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyCommand = new SqlCommand("spInsertarUsuario", MyConnection);
                MyCommand.CommandType = CommandType.StoredProcedure;

                //AGREGO EL PARAMETRO CON EL VALOR DEL PARAMETRO AL COMANDO
                
                MyCommand.Parameters.AddWithValue("@nombre", txtname);

                MyCommand.Parameters.AddWithValue("@apellido", txtlastname);

                MyCommand.Parameters.AddWithValue("@dni", txtdni);

                MyCommand.Parameters.AddWithValue("@id_pais", ddlpais);

                MyCommand.Parameters.AddWithValue("@curso_id", miRadioButtonList);

                MyCommand.Parameters.AddWithValue("@email", email);

                MyCommand.Parameters.AddWithValue("@fecha_nacimiento", Fechanac);

                MyCommand.Parameters.AddWithValue("@conocimientos", otros);

                MyCommand.Parameters.AddWithValue("@contraseña", password);






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

    }

        
    }
