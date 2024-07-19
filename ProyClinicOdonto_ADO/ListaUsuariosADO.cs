using ProyClinicOdonto_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_ADO
{
   public class ListaUsuariosADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public DataTable ListarUsuario()
        {
            try
            {

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarUsuarioFinal";
                cmd.Parameters.Clear();

                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "vUsuariosCombinadosFinal");

                return dts.Tables["vUsuariosCombinadosFinal"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public Boolean InsertarUsuario(ManAdminBE objManAdminBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarUsuarioPruebaFinal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Fuente", objManAdminBE.Fuente);
                cmd.Parameters.AddWithValue("@Nombres", objManAdminBE.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", objManAdminBE.Apellidos);
                cmd.Parameters.AddWithValue("@Login_Usuario", objManAdminBE.Login_Usuario);
                cmd.Parameters.AddWithValue("@Pass_Usuario", objManAdminBE.Pass_Usuario);
                cmd.Parameters.AddWithValue("@Estado", objManAdminBE.Estado);
                cmd.Parameters.AddWithValue("@Fec_Registro", objManAdminBE.Fec_Registro);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public ManAdminBE ConsultarUsuarioDatos(String User)
        {
            ManAdminBE objManAdminBE = null; // Inicializar como null
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarUsuariosFinal";
            cmd.Parameters.Clear();

            try
            {
                // Codifique
                cmd.Parameters.AddWithValue("@Login_Usuario", User);

                // Abrimos la conexión y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows)
                {
                    dtr.Read();
                    objManAdminBE = new ManAdminBE
                    {
                        Login_Usuario = dtr["Login_Usuario"].ToString(),
                        Pass_Usuario = dtr["Pass_Usuario"].ToString(),
                        Estado = dtr["Estado"].ToString()
                    };
                }
                dtr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la consulta de datos del usuario: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre siempre
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

            return objManAdminBE;

        }


        public Boolean ActualizarUsuarioDatos(ManAdminBE objManAdminBE)
        {

            //Codifique
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarUsuarioDatos2";
            cmd.Parameters.Clear();
            try
            {
                // Añadimos los parámetros necesarios
                cmd.Parameters.AddWithValue("@Pass_Usuario", objManAdminBE.Pass_Usuario);
                cmd.Parameters.AddWithValue("@Estado", objManAdminBE.Estado);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);

            }


        }


    }
}
