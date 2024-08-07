﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_ADO
{
   public class ConsultorioListaADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
    public DataTable ConsultorioLista()
    {
        DataSet dts = new DataSet();
        cnx.ConnectionString = MiConexion.GetCnx();
        cmd.Connection = cnx;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "usp_ListarConsultorios";
        try
        {

            cmd.Parameters.Clear();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(dts, "Consultorio");
            return dts.Tables["Consultorio"];
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }

    }
    }
}
