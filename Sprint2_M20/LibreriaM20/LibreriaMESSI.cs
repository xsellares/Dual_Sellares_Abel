using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace LibreriaM20
{
    public class LibreriaMESSI
    {
        private SqlConnection conn;
        private string query;
        DataSet dts;

        public void ConfigurarConexion()
        {
            ConnectionStringSettings conf = new ConnectionStringSettings();
            string conexionString = conf.ConnectionString;
            conn = new SqlConnection(conexionString);
        }
        public DataSet TraerDatos(string taula)
        {
            ConfigurarConexion();
            SqlDataAdapter adapter;
            dts = new DataSet();

            query = "select * from Agencies";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();

            adapter.Fill(dts, "Agencies");

            conn.Close();

            return dts;
        }

        public int Actualizar()
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

        private void HacerBindings()
        {

        }
    }

    



}
