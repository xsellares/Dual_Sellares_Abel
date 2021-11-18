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

        public DataSet Actualizar(string query)
        {

            conn.Open();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            
            int result = adapter.Update(dts.Tables[0]);

            conn.Close();

            return dts;

        }

        public void HacerBindings()
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
