using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Windows.Input;

namespace ProyectosNoticiasJuan.Utilidades
{
    public class Datos
    {

        #region "combos"

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

        #endregion


        #region "Usuarios"
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

                //ACCIONES
                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();   //abrir y cerrar es critico a nivel performance
                MyConnection.Dispose();
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




        #endregion


    }
}


