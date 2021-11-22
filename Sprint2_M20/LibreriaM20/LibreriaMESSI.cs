using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace LibreriaM20
{
    public class LibreriaMESSI
    {
        private SqlConnection conn;
        private DataSet dts;

        public void ConfigurarConexion()
        {
            String conexionString;
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["BaseDatosM20"];
            conexionString = conf.ConnectionString;
            conn = new SqlConnection(conexionString);

        }
        public DataSet TraerDatos(string tabla, string query)
        {
            ConfigurarConexion();
            SqlDataAdapter adapter;
            dts = new DataSet();

            
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();

            adapter.Fill(dts, tabla);

            conn.Close();

            return dts;

        }

        public int Executar(string query)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);

            int registresAfectats = cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
            return registresAfectats;
        }

        public int Actualizar(string query, DataSet dts)
        {
            int result = 0;
            conn.Open();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);


            if (dts.HasChanges())
            {
                result = adapter.Update(dts.Tables[0]);
            }

            conn.Close();

            return result;

        }

    }

    



}
