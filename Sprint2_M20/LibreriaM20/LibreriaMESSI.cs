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

        public int Actualizar(DataSet dtschanged, string tabla)
        {
            int result = 0;
            conn.Open();

            SqlDataAdapter adapter;
            query = "select * from " + tabla;
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

        public void HacerBindings(string texto, DataSet dts, string campo)
        {
            //DataBindings.Clear();
            //txtCodigo.DataBindings.Add("text", dts.Tables["Agencies"], "CodeAgency");
            //txtCodigo.Validated += new System.EventHandler(this.ValidarTextBox);
            //txtDesc.DataBindings.Clear();
            //txtDesc.DataBindings.Add("text", dts.Tables["Agencies"], "DescAgency");
            //txtDesc.Validated += new System.EventHandler(this.ValidarTextBox);
        }
    }

    



}
