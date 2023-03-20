using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan.Manager
{
    public partial class Usuario : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}