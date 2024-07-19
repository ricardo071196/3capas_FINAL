using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyClinicOdonto_BE;

namespace ProyClinicOdonto_ADO
{
    public class HorarioADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable HorarioLista()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarOdontologosHorarios";
            try
            {

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "VistaOdontologosHorarios");
                return dts.Tables["VistaOdontologosHorarios"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean InsertarHorario(HorarioBE objHorarioBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarHorario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Idodontologo", objHorarioBE.Idodontologo);
                cmd.Parameters.AddWithValue("@Lunes", objHorarioBE.Lunes);
                cmd.Parameters.AddWithValue("@Martes", objHorarioBE.Martes);
                cmd.Parameters.AddWithValue("@Miércoles", objHorarioBE.Miércoles);
                cmd.Parameters.AddWithValue("@Jueves", objHorarioBE.Jueves);
                cmd.Parameters.AddWithValue("@Viernes", objHorarioBE.Viernes);
                cmd.Parameters.AddWithValue("@Sábado", objHorarioBE.Sábado);
                // cmd.Parameters.AddWithValue("@Idlocal", objEquipoBE.Idlocal);
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


    }
}
