using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class clsDAOPerson : clsDAO
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            con.Open();
            String sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);
            con.Close();

            return dt;
        }

        public DataTable GetbyName(String nombre)
        {
            DataTable dt = new DataTable();

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BuscarNombrePersona";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@FirstName";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = nombre;

            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);

            con.Close();
            return dt;
        }

    }
}
